using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6A RID: 27498
	public class IMoveWithSplineT
	{
		// Token: 0x1700CC5B RID: 52315
		// (get) Token: 0x06030483 RID: 197763 RVA: 0x0068FA54 File Offset: 0x0068DC54
		// (set) Token: 0x06030484 RID: 197764 RVA: 0x0068FA5C File Offset: 0x0068DC5C
		public TSplineMoveTargetUnion MoveTarget { get; set; }

		// Token: 0x1700CC5C RID: 52316
		// (get) Token: 0x06030485 RID: 197765 RVA: 0x0068FA65 File Offset: 0x0068DC65
		// (set) Token: 0x06030486 RID: 197766 RVA: 0x0068FA6D File Offset: 0x0068DC6D
		public int SplineEntityId { get; set; }

		// Token: 0x1700CC5D RID: 52317
		// (get) Token: 0x06030487 RID: 197767 RVA: 0x0068FA76 File Offset: 0x0068DC76
		// (set) Token: 0x06030488 RID: 197768 RVA: 0x0068FA7E File Offset: 0x0068DC7E
		public ICheckClimbT CheckClimb { get; set; }

		// Token: 0x1700CC5E RID: 52318
		// (get) Token: 0x06030489 RID: 197769 RVA: 0x0068FA87 File Offset: 0x0068DC87
		// (set) Token: 0x0603048A RID: 197770 RVA: 0x0068FA8F File Offset: 0x0068DC8F
		public IMoveOnWallConfigT MoveOnWallConfig { get; set; }

		// Token: 0x1700CC5F RID: 52319
		// (get) Token: 0x0603048B RID: 197771 RVA: 0x0068FA98 File Offset: 0x0068DC98
		// (set) Token: 0x0603048C RID: 197772 RVA: 0x0068FAA0 File Offset: 0x0068DCA0
		public EMoveSpeed MoveState { get; set; }

		// Token: 0x1700CC60 RID: 52320
		// (get) Token: 0x0603048D RID: 197773 RVA: 0x0068FAA9 File Offset: 0x0068DCA9
		// (set) Token: 0x0603048E RID: 197774 RVA: 0x0068FAB1 File Offset: 0x0068DCB1
		public int StartPointIndex { get; set; }

		// Token: 0x1700CC61 RID: 52321
		// (get) Token: 0x0603048F RID: 197775 RVA: 0x0068FABA File Offset: 0x0068DCBA
		// (set) Token: 0x06030490 RID: 197776 RVA: 0x0068FAC2 File Offset: 0x0068DCC2
		public int EndPointIndex { get; set; }

		// Token: 0x1700CC62 RID: 52322
		// (get) Token: 0x06030491 RID: 197777 RVA: 0x0068FACB File Offset: 0x0068DCCB
		// (set) Token: 0x06030492 RID: 197778 RVA: 0x0068FAD3 File Offset: 0x0068DCD3
		public bool IsFollowStrictly { get; set; }

		// Token: 0x1700CC63 RID: 52323
		// (get) Token: 0x06030493 RID: 197779 RVA: 0x0068FADC File Offset: 0x0068DCDC
		// (set) Token: 0x06030494 RID: 197780 RVA: 0x0068FAE4 File Offset: 0x0068DCE4
		public bool IsForceToFirstPoint { get; set; }

		// Token: 0x1700CC64 RID: 52324
		// (get) Token: 0x06030495 RID: 197781 RVA: 0x0068FAED File Offset: 0x0068DCED
		// (set) Token: 0x06030496 RID: 197782 RVA: 0x0068FAF5 File Offset: 0x0068DCF5
		public bool IsLookDir { get; set; }

		// Token: 0x1700CC65 RID: 52325
		// (get) Token: 0x06030497 RID: 197783 RVA: 0x0068FAFE File Offset: 0x0068DCFE
		// (set) Token: 0x06030498 RID: 197784 RVA: 0x0068FB06 File Offset: 0x0068DD06
		public INpcFollowConfigT NpcFollow { get; set; }

		// Token: 0x1700CC66 RID: 52326
		// (get) Token: 0x06030499 RID: 197785 RVA: 0x0068FB0F File Offset: 0x0068DD0F
		// (set) Token: 0x0603049A RID: 197786 RVA: 0x0068FB17 File Offset: 0x0068DD17
		public bool NpcCollisionEnabled { get; set; }

		// Token: 0x1700CC67 RID: 52327
		// (get) Token: 0x0603049B RID: 197787 RVA: 0x0068FB20 File Offset: 0x0068DD20
		// (set) Token: 0x0603049C RID: 197788 RVA: 0x0068FB28 File Offset: 0x0068DD28
		public byte NullMask { get; set; }

		// Token: 0x0603049D RID: 197789 RVA: 0x0068FB34 File Offset: 0x0068DD34
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
