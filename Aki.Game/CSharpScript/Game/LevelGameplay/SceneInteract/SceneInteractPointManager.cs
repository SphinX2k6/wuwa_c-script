using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A77 RID: 27255
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractPointManager : Singleton
	{
		// Token: 0x17009932 RID: 39218
		// (get) Token: 0x06043C02 RID: 277506 RVA: 0x0109580C File Offset: 0x01093A0C
		public int PointSize
		{
			get
			{
				return this.Points.Count;
			}
		}

		// Token: 0x06043C03 RID: 277507 RVA: 0x0109581C File Offset: 0x01093A1C
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

		// Token: 0x06043C04 RID: 277508 RVA: 0x010958C0 File Offset: 0x01093AC0
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

		// Token: 0x06043C05 RID: 277509 RVA: 0x0109596C File Offset: 0x01093B6C
		public IEnumerable<ISceneInteractPointSource> GetSources()
		{
			return this.Sources;
		}

		// Token: 0x06043C06 RID: 277510 RVA: 0x01095974 File Offset: 0x01093B74
		public IReadOnlyDictionary<int, ISceneInteractPoint> GetPoints()
		{
			return this.Points;
		}

		// Token: 0x06043C07 RID: 277511 RVA: 0x0109597C File Offset: 0x01093B7C
		[NullableContext(2)]
		public ISceneInteractPoint GetPoint(int pointId)
		{
			return this.Points.GetValueOrDefault(pointId);
		}

		// Token: 0x06043C08 RID: 277512 RVA: 0x0109598C File Offset: 0x01093B8C
		public int? GetPointId(ISceneInteractPoint point)
		{
			int value;
			if (!this.PointIds.TryGetValue(point, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06043C09 RID: 277513 RVA: 0x010959B9 File Offset: 0x01093BB9
		public void AddPointRemovedListener(Action<int> listener)
		{
			this.PointRemovedListeners.Add(listener);
		}

		// Token: 0x06043C0A RID: 277514 RVA: 0x010959C8 File Offset: 0x01093BC8
		public void RemovePointRemovedListener(Action<int> listener)
		{
			this.PointRemovedListeners.Remove(listener);
		}

		// Token: 0x06043C0B RID: 277515 RVA: 0x010959D8 File Offset: 0x01093BD8
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

		// Token: 0x06043C0C RID: 277516 RVA: 0x01095A80 File Offset: 0x01093C80
		private void NotifyPointRemoved(int pointId)
		{
			foreach (Action<int> action in this.PointRemovedListeners)
			{
				action(pointId);
			}
		}

		// Token: 0x17009933 RID: 39219
		// (get) Token: 0x06043C0D RID: 277517 RVA: 0x01095AD4 File Offset: 0x01093CD4
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

		// Token: 0x06043C0E RID: 277518 RVA: 0x01095AF7 File Offset: 0x01093CF7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043C0F RID: 277519 RVA: 0x01095AF9 File Offset: 0x01093CF9
		public static void ResetStaticDefaultValue()
		{
			SceneInteractPointManager instance = SceneInteractPointManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneInteractPointManager._instance = null;
		}

		// Token: 0x06043C10 RID: 277520 RVA: 0x01095B12 File Offset: 0x01093D12
		static SceneInteractPointManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractPointManager.CreateStaticDefaultValue), new Action(SceneInteractPointManager.ResetStaticDefaultValue));
		}

		// Token: 0x0402365D RID: 144989
		private int NextPointId = 1;

		// Token: 0x0402365E RID: 144990
		private readonly HashSet<ISceneInteractPointSource> Sources = new HashSet<ISceneInteractPointSource>();

		// Token: 0x0402365F RID: 144991
		private readonly Dictionary<int, ISceneInteractPoint> Points = new Dictionary<int, ISceneInteractPoint>();

		// Token: 0x04023660 RID: 144992
		private WeakMap<ISceneInteractPoint, int> PointIds = new WeakMap<ISceneInteractPoint, int>();

		// Token: 0x04023661 RID: 144993
		private readonly Dictionary<ISceneInteractPointSource, List<int>> SourcePointIds = new Dictionary<ISceneInteractPointSource, List<int>>();

		// Token: 0x04023662 RID: 144994
		private readonly HashSet<Action<int>> PointRemovedListeners = new HashSet<Action<int>>();

		// Token: 0x04023663 RID: 144995
		[Nullable(2)]
		private static SceneInteractPointManager _instance;
	}
}
