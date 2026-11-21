using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006286 RID: 25222
	[NullableContext(1)]
	[Nullable(0)]
	public class PathDrivenTrackRuntimeSet
	{
		// Token: 0x0603CDEB RID: 249323 RVA: 0x0117BB5A File Offset: 0x01179D5A
		public PathDrivenTrackRuntimeSet(int ownerEntityId)
		{
			this.OwnerEntityId = ownerEntityId;
		}

		// Token: 0x0603CDEC RID: 249324 RVA: 0x0117BB74 File Offset: 0x01179D74
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

		// Token: 0x0603CDED RID: 249325 RVA: 0x0117BBA8 File Offset: 0x01179DA8
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

		// Token: 0x04020460 RID: 132192
		public readonly List<IPathDrivenSplineRuntimeData> TrackList = new List<IPathDrivenSplineRuntimeData>();

		// Token: 0x04020461 RID: 132193
		private readonly int OwnerEntityId;

		// Token: 0x04020462 RID: 132194
		private bool Released;
	}
}
