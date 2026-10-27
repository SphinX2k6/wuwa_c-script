using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006973 RID: 26995
	public class IInstrumentQteConfigT
	{
		// Token: 0x1700C836 RID: 51254
		// (get) Token: 0x0602F240 RID: 193088 RVA: 0x0066C30F File Offset: 0x0066A50F
		// (set) Token: 0x0602F241 RID: 193089 RVA: 0x0066C317 File Offset: 0x0066A517
		public int Id { get; set; }

		// Token: 0x1700C837 RID: 51255
		// (get) Token: 0x0602F242 RID: 193090 RVA: 0x0066C320 File Offset: 0x0066A520
		// (set) Token: 0x0602F243 RID: 193091 RVA: 0x0066C328 File Offset: 0x0066A528
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x1700C838 RID: 51256
		// (get) Token: 0x0602F244 RID: 193092 RVA: 0x0066C331 File Offset: 0x0066A531
		// (set) Token: 0x0602F245 RID: 193093 RVA: 0x0066C339 File Offset: 0x0066A539
		public string Description { get; set; }

		// Token: 0x1700C839 RID: 51257
		// (get) Token: 0x0602F246 RID: 193094 RVA: 0x0066C342 File Offset: 0x0066A542
		// (set) Token: 0x0602F247 RID: 193095 RVA: 0x0066C34A File Offset: 0x0066A54A
		public List<IInstrumentQteConfig_QteSequenceRowT> QteSequence { get; set; }

		// Token: 0x1700C83A RID: 51258
		// (get) Token: 0x0602F248 RID: 193096 RVA: 0x0066C353 File Offset: 0x0066A553
		// (set) Token: 0x0602F249 RID: 193097 RVA: 0x0066C35B File Offset: 0x0066A55B
		public string PreludeAsset { get; set; }

		// Token: 0x0602F24A RID: 193098 RVA: 0x0066C364 File Offset: 0x0066A564
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
