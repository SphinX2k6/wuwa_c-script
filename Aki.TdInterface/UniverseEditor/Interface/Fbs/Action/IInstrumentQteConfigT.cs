using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007026 RID: 28710
	public class IInstrumentQteConfigT
	{
		// Token: 0x1700D239 RID: 53817
		// (get) Token: 0x06031C10 RID: 203792 RVA: 0x006BC7F7 File Offset: 0x006BA9F7
		// (set) Token: 0x06031C11 RID: 203793 RVA: 0x006BC7FF File Offset: 0x006BA9FF
		public int Id { get; set; }

		// Token: 0x1700D23A RID: 53818
		// (get) Token: 0x06031C12 RID: 203794 RVA: 0x006BC808 File Offset: 0x006BAA08
		// (set) Token: 0x06031C13 RID: 203795 RVA: 0x006BC810 File Offset: 0x006BAA10
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x1700D23B RID: 53819
		// (get) Token: 0x06031C14 RID: 203796 RVA: 0x006BC819 File Offset: 0x006BAA19
		// (set) Token: 0x06031C15 RID: 203797 RVA: 0x006BC821 File Offset: 0x006BAA21
		public string Description { get; set; }

		// Token: 0x1700D23C RID: 53820
		// (get) Token: 0x06031C16 RID: 203798 RVA: 0x006BC82A File Offset: 0x006BAA2A
		// (set) Token: 0x06031C17 RID: 203799 RVA: 0x006BC832 File Offset: 0x006BAA32
		public List<IInstrumentQteConfig_QteSequenceRowT> QteSequence { get; set; }

		// Token: 0x1700D23D RID: 53821
		// (get) Token: 0x06031C18 RID: 203800 RVA: 0x006BC83B File Offset: 0x006BAA3B
		// (set) Token: 0x06031C19 RID: 203801 RVA: 0x006BC843 File Offset: 0x006BAA43
		public string PreludeAsset { get; set; }

		// Token: 0x06031C1A RID: 203802 RVA: 0x006BC84C File Offset: 0x006BAA4C
		public IInstrumentQteConfigT()
		{
			this.Id = 0;
			this.InstrumentType = EInstrumentType.ChineseZither;
			this.Description = null;
			this.QteSequence = null;
			this.PreludeAsset = null;
		}
	}
}
