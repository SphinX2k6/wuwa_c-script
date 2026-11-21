using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200601E RID: 24606
	public class ISwitcherComponentT
	{
		// Token: 0x1700B67C RID: 46716
		// (get) Token: 0x060297D7 RID: 169943 RVA: 0x005A9A6F File Offset: 0x005A7C6F
		// (set) Token: 0x060297D8 RID: 169944 RVA: 0x005A9A77 File Offset: 0x005A7C77
		public bool Disabled { get; set; }

		// Token: 0x1700B67D RID: 46717
		// (get) Token: 0x060297D9 RID: 169945 RVA: 0x005A9A80 File Offset: 0x005A7C80
		// (set) Token: 0x060297DA RID: 169946 RVA: 0x005A9A88 File Offset: 0x005A7C88
		public string Content { get; set; }

		// Token: 0x1700B67E RID: 46718
		// (get) Token: 0x060297DB RID: 169947 RVA: 0x005A9A91 File Offset: 0x005A7C91
		// (set) Token: 0x060297DC RID: 169948 RVA: 0x005A9A99 File Offset: 0x005A7C99
		public string Icon { get; set; }

		// Token: 0x1700B67F RID: 46719
		// (get) Token: 0x060297DD RID: 169949 RVA: 0x005A9AA2 File Offset: 0x005A7CA2
		// (set) Token: 0x060297DE RID: 169950 RVA: 0x005A9AAA File Offset: 0x005A7CAA
		public List<IActionInfoT> OnActions { get; set; }

		// Token: 0x1700B680 RID: 46720
		// (get) Token: 0x060297DF RID: 169951 RVA: 0x005A9AB3 File Offset: 0x005A7CB3
		// (set) Token: 0x060297E0 RID: 169952 RVA: 0x005A9ABB File Offset: 0x005A7CBB
		public List<IActionInfoT> OffActions { get; set; }

		// Token: 0x1700B681 RID: 46721
		// (get) Token: 0x060297E1 RID: 169953 RVA: 0x005A9AC4 File Offset: 0x005A7CC4
		// (set) Token: 0x060297E2 RID: 169954 RVA: 0x005A9ACC File Offset: 0x005A7CCC
		public byte NullMask { get; set; }

		// Token: 0x060297E3 RID: 169955 RVA: 0x005A9AD5 File Offset: 0x005A7CD5
		public ISwitcherComponentT()
		{
			this.Disabled = false;
			this.Content = null;
			this.Icon = null;
			this.OnActions = null;
			this.OffActions = null;
			this.NullMask = 0;
		}
	}
}
