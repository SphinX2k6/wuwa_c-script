using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Model;
using CSharpScript.Game.NewWorld.SceneItem.Interface;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x0200723D RID: 29245
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemGraphController : ControllerBase
	{
		// Token: 0x06047AC7 RID: 293575 RVA: 0x01257FD4 File Offset: 0x012561D4
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

		// Token: 0x06047AC8 RID: 293576 RVA: 0x01258040 File Offset: 0x01256240
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

		// Token: 0x06047AC9 RID: 293577 RVA: 0x0125809D File Offset: 0x0125629D
		private int GetDebugLevel()
		{
			SundryModel instance = SundryModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.GetModuleDebugLevel("SceneItemGraphComponent");
		}

		// Token: 0x06047ACA RID: 293578 RVA: 0x012580B4 File Offset: 0x012562B4
		private void OnChangeModuleDebugLevel(string key, int level)
		{
			if (key != "SceneItemGraphComponent")
			{
				return;
			}
			this.RedrawAll();
		}

		// Token: 0x06047ACB RID: 293579 RVA: 0x012580CC File Offset: 0x012562CC
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
			foreach (ISceneItemGraph sceneItemGraph in (enumerable ?? Enumerable.Empty<ISceneItemGraph>()))
			{
				sceneItemGraph.DebugDraw(debugLevel);
			}
			Dictionary<int, ISceneItemGraph> sceneItemGraphs2 = GraphModel.Instance.SceneItemGraphs;
			this.DebugDrawActive = (((sceneItemGraphs2 != null) ? sceneItemGraphs2.Count : 0) > 0);
		}

		// Token: 0x06047ACC RID: 293580 RVA: 0x01258184 File Offset: 0x01256384
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

		// Token: 0x06047ACD RID: 293581 RVA: 0x0125819C File Offset: 0x0125639C
		[return: Nullable(2)]
		public ISceneItemGraph FindNearestGraph(Vector location, float maxDistance = 0f)
		{
			ISceneItemGraph result = null;
			double num = (maxDistance > 0f) ? ((double)(maxDistance * maxDistance)) : double.MaxValue;
			Dictionary<int, ISceneItemGraph> sceneItemGraphs = GraphModel.Instance.SceneItemGraphs;
			IEnumerable<ISceneItemGraph> enumerable = (sceneItemGraphs != null) ? sceneItemGraphs.Values : null;
			foreach (ISceneItemGraph sceneItemGraph in (enumerable ?? Enumerable.Empty<ISceneItemGraph>()))
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

		// Token: 0x06047ACE RID: 293582 RVA: 0x01258254 File Offset: 0x01256454
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

		// Token: 0x17009E44 RID: 40516
		// (get) Token: 0x06047ACF RID: 293583 RVA: 0x012582E4 File Offset: 0x012564E4
		public static SceneItemGraphController Instance
		{
			get
			{
				return SceneItemGraphController._Instance;
			}
		}

		// Token: 0x06047AD0 RID: 293584 RVA: 0x012582EB File Offset: 0x012564EB
		public static SceneItemGraphController GetOrCreateInstance()
		{
			if (SceneItemGraphController._Instance == null)
			{
				SceneItemGraphController.CreateInstance();
			}
			return SceneItemGraphController._Instance;
		}

		// Token: 0x06047AD1 RID: 293585 RVA: 0x012582FF File Offset: 0x012564FF
		public static bool CreateInstance()
		{
			if (SceneItemGraphController._Instance != null)
			{
				return true;
			}
			SceneItemGraphController._Instance = new SceneItemGraphController();
			return true;
		}

		// Token: 0x06047AD2 RID: 293586 RVA: 0x01258315 File Offset: 0x01256515
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047AD3 RID: 293587 RVA: 0x01258317 File Offset: 0x01256517
		public static void ResetStaticDefaultValue()
		{
			SceneItemGraphController._Instance = null;
		}

		// Token: 0x06047AD4 RID: 293588 RVA: 0x0125831F File Offset: 0x0125651F
		static SceneItemGraphController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemGraphController.CreateStaticDefaultValue), new Action(SceneItemGraphController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B5D RID: 154461
		private bool DebugDrawActive;

		// Token: 0x04025B5E RID: 154462
		[Nullable(2)]
		private static SceneItemGraphController _Instance;
	}
}
