using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006830 RID: 26672
	public class IAvgMoveRoleT
	{
		// Token: 0x1700C416 RID: 50198
		// (get) Token: 0x0602D941 RID: 186689 RVA: 0x0063CA57 File Offset: 0x0063AC57
		// (set) Token: 0x0602D942 RID: 186690 RVA: 0x0063CA5F File Offset: 0x0063AC5F
		public int RoleId { get; set; }

		// Token: 0x1700C417 RID: 50199
		// (get) Token: 0x0602D943 RID: 186691 RVA: 0x0063CA68 File Offset: 0x0063AC68
		// (set) Token: 0x0602D944 RID: 186692 RVA: 0x0063CA70 File Offset: 0x0063AC70
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x1700C418 RID: 50200
		// (get) Token: 0x0602D945 RID: 186693 RVA: 0x0063CA79 File Offset: 0x0063AC79
		// (set) Token: 0x0602D946 RID: 186694 RVA: 0x0063CA81 File Offset: 0x0063AC81
		public bool IsAnimationLoop { get; set; }

		// Token: 0x1700C419 RID: 50201
		// (get) Token: 0x0602D947 RID: 186695 RVA: 0x0063CA8A File Offset: 0x0063AC8A
		// (set) Token: 0x0602D948 RID: 186696 RVA: 0x0063CA92 File Offset: 0x0063AC92
		public EAvgRolePosition TargetPosition { get; set; }

		// Token: 0x1700C41A RID: 50202
		// (get) Token: 0x0602D949 RID: 186697 RVA: 0x0063CA9B File Offset: 0x0063AC9B
		// (set) Token: 0x0602D94A RID: 186698 RVA: 0x0063CAA3 File Offset: 0x0063ACA3
		public IEaseDataT EaseCurve { get; set; }

		// Token: 0x1700C41B RID: 50203
		// (get) Token: 0x0602D94B RID: 186699 RVA: 0x0063CAAC File Offset: 0x0063ACAC
		// (set) Token: 0x0602D94C RID: 186700 RVA: 0x0063CAB4 File Offset: 0x0063ACB4
		public byte NullMask { get; set; }

		// Token: 0x0602D94D RID: 186701 RVA: 0x0063CABD File Offset: 0x0063ACBD
		public IAvgMoveRoleT()
		{
			this.RoleId = 0;
			this.AnimationType = EAvgRoleAnimationType.Idle;
			this.IsAnimationLoop = false;
			this.TargetPosition = EAvgRolePosition.Center;
			this.EaseCurve = null;
			this.NullMask = 0;
		}
	}
}
