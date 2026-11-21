using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701D RID: 28701
	public class IInstrumentConfigT
	{
		// Token: 0x1700D224 RID: 53796
		// (get) Token: 0x06031BAC RID: 203692 RVA: 0x006BBB21 File Offset: 0x006B9D21
		// (set) Token: 0x06031BAD RID: 203693 RVA: 0x006BBB29 File Offset: 0x006B9D29
		public int Id { get; set; }

		// Token: 0x1700D225 RID: 53797
		// (get) Token: 0x06031BAE RID: 203694 RVA: 0x006BBB32 File Offset: 0x006B9D32
		// (set) Token: 0x06031BAF RID: 203695 RVA: 0x006BBB3A File Offset: 0x006B9D3A
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x1700D226 RID: 53798
		// (get) Token: 0x06031BB0 RID: 203696 RVA: 0x006BBB43 File Offset: 0x006B9D43
		// (set) Token: 0x06031BB1 RID: 203697 RVA: 0x006BBB4B File Offset: 0x006B9D4B
		public IInstrumentKeyConfigsT KeyConfigs { get; set; }

		// Token: 0x06031BB2 RID: 203698 RVA: 0x006BBB54 File Offset: 0x006B9D54
		public IInstrumentConfigT()
		{
			this.Id = 0;
			this.InstrumentType = EInstrumentType.ChineseZither;
			this.KeyConfigs = null;
		}
	}
}
