using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049B1 RID: 18865
	public class IRollBlock1T
	{
		// Token: 0x17008411 RID: 33809
		// (get) Token: 0x0601C2E4 RID: 115428 RVA: 0x003FAC40 File Offset: 0x003F8E40
		// (set) Token: 0x0601C2E5 RID: 115429 RVA: 0x003FAC48 File Offset: 0x003F8E48
		public ERollBlockBlockType Type { get; set; }

		// Token: 0x17008412 RID: 33810
		// (get) Token: 0x0601C2E6 RID: 115430 RVA: 0x003FAC51 File Offset: 0x003F8E51
		// (set) Token: 0x0601C2E7 RID: 115431 RVA: 0x003FAC59 File Offset: 0x003F8E59
		public int BlockId { get; set; }

		// Token: 0x0601C2E8 RID: 115432 RVA: 0x003FAC62 File Offset: 0x003F8E62
		public IRollBlock1T()
		{
			this.Type = ERollBlockBlockType.Block1;
			this.BlockId = 0;
		}
	}
}
