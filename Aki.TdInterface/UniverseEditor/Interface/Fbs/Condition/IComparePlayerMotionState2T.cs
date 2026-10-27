using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC0 RID: 19392
	public class IComparePlayerMotionState2T
	{
		// Token: 0x17008CD3 RID: 36051
		// (get) Token: 0x0601E992 RID: 125330 RVA: 0x0044783B File Offset: 0x00445A3B
		// (set) Token: 0x0601E993 RID: 125331 RVA: 0x00447843 File Offset: 0x00445A43
		public ECondition Type { get; set; }

		// Token: 0x17008CD4 RID: 36052
		// (get) Token: 0x0601E994 RID: 125332 RVA: 0x0044784C File Offset: 0x00445A4C
		// (set) Token: 0x0601E995 RID: 125333 RVA: 0x00447854 File Offset: 0x00445A54
		public EPlayerMotionState MotionState { get; set; }

		// Token: 0x17008CD5 RID: 36053
		// (get) Token: 0x0601E996 RID: 125334 RVA: 0x0044785D File Offset: 0x00445A5D
		// (set) Token: 0x0601E997 RID: 125335 RVA: 0x00447865 File Offset: 0x00445A65
		public ECompare Compare { get; set; }

		// Token: 0x17008CD6 RID: 36054
		// (get) Token: 0x0601E998 RID: 125336 RVA: 0x0044786E File Offset: 0x00445A6E
		// (set) Token: 0x0601E999 RID: 125337 RVA: 0x00447876 File Offset: 0x00445A76
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601E99A RID: 125338 RVA: 0x0044787F File Offset: 0x00445A7F
		public IComparePlayerMotionState2T()
		{
			this.Type = ECondition.CompareVar;
			this.MotionState = EPlayerMotionState.Ground;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
