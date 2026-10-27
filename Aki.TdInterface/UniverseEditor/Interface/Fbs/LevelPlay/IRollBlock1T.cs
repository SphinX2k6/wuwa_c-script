using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004549 RID: 17737
	public class IRollBlock1T
	{
		// Token: 0x17007DD0 RID: 32208
		// (get) Token: 0x0601AB0F RID: 109327 RVA: 0x003CE9A4 File Offset: 0x003CCBA4
		// (set) Token: 0x0601AB10 RID: 109328 RVA: 0x003CE9AC File Offset: 0x003CCBAC
		public ERollBlockBlockType Type { get; set; }

		// Token: 0x17007DD1 RID: 32209
		// (get) Token: 0x0601AB11 RID: 109329 RVA: 0x003CE9B5 File Offset: 0x003CCBB5
		// (set) Token: 0x0601AB12 RID: 109330 RVA: 0x003CE9BD File Offset: 0x003CCBBD
		public int BlockId { get; set; }

		// Token: 0x0601AB13 RID: 109331 RVA: 0x003CE9C6 File Offset: 0x003CCBC6
		public IRollBlock1T()
		{
			this.Type = ERollBlockBlockType.Block1;
			this.BlockId = 0;
		}
	}
}
