using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070EF RID: 28911
	public class HorizontalProjectileRailDataImpl : IHorizontalProjectileRailData, IRailParam, IConnectionRailData
	{
		// Token: 0x17009CC9 RID: 40137
		// (get) Token: 0x06046949 RID: 289097 RVA: 0x011C28D1 File Offset: 0x011C0AD1
		// (set) Token: 0x0604694A RID: 289098 RVA: 0x011C28D9 File Offset: 0x011C0AD9
		public ERailMoveType RailType { get; set; }

		// Token: 0x17009CCA RID: 40138
		// (get) Token: 0x0604694B RID: 289099 RVA: 0x011C28E2 File Offset: 0x011C0AE2
		// (set) Token: 0x0604694C RID: 289100 RVA: 0x011C28EA File Offset: 0x011C0AEA
		public ERailJumpType JumpType { get; set; }

		// Token: 0x17009CCB RID: 40139
		// (get) Token: 0x0604694D RID: 289101 RVA: 0x011C28F3 File Offset: 0x011C0AF3
		// (set) Token: 0x0604694E RID: 289102 RVA: 0x011C28FB File Offset: 0x011C0AFB
		[Nullable(1)]
		public Vector RotatorFixedDirection { [NullableContext(1)] get; [NullableContext(1)] set; } = Vector.Create();

		// Token: 0x17009CCC RID: 40140
		// (get) Token: 0x0604694F RID: 289103 RVA: 0x011C2904 File Offset: 0x011C0B04
		// (set) Token: 0x06046950 RID: 289104 RVA: 0x011C290C File Offset: 0x011C0B0C
		public int ConnectionNextRail { get; set; }

		// Token: 0x17009CCD RID: 40141
		// (get) Token: 0x06046951 RID: 289105 RVA: 0x011C2915 File Offset: 0x011C0B15
		// (set) Token: 0x06046952 RID: 289106 RVA: 0x011C291D File Offset: 0x011C0B1D
		public float ConnectionStartDistance { get; set; }
	}
}
