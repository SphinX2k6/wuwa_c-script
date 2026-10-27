using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AAC RID: 19116
	public class ICheckItemsT
	{
		// Token: 0x17008A8F RID: 35471
		// (get) Token: 0x0601E00C RID: 122892 RVA: 0x004362CD File Offset: 0x004344CD
		// (set) Token: 0x0601E00D RID: 122893 RVA: 0x004362D5 File Offset: 0x004344D5
		public ECondition Type { get; set; }

		// Token: 0x17008A90 RID: 35472
		// (get) Token: 0x0601E00E RID: 122894 RVA: 0x004362DE File Offset: 0x004344DE
		// (set) Token: 0x0601E00F RID: 122895 RVA: 0x004362E6 File Offset: 0x004344E6
		public ECompare Compare { get; set; }

		// Token: 0x17008A91 RID: 35473
		// (get) Token: 0x0601E010 RID: 122896 RVA: 0x004362EF File Offset: 0x004344EF
		// (set) Token: 0x0601E011 RID: 122897 RVA: 0x004362F7 File Offset: 0x004344F7
		public List<IItemConfigT> Items { get; set; }

		// Token: 0x0601E012 RID: 122898 RVA: 0x00436300 File Offset: 0x00434500
		public ICheckItemsT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Items = null;
		}
	}
}
