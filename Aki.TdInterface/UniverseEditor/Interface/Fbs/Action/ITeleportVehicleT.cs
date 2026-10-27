using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C5 RID: 29637
	public class ITeleportVehicleT
	{
		// Token: 0x1700E115 RID: 57621
		// (get) Token: 0x06035D3E RID: 220478 RVA: 0x00753E05 File Offset: 0x00752005
		// (set) Token: 0x06035D3F RID: 220479 RVA: 0x00753E0D File Offset: 0x0075200D
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700E116 RID: 57622
		// (get) Token: 0x06035D40 RID: 220480 RVA: 0x00753E16 File Offset: 0x00752016
		// (set) Token: 0x06035D41 RID: 220481 RVA: 0x00753E1E File Offset: 0x0075201E
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700E117 RID: 57623
		// (get) Token: 0x06035D42 RID: 220482 RVA: 0x00753E27 File Offset: 0x00752027
		// (set) Token: 0x06035D43 RID: 220483 RVA: 0x00753E2F File Offset: 0x0075202F
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700E118 RID: 57624
		// (get) Token: 0x06035D44 RID: 220484 RVA: 0x00753E38 File Offset: 0x00752038
		// (set) Token: 0x06035D45 RID: 220485 RVA: 0x00753E40 File Offset: 0x00752040
		public int AppointedDock { get; set; }

		// Token: 0x1700E119 RID: 57625
		// (get) Token: 0x06035D46 RID: 220486 RVA: 0x00753E49 File Offset: 0x00752049
		// (set) Token: 0x06035D47 RID: 220487 RVA: 0x00753E51 File Offset: 0x00752051
		public bool IsTeleportNoLoading { get; set; }

		// Token: 0x1700E11A RID: 57626
		// (get) Token: 0x06035D48 RID: 220488 RVA: 0x00753E5A File Offset: 0x0075205A
		// (set) Token: 0x06035D49 RID: 220489 RVA: 0x00753E62 File Offset: 0x00752062
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700E11B RID: 57627
		// (get) Token: 0x06035D4A RID: 220490 RVA: 0x00753E6B File Offset: 0x0075206B
		// (set) Token: 0x06035D4B RID: 220491 RVA: 0x00753E73 File Offset: 0x00752073
		public byte NullMask { get; set; }

		// Token: 0x06035D4C RID: 220492 RVA: 0x00753E7C File Offset: 0x0075207C
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
