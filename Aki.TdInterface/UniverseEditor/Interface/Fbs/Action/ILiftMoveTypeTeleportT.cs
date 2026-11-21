using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BC RID: 28860
	public class ILiftMoveTypeTeleportT
	{
		// Token: 0x1700D36D RID: 54125
		// (get) Token: 0x060321DF RID: 205279 RVA: 0x006C84CA File Offset: 0x006C66CA
		// (set) Token: 0x060321E0 RID: 205280 RVA: 0x006C84D2 File Offset: 0x006C66D2
		public ELiftMoveType Type { get; set; }

		// Token: 0x1700D36E RID: 54126
		// (get) Token: 0x060321E1 RID: 205281 RVA: 0x006C84DB File Offset: 0x006C66DB
		// (set) Token: 0x060321E2 RID: 205282 RVA: 0x006C84E3 File Offset: 0x006C66E3
		public float StartTeleportOffsetDistance { get; set; }

		// Token: 0x1700D36F RID: 54127
		// (get) Token: 0x060321E3 RID: 205283 RVA: 0x006C84EC File Offset: 0x006C66EC
		// (set) Token: 0x060321E4 RID: 205284 RVA: 0x006C84F4 File Offset: 0x006C66F4
		public float EndTeleportOffsetDistance { get; set; }

		// Token: 0x1700D370 RID: 54128
		// (get) Token: 0x060321E5 RID: 205285 RVA: 0x006C84FD File Offset: 0x006C66FD
		// (set) Token: 0x060321E6 RID: 205286 RVA: 0x006C8505 File Offset: 0x006C6705
		public bool SendTeleportEvent { get; set; }

		// Token: 0x1700D371 RID: 54129
		// (get) Token: 0x060321E7 RID: 205287 RVA: 0x006C850E File Offset: 0x006C670E
		// (set) Token: 0x060321E8 RID: 205288 RVA: 0x006C8516 File Offset: 0x006C6716
		public float TeleportStartEventOffsetDistance { get; set; }

		// Token: 0x060321E9 RID: 205289 RVA: 0x006C851F File Offset: 0x006C671F
		public ILiftMoveTypeTeleportT()
		{
			this.Type = ELiftMoveType.Default;
			this.StartTeleportOffsetDistance = 0f;
			this.EndTeleportOffsetDistance = 0f;
			this.SendTeleportEvent = false;
			this.TeleportStartEventOffsetDistance = 0f;
		}
	}
}
