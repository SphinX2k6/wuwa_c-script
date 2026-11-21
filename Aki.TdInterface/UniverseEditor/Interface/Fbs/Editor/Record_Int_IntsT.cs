using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D3D RID: 19773
	public class Record_Int_IntsT
	{
		// Token: 0x17008DAA RID: 36266
		// (get) Token: 0x0601EA97 RID: 125591 RVA: 0x0044A6DF File Offset: 0x004488DF
		// (set) Token: 0x0601EA98 RID: 125592 RVA: 0x0044A6E7 File Offset: 0x004488E7
		public int Key { get; set; }

		// Token: 0x17008DAB RID: 36267
		// (get) Token: 0x0601EA99 RID: 125593 RVA: 0x0044A6F0 File Offset: 0x004488F0
		// (set) Token: 0x0601EA9A RID: 125594 RVA: 0x0044A6F8 File Offset: 0x004488F8
		public List<int> Values { get; set; }

		// Token: 0x0601EA9B RID: 125595 RVA: 0x0044A701 File Offset: 0x00448901
		public Record_Int_IntsT()
		{
			this.Key = 0;
			this.Values = null;
		}
	}
}
