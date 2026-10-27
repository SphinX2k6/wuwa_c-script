using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006270 RID: 25200
	public class ICallByConditionT
	{
		// Token: 0x1700BBCE RID: 48078
		// (get) Token: 0x0602B7EF RID: 178159 RVA: 0x005FD40E File Offset: 0x005FB60E
		// (set) Token: 0x0602B7F0 RID: 178160 RVA: 0x005FD416 File Offset: 0x005FB616
		public IConditionsT Conditions { get; set; }

		// Token: 0x1700BBCF RID: 48079
		// (get) Token: 0x0602B7F1 RID: 178161 RVA: 0x005FD41F File Offset: 0x005FB61F
		// (set) Token: 0x0602B7F2 RID: 178162 RVA: 0x005FD427 File Offset: 0x005FB627
		public List<IActionInfoT> TrueActions { get; set; }

		// Token: 0x1700BBD0 RID: 48080
		// (get) Token: 0x0602B7F3 RID: 178163 RVA: 0x005FD430 File Offset: 0x005FB630
		// (set) Token: 0x0602B7F4 RID: 178164 RVA: 0x005FD438 File Offset: 0x005FB638
		public List<IActionInfoT> FalseActions { get; set; }

		// Token: 0x1700BBD1 RID: 48081
		// (get) Token: 0x0602B7F5 RID: 178165 RVA: 0x005FD441 File Offset: 0x005FB641
		// (set) Token: 0x0602B7F6 RID: 178166 RVA: 0x005FD449 File Offset: 0x005FB649
		public byte NullMask { get; set; }

		// Token: 0x0602B7F7 RID: 178167 RVA: 0x005FD452 File Offset: 0x005FB652
		public ICallByConditionT()
		{
			this.Conditions = null;
			this.TrueActions = null;
			this.FalseActions = null;
			this.NullMask = 0;
		}
	}
}
