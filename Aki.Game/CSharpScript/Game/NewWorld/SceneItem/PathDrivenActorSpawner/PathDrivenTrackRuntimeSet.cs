using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071D1 RID: 29137
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenTrackRuntimeSet
	{
		// Token: 0x060474E9 RID: 292073 RVA: 0x01221D23 File Offset: 0x0121FF23
		public PathDrivenTrackRuntimeSet(int ownerEntityId)
		{
			this.OwnerEntityId = ownerEntityId;
		}

		// Token: 0x060474EA RID: 292074 RVA: 0x01221D3D File Offset: 0x0121FF3D
		public void AddTrack(IPathDrivenSplineRuntimeData trackRuntimeData)
		{
			if (!this.Released)
			{
				this.TrackList.Add(trackRuntimeData);
				return;
			}
			GameSplineModel instance = GameSplineModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ReleaseSpline(trackRuntimeData.SplineEntityId, (long)this.OwnerEntityId, EIdType.EntityId);
		}

		// Token: 0x060474EB RID: 292075 RVA: 0x01221D74 File Offset: 0x0121FF74
		public void Release()
		{
			if (this.Released)
			{
				return;
			}
			this.Released = true;
			for (int i = 0; i < this.TrackList.Count; i++)
			{
				IPathDrivenSplineRuntimeData pathDrivenSplineRuntimeData = this.TrackList[i];
				GameSplineModel instance = GameSplineModel.Instance;
				if (instance != null)
				{
					instance.ReleaseSpline(pathDrivenSplineRuntimeData.SplineEntityId, (long)this.OwnerEntityId, EIdType.EntityId);
				}
			}
			this.TrackList.Clear();
		}

		// Token: 0x040257F1 RID: 153585
		public readonly List<IPathDrivenSplineRuntimeData> TrackList = new List<IPathDrivenSplineRuntimeData>();

		// Token: 0x040257F2 RID: 153586
		private readonly int OwnerEntityId;

		// Token: 0x040257F3 RID: 153587
		private bool Released;
	}
}
