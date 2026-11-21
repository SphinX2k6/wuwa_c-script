using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BAC RID: 31660
	public class ITeleportVehicleT
	{
		// Token: 0x1700ED25 RID: 60709
		// (get) Token: 0x060390D9 RID: 233689 RVA: 0x007B6345 File Offset: 0x007B4545
		// (set) Token: 0x060390DA RID: 233690 RVA: 0x007B634D File Offset: 0x007B454D
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700ED26 RID: 60710
		// (get) Token: 0x060390DB RID: 233691 RVA: 0x007B6356 File Offset: 0x007B4556
		// (set) Token: 0x060390DC RID: 233692 RVA: 0x007B635E File Offset: 0x007B455E
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700ED27 RID: 60711
		// (get) Token: 0x060390DD RID: 233693 RVA: 0x007B6367 File Offset: 0x007B4567
		// (set) Token: 0x060390DE RID: 233694 RVA: 0x007B636F File Offset: 0x007B456F
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700ED28 RID: 60712
		// (get) Token: 0x060390DF RID: 233695 RVA: 0x007B6378 File Offset: 0x007B4578
		// (set) Token: 0x060390E0 RID: 233696 RVA: 0x007B6380 File Offset: 0x007B4580
		public int AppointedDock { get; set; }

		// Token: 0x1700ED29 RID: 60713
		// (get) Token: 0x060390E1 RID: 233697 RVA: 0x007B6389 File Offset: 0x007B4589
		// (set) Token: 0x060390E2 RID: 233698 RVA: 0x007B6391 File Offset: 0x007B4591
		public bool IsTeleportNoLoading { get; set; }

		// Token: 0x1700ED2A RID: 60714
		// (get) Token: 0x060390E3 RID: 233699 RVA: 0x007B639A File Offset: 0x007B459A
		// (set) Token: 0x060390E4 RID: 233700 RVA: 0x007B63A2 File Offset: 0x007B45A2
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700ED2B RID: 60715
		// (get) Token: 0x060390E5 RID: 233701 RVA: 0x007B63AB File Offset: 0x007B45AB
		// (set) Token: 0x060390E6 RID: 233702 RVA: 0x007B63B3 File Offset: 0x007B45B3
		public byte NullMask { get; set; }

		// Token: 0x060390E7 RID: 233703 RVA: 0x007B63BC File Offset: 0x007B45BC
		public ITeleportVehicleT()
		{
			this.TargetVehicle = null;
			this.Pos = null;
			this.Rot = null;
			this.AppointedDock = 0;
			this.IsTeleportNoLoading = false;
			this.TransitionOption = null;
			this.NullMask = 0;
		}
	}
}
