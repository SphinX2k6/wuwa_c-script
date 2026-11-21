using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD4 RID: 23508
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractPointManager : Singleton
	{
		// Token: 0x17006E17 RID: 28183
		// (get) Token: 0x06039C50 RID: 236624 RVA: 0x0103A04C File Offset: 0x0103824C
		public int PointSize
		{
			get
			{
				return this.Points.Count;
			}
		}

		// Token: 0x06039C51 RID: 236625 RVA: 0x0103A05C File Offset: 0x0103825C
		public void Register(ISceneInteractPointSource source)
		{
			if (!this.Sources.Add(source))
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (ISceneInteractPoint sceneInteractPoint in source.GetInteractPoints())
			{
				int nextPointId = this.NextPointId;
				this.NextPointId = nextPointId + 1;
				int num = nextPointId;
				this.Points[num] = sceneInteractPoint;
				this.PointIds.Set(sceneInteractPoint, num);
				list.Add(num);
				sceneInteractPoint.Init();
			}
			this.SourcePointIds[source] = list;
		}

		// Token: 0x06039C52 RID: 236626 RVA: 0x0103A100 File Offset: 0x01038300
		public void Unregister(ISceneInteractPointSource source)
		{
			if (!this.Sources.Remove(source))
			{
				return;
			}
			List<int> list;
			if (!this.SourcePointIds.TryGetValue(source, out list))
			{
				return;
			}
			foreach (int num in list)
			{
				ISceneInteractPoint sceneInteractPoint;
				if (this.Points.TryGetValue(num, out sceneInteractPoint))
				{
					sceneInteractPoint.Clear();
					this.PointIds.Remove(sceneInteractPoint);
				}
				this.Points.Remove(num);
				this.NotifyPointRemoved(num);
			}
			this.SourcePointIds.Remove(source);
		}

		// Token: 0x06039C53 RID: 236627 RVA: 0x0103A1AC File Offset: 0x010383AC
		public IEnumerable<ISceneInteractPointSource> GetSources()
		{
			return this.Sources;
		}

		// Token: 0x06039C54 RID: 236628 RVA: 0x0103A1B4 File Offset: 0x010383B4
		public IReadOnlyDictionary<int, ISceneInteractPoint> GetPoints()
		{
			return this.Points;
		}

		// Token: 0x06039C55 RID: 236629 RVA: 0x0103A1BC File Offset: 0x010383BC
		[NullableContext(2)]
		public ISceneInteractPoint GetPoint(int pointId)
		{
			return this.Points.GetValueOrDefault(pointId);
		}

		// Token: 0x06039C56 RID: 236630 RVA: 0x0103A1CC File Offset: 0x010383CC
		public int? GetPointId(ISceneInteractPoint point)
		{
			int value;
			if (!this.PointIds.TryGetValue(point, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06039C57 RID: 236631 RVA: 0x0103A1F9 File Offset: 0x010383F9
		public void AddPointRemovedListener(Action<int> listener)
		{
			this.PointRemovedListeners.Add(listener);
		}

		// Token: 0x06039C58 RID: 236632 RVA: 0x0103A208 File Offset: 0x01038408
		public void RemovePointRemovedListener(Action<int> listener)
		{
			this.PointRemovedListeners.Remove(listener);
		}

		// Token: 0x06039C59 RID: 236633 RVA: 0x0103A218 File Offset: 0x01038418
		public void Clear()
		{
			foreach (KeyValuePair<int, ISceneInteractPoint> keyValuePair in this.Points)
			{
				int key = keyValuePair.Key;
				keyValuePair.Value.Clear();
				this.NotifyPointRemoved(key);
			}
			this.Sources.Clear();
			this.Points.Clear();
			this.PointIds = new WeakMap<ISceneInteractPoint, int>();
			this.SourcePointIds.Clear();
			this.PointRemovedListeners.Clear();
			this.NextPointId = 1;
		}

		// Token: 0x06039C5A RID: 236634 RVA: 0x0103A2C0 File Offset: 0x010384C0
		private void NotifyPointRemoved(int pointId)
		{
			foreach (Action<int> action in this.PointRemovedListeners)
			{
				action(pointId);
			}
		}

		// Token: 0x17006E18 RID: 28184
		// (get) Token: 0x06039C5B RID: 236635 RVA: 0x0103A314 File Offset: 0x01038514
		public static SceneInteractPointManager Instance
		{
			get
			{
				if (SceneInteractPointManager._instance == null)
				{
					SceneInteractPointManager._instance = new SceneInteractPointManager();
					SceneInteractPointManager._instance.OnInit();
				}
				return SceneInteractPointManager._instance;
			}
		}

		// Token: 0x06039C5C RID: 236636 RVA: 0x0103A337 File Offset: 0x01038537
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039C5D RID: 236637 RVA: 0x0103A339 File Offset: 0x01038539
		public static void ResetStaticDefaultValue()
		{
			SceneInteractPointManager instance = SceneInteractPointManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneInteractPointManager._instance = null;
		}

		// Token: 0x06039C5E RID: 236638 RVA: 0x0103A352 File Offset: 0x01038552
		static SceneInteractPointManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractPointManager.CreateStaticDefaultValue), new Action(SceneInteractPointManager.ResetStaticDefaultValue));
		}

		// Token: 0x0401E84F RID: 125007
		private int NextPointId = 1;

		// Token: 0x0401E850 RID: 125008
		private readonly HashSet<ISceneInteractPointSource> Sources = new HashSet<ISceneInteractPointSource>();

		// Token: 0x0401E851 RID: 125009
		private readonly Dictionary<int, ISceneInteractPoint> Points = new Dictionary<int, ISceneInteractPoint>();

		// Token: 0x0401E852 RID: 125010
		private WeakMap<ISceneInteractPoint, int> PointIds = new WeakMap<ISceneInteractPoint, int>();

		// Token: 0x0401E853 RID: 125011
		private readonly Dictionary<ISceneInteractPointSource, List<int>> SourcePointIds = new Dictionary<ISceneInteractPointSource, List<int>>();

		// Token: 0x0401E854 RID: 125012
		private readonly HashSet<Action<int>> PointRemovedListeners = new HashSet<Action<int>>();

		// Token: 0x0401E855 RID: 125013
		[Nullable(2)]
		private static SceneInteractPointManager _instance;
	}
}
