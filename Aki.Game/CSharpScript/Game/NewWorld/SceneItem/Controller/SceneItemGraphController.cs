using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Model;
using CSharpScript.Game.NewWorld.SceneItem.Interface;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x020062F2 RID: 25330
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemGraphController : ControllerBase
	{
		// Token: 0x0603D429 RID: 250921 RVA: 0x011B0C84 File Offset: 0x011AEE84
		public void Register(int entityId, ISceneItemGraph sceneItemGraph)
		{
			if (GraphModel.Instance.SceneItemGraphs != null)
			{
				GraphModel.Instance.SceneItemGraphs[entityId] = sceneItemGraph;
				if (GraphModel.Instance.SceneItemGraphs.Count == 1)
				{
					EventSystem.Instance.Add(EEventName.OnChangeModuleDebugLevel, new Action<string, int>(this.OnChangeModuleDebugLevel));
				}
			}
			int debugLevel = this.GetDebugLevel();
			if (debugLevel >= 4)
			{
				sceneItemGraph.DebugDraw(debugLevel);
			}
		}

		// Token: 0x0603D42A RID: 250922 RVA: 0x011B0CF0 File Offset: 0x011AEEF0
		public void Unregister(int entityId)
		{
			Dictionary<int, ISceneItemGraph> sceneItemGraphs = GraphModel.Instance.SceneItemGraphs;
			if (sceneItemGraphs == null || !sceneItemGraphs.Remove(entityId))
			{
				return;
			}
			if (GraphModel.Instance.SceneItemGraphs.Count == 0)
			{
				EventSystem.Instance.Remove(EEventName.OnChangeModuleDebugLevel, new Action<string, int>(this.OnChangeModuleDebugLevel));
			}
			this.RedrawAll();
		}

		// Token: 0x0603D42B RID: 250923 RVA: 0x011B0D4D File Offset: 0x011AEF4D
		private int GetDebugLevel()
		{
			SundryModel instance = SundryModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.GetModuleDebugLevel("SceneItemGraphComponent");
		}

		// Token: 0x0603D42C RID: 250924 RVA: 0x011B0D64 File Offset: 0x011AEF64
		private void OnChangeModuleDebugLevel(string key, int level)
		{
			if (key != "SceneItemGraphComponent")
			{
				return;
			}
			this.RedrawAll();
		}

		// Token: 0x0603D42D RID: 250925 RVA: 0x011B0D7C File Offset: 0x011AEF7C
		private void RedrawAll()
		{
			UWorld world = GlobalData.World;
			if (this.DebugDrawActive && world != null)
			{
				UKismetSystemLibrary.FlushPersistentDebugLines(world);
				UKismetSystemLibrary.FlushDebugStrings(world);
			}
			this.DebugDrawActive = false;
			int debugLevel = this.GetDebugLevel();
			if (debugLevel < 4)
			{
				return;
			}
			Dictionary<int, ISceneItemGraph> sceneItemGraphs = GraphModel.Instance.SceneItemGraphs;
			IEnumerable<ISceneItemGraph> enumerable = (sceneItemGraphs != null) ? sceneItemGraphs.Values : null;
			foreach (ISceneItemGraph sceneItemGraph in (enumerable ?? Array.Empty<ISceneItemGraph>()))
			{
				sceneItemGraph.DebugDraw(debugLevel);
			}
			Dictionary<int, ISceneItemGraph> sceneItemGraphs2 = GraphModel.Instance.SceneItemGraphs;
			this.DebugDrawActive = (((sceneItemGraphs2 != null) ? sceneItemGraphs2.Count : 0) > 0);
		}

		// Token: 0x0603D42E RID: 250926 RVA: 0x011B0E34 File Offset: 0x011AF034
		[NullableContext(2)]
		public ISceneItemGraph GetGraphByEntityId(int entityId)
		{
			Dictionary<int, ISceneItemGraph> sceneItemGraphs = GraphModel.Instance.SceneItemGraphs;
			if (sceneItemGraphs == null)
			{
				return null;
			}
			return sceneItemGraphs.GetValueOrDefault(entityId);
		}

		// Token: 0x0603D42F RID: 250927 RVA: 0x011B0E4C File Offset: 0x011AF04C
		[return: Nullable(2)]
		public ISceneItemGraph FindNearestGraph(Vector location, float maxDistance = 0f)
		{
			ISceneItemGraph result = null;
			double num = (maxDistance > 0f) ? ((double)(maxDistance * maxDistance)) : double.MaxValue;
			Dictionary<int, ISceneItemGraph> sceneItemGraphs = GraphModel.Instance.SceneItemGraphs;
			IEnumerable<ISceneItemGraph> enumerable = (sceneItemGraphs != null) ? sceneItemGraphs.Values : null;
			foreach (ISceneItemGraph sceneItemGraph in (enumerable ?? Array.Empty<ISceneItemGraph>()))
			{
				double? nearestNodeDistSquared = sceneItemGraph.GetNearestNodeDistSquared(location);
				if (nearestNodeDistSquared != null)
				{
					double? num2 = nearestNodeDistSquared;
					double num3 = num;
					if (num2.GetValueOrDefault() < num3 & num2 != null)
					{
						num = nearestNodeDistSquared.Value;
						result = sceneItemGraph;
					}
				}
			}
			return result;
		}

		// Token: 0x0603D430 RID: 250928 RVA: 0x011B0F04 File Offset: 0x011AF104
		public unsafe List<int> CollectCandidates(ISceneItemGraph graph, Vector selfLocation, float onNodeRadius)
		{
			int? nodeIdAtLocation = graph.GetNodeIdAtLocation(selfLocation, (double)onNodeRadius);
			if (nodeIdAtLocation != null)
			{
				return graph.GetNeighborNodeIds(nodeIdAtLocation.Value);
			}
			ValueTuple<int, int>? currentEdge = graph.GetCurrentEdge(selfLocation);
			if (currentEdge == null)
			{
				return new List<int>();
			}
			int num = 2;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int num2 = 0;
			*span[num2] = currentEdge.Value.Item1;
			num2++;
			*span[num2] = currentEdge.Value.Item2;
			return list;
		}

		// Token: 0x170073FB RID: 29691
		// (get) Token: 0x0603D431 RID: 250929 RVA: 0x011B0F94 File Offset: 0x011AF194
		public static SceneItemGraphController Instance
		{
			get
			{
				return SceneItemGraphController._Instance;
			}
		}

		// Token: 0x0603D432 RID: 250930 RVA: 0x011B0F9B File Offset: 0x011AF19B
		public static SceneItemGraphController GetOrCreateInstance()
		{
			if (SceneItemGraphController._Instance == null)
			{
				SceneItemGraphController.CreateInstance();
			}
			return SceneItemGraphController._Instance;
		}

		// Token: 0x0603D433 RID: 250931 RVA: 0x011B0FAF File Offset: 0x011AF1AF
		public static bool CreateInstance()
		{
			if (SceneItemGraphController._Instance != null)
			{
				return true;
			}
			SceneItemGraphController._Instance = new SceneItemGraphController();
			return true;
		}

		// Token: 0x0603D434 RID: 250932 RVA: 0x011B0FC5 File Offset: 0x011AF1C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D435 RID: 250933 RVA: 0x011B0FC7 File Offset: 0x011AF1C7
		public static void ResetStaticDefaultValue()
		{
			SceneItemGraphController._Instance = null;
		}

		// Token: 0x0603D436 RID: 250934 RVA: 0x011B0FCF File Offset: 0x011AF1CF
		static SceneItemGraphController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemGraphController.CreateStaticDefaultValue), new Action(SceneItemGraphController.ResetStaticDefaultValue));
		}

		// Token: 0x040207CC RID: 133068
		private bool DebugDrawActive;

		// Token: 0x040207CD RID: 133069
		[Nullable(2)]
		private static SceneItemGraphController _Instance;
	}
}
