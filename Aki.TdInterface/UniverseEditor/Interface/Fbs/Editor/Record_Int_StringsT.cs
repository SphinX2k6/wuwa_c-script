using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D40 RID: 19776
	public class Record_Int_StringsT
	{
		// Token: 0x17008DAF RID: 36271
		// (get) Token: 0x0601EAB3 RID: 125619 RVA: 0x0044AA1F File Offset: 0x00448C1F
		// (set) Token: 0x0601EAB4 RID: 125620 RVA: 0x0044AA27 File Offset: 0x00448C27
		public int Key { get; set; }

		// Token: 0x17008DB0 RID: 36272
		// (get) Token: 0x0601EAB5 RID: 125621 RVA: 0x0044AA30 File Offset: 0x00448C30
		// (set) Token: 0x0601EAB6 RID: 125622 RVA: 0x0044AA38 File Offset: 0x00448C38
		public List<string> Values { get; set; }

		// Token: 0x0601EAB7 RID: 125623 RVA: 0x0044AA41 File Offset: 0x00448C41
		public Record_Int_StringsT()
		{
			this.Key = 0;
			this.Values = null;
		}
	}
}
