using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E79 RID: 24185
	public class TCsvReignsDataT
	{
		// Token: 0x1700B4CC RID: 46284
		// (get) Token: 0x060296EC RID: 169708 RVA: 0x005ADAC8 File Offset: 0x005ABCC8
		// (set) Token: 0x060296ED RID: 169709 RVA: 0x005ADAD0 File Offset: 0x005ABCD0
		public int Id { get; set; }

		// Token: 0x1700B4CD RID: 46285
		// (get) Token: 0x060296EE RID: 169710 RVA: 0x005ADAD9 File Offset: 0x005ABCD9
		// (set) Token: 0x060296EF RID: 169711 RVA: 0x005ADAE1 File Offset: 0x005ABCE1
		public List<IReignsPropertyConfigT> BaseProperty { get; set; }

		// Token: 0x1700B4CE RID: 46286
		// (get) Token: 0x060296F0 RID: 169712 RVA: 0x005ADAEA File Offset: 0x005ABCEA
		// (set) Token: 0x060296F1 RID: 169713 RVA: 0x005ADAF2 File Offset: 0x005ABCF2
		public List<IReignsEndingT> EndingList { get; set; }

		// Token: 0x060296F2 RID: 169714 RVA: 0x005ADAFB File Offset: 0x005ABCFB
		public TCsvReignsDataT()
		{
			this.Id = 0;
			this.BaseProperty = null;
			this.EndingList = null;
		}
	}
}
