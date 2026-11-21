using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702C RID: 28716
	public class IInstrumentQteGameplayT
	{
		// Token: 0x1700D245 RID: 53829
		// (get) Token: 0x06031C48 RID: 203848 RVA: 0x006BCD8A File Offset: 0x006BAF8A
		// (set) Token: 0x06031C49 RID: 203849 RVA: 0x006BCD92 File Offset: 0x006BAF92
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D246 RID: 53830
		// (get) Token: 0x06031C4A RID: 203850 RVA: 0x006BCD9B File Offset: 0x006BAF9B
		// (set) Token: 0x06031C4B RID: 203851 RVA: 0x006BCDA3 File Offset: 0x006BAFA3
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x1700D247 RID: 53831
		// (get) Token: 0x06031C4C RID: 203852 RVA: 0x006BCDAC File Offset: 0x006BAFAC
		// (set) Token: 0x06031C4D RID: 203853 RVA: 0x006BCDB4 File Offset: 0x006BAFB4
		public int Id { get; set; }

		// Token: 0x06031C4E RID: 203854 RVA: 0x006BCDBD File Offset: 0x006BAFBD
		public IInstrumentQteGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.InstrumentType = EInstrumentType.ChineseZither;
			this.Id = 0;
		}
	}
}
