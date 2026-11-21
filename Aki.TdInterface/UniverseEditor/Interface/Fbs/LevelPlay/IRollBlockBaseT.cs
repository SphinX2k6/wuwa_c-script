using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049B7 RID: 18871
	public class IRollBlockBaseT
	{
		// Token: 0x1700841F RID: 33823
		// (get) Token: 0x0601C318 RID: 115480 RVA: 0x003FB158 File Offset: 0x003F9358
		// (set) Token: 0x0601C319 RID: 115481 RVA: 0x003FB160 File Offset: 0x003F9360
		public ERollBlockBlockType Type { get; set; }

		// Token: 0x17008420 RID: 33824
		// (get) Token: 0x0601C31A RID: 115482 RVA: 0x003FB169 File Offset: 0x003F9369
		// (set) Token: 0x0601C31B RID: 115483 RVA: 0x003FB171 File Offset: 0x003F9371
		public int BlockId { get; set; }

		// Token: 0x0601C31C RID: 115484 RVA: 0x003FB17A File Offset: 0x003F937A
		public IRollBlockBaseT()
		{
			this.Type = ERollBlockBlockType.Block1;
			this.BlockId = 0;
		}
	}
}
