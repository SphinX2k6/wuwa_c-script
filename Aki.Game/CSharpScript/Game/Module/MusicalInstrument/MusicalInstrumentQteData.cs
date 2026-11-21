using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004357 RID: 17239
	[NullableContext(2)]
	[Nullable(0)]
	public class MusicalInstrumentQteData
	{
		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x0602B893 RID: 178323 RVA: 0x00C3BAE8 File Offset: 0x00C39CE8
		// (set) Token: 0x0602B894 RID: 178324 RVA: 0x00C3BAF0 File Offset: 0x00C39CF0
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x0602B895 RID: 178325 RVA: 0x00C3BAF9 File Offset: 0x00C39CF9
		// (set) Token: 0x0602B896 RID: 178326 RVA: 0x00C3BB01 File Offset: 0x00C39D01
		public int QteId { get; set; }

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x0602B897 RID: 178327 RVA: 0x00C3BB0A File Offset: 0x00C39D0A
		// (set) Token: 0x0602B898 RID: 178328 RVA: 0x00C3BB12 File Offset: 0x00C39D12
		[Nullable(1)]
		public List<MusicalInstrumentQteItemData> ItemDataList { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005724 RID: 22308
		// (get) Token: 0x0602B899 RID: 178329 RVA: 0x00C3BB1B File Offset: 0x00C39D1B
		// (set) Token: 0x0602B89A RID: 178330 RVA: 0x00C3BB23 File Offset: 0x00C39D23
		public string AudioEvent { get; set; }

		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x0602B89B RID: 178331 RVA: 0x00C3BB2C File Offset: 0x00C39D2C
		// (set) Token: 0x0602B89C RID: 178332 RVA: 0x00C3BB34 File Offset: 0x00C39D34
		public Action<bool> FinishCallback { get; set; }
	}
}
