using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B0 RID: 29360
	public class IMoveWithSplineT
	{
		// Token: 0x1700D740 RID: 55104
		// (get) Token: 0x060332DB RID: 209627 RVA: 0x006E8074 File Offset: 0x006E6274
		// (set) Token: 0x060332DC RID: 209628 RVA: 0x006E807C File Offset: 0x006E627C
		public TSplineMoveTargetUnion MoveTarget { get; set; }

		// Token: 0x1700D741 RID: 55105
		// (get) Token: 0x060332DD RID: 209629 RVA: 0x006E8085 File Offset: 0x006E6285
		// (set) Token: 0x060332DE RID: 209630 RVA: 0x006E808D File Offset: 0x006E628D
		public int SplineEntityId { get; set; }

		// Token: 0x1700D742 RID: 55106
		// (get) Token: 0x060332DF RID: 209631 RVA: 0x006E8096 File Offset: 0x006E6296
		// (set) Token: 0x060332E0 RID: 209632 RVA: 0x006E809E File Offset: 0x006E629E
		public ICheckClimbT CheckClimb { get; set; }

		// Token: 0x1700D743 RID: 55107
		// (get) Token: 0x060332E1 RID: 209633 RVA: 0x006E80A7 File Offset: 0x006E62A7
		// (set) Token: 0x060332E2 RID: 209634 RVA: 0x006E80AF File Offset: 0x006E62AF
		public IMoveOnWallConfigT MoveOnWallConfig { get; set; }

		// Token: 0x1700D744 RID: 55108
		// (get) Token: 0x060332E3 RID: 209635 RVA: 0x006E80B8 File Offset: 0x006E62B8
		// (set) Token: 0x060332E4 RID: 209636 RVA: 0x006E80C0 File Offset: 0x006E62C0
		public EMoveSpeed MoveState { get; set; }

		// Token: 0x1700D745 RID: 55109
		// (get) Token: 0x060332E5 RID: 209637 RVA: 0x006E80C9 File Offset: 0x006E62C9
		// (set) Token: 0x060332E6 RID: 209638 RVA: 0x006E80D1 File Offset: 0x006E62D1
		public int StartPointIndex { get; set; }

		// Token: 0x1700D746 RID: 55110
		// (get) Token: 0x060332E7 RID: 209639 RVA: 0x006E80DA File Offset: 0x006E62DA
		// (set) Token: 0x060332E8 RID: 209640 RVA: 0x006E80E2 File Offset: 0x006E62E2
		public int EndPointIndex { get; set; }

		// Token: 0x1700D747 RID: 55111
		// (get) Token: 0x060332E9 RID: 209641 RVA: 0x006E80EB File Offset: 0x006E62EB
		// (set) Token: 0x060332EA RID: 209642 RVA: 0x006E80F3 File Offset: 0x006E62F3
		public bool IsFollowStrictly { get; set; }

		// Token: 0x1700D748 RID: 55112
		// (get) Token: 0x060332EB RID: 209643 RVA: 0x006E80FC File Offset: 0x006E62FC
		// (set) Token: 0x060332EC RID: 209644 RVA: 0x006E8104 File Offset: 0x006E6304
		public bool IsForceToFirstPoint { get; set; }

		// Token: 0x1700D749 RID: 55113
		// (get) Token: 0x060332ED RID: 209645 RVA: 0x006E810D File Offset: 0x006E630D
		// (set) Token: 0x060332EE RID: 209646 RVA: 0x006E8115 File Offset: 0x006E6315
		public bool IsLookDir { get; set; }

		// Token: 0x1700D74A RID: 55114
		// (get) Token: 0x060332EF RID: 209647 RVA: 0x006E811E File Offset: 0x006E631E
		// (set) Token: 0x060332F0 RID: 209648 RVA: 0x006E8126 File Offset: 0x006E6326
		public INpcFollowConfigT NpcFollow { get; set; }

		// Token: 0x1700D74B RID: 55115
		// (get) Token: 0x060332F1 RID: 209649 RVA: 0x006E812F File Offset: 0x006E632F
		// (set) Token: 0x060332F2 RID: 209650 RVA: 0x006E8137 File Offset: 0x006E6337
		public bool NpcCollisionEnabled { get; set; }

		// Token: 0x1700D74C RID: 55116
		// (get) Token: 0x060332F3 RID: 209651 RVA: 0x006E8140 File Offset: 0x006E6340
		// (set) Token: 0x060332F4 RID: 209652 RVA: 0x006E8148 File Offset: 0x006E6348
		public byte NullMask { get; set; }

		// Token: 0x060332F5 RID: 209653 RVA: 0x006E8154 File Offset: 0x006E6354
		public IMoveWithSplineT()
		{
			this.MoveTarget = null;
			this.SplineEntityId = 0;
			this.CheckClimb = null;
			this.MoveOnWallConfig = null;
			this.MoveState = EMoveSpeed.None;
			this.StartPointIndex = 0;
			this.EndPointIndex = 0;
			this.IsFollowStrictly = false;
			this.IsForceToFirstPoint = false;
			this.IsLookDir = false;
			this.NpcFollow = null;
			this.NpcCollisionEnabled = false;
			this.NullMask = 0;
		}
	}
}
