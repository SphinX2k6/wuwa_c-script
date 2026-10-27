using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048DB RID: 18651
	public class Record_Int_StringsT
	{
		// Token: 0x17008767 RID: 34663
		// (get) Token: 0x0601D2C6 RID: 119494 RVA: 0x0041E283 File Offset: 0x0041C483
		// (set) Token: 0x0601D2C7 RID: 119495 RVA: 0x0041E28B File Offset: 0x0041C48B
		public int Key { get; set; }

		// Token: 0x17008768 RID: 34664
		// (get) Token: 0x0601D2C8 RID: 119496 RVA: 0x0041E294 File Offset: 0x0041C494
		// (set) Token: 0x0601D2C9 RID: 119497 RVA: 0x0041E29C File Offset: 0x0041C49C
		public List<string> Values { get; set; }

		// Token: 0x0601D2CA RID: 119498 RVA: 0x0041E2A5 File Offset: 0x0041C4A5
		public Record_Int_StringsT()
		{
			this.Key = 0;
			this.Values = null;
		}
	}
}
