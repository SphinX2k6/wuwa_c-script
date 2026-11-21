using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064BC RID: 25788
	public class TCsvReignsDataT
	{
		// Token: 0x1700BE37 RID: 48695
		// (get) Token: 0x0602BD94 RID: 179604 RVA: 0x005F6A6C File Offset: 0x005F4C6C
		// (set) Token: 0x0602BD95 RID: 179605 RVA: 0x005F6A74 File Offset: 0x005F4C74
		public int Id { get; set; }

		// Token: 0x1700BE38 RID: 48696
		// (get) Token: 0x0602BD96 RID: 179606 RVA: 0x005F6A7D File Offset: 0x005F4C7D
		// (set) Token: 0x0602BD97 RID: 179607 RVA: 0x005F6A85 File Offset: 0x005F4C85
		public List<IReignsPropertyConfigT> BaseProperty { get; set; }

		// Token: 0x1700BE39 RID: 48697
		// (get) Token: 0x0602BD98 RID: 179608 RVA: 0x005F6A8E File Offset: 0x005F4C8E
		// (set) Token: 0x0602BD99 RID: 179609 RVA: 0x005F6A96 File Offset: 0x005F4C96
		public List<IReignsEndingT> EndingList { get; set; }

		// Token: 0x0602BD9A RID: 179610 RVA: 0x005F6A9F File Offset: 0x005F4C9F
		public TCsvReignsDataT()
		{
			this.Id = 0;
			this.BaseProperty = null;
			this.EndingList = null;
		}
	}
}
