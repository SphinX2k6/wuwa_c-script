using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739E RID: 29598
	public class ITeleportTransitionInDigitalScreenT
	{
		// Token: 0x1700E0A2 RID: 57506
		// (get) Token: 0x06035B7D RID: 220029 RVA: 0x0074FFCC File Offset: 0x0074E1CC
		// (set) Token: 0x06035B7E RID: 220030 RVA: 0x0074FFD4 File Offset: 0x0074E1D4
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0A3 RID: 57507
		// (get) Token: 0x06035B7F RID: 220031 RVA: 0x0074FFDD File Offset: 0x0074E1DD
		// (set) Token: 0x06035B80 RID: 220032 RVA: 0x0074FFE5 File Offset: 0x0074E1E5
		public int ConfigId { get; set; }

		// Token: 0x06035B81 RID: 220033 RVA: 0x0074FFEE File Offset: 0x0074E1EE
		public ITeleportTransitionInDigitalScreenT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.ConfigId = 0;
		}
	}
}
