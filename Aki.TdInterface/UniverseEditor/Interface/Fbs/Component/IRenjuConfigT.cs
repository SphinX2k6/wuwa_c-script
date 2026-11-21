using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E66 RID: 24166
	public class IRenjuConfigT
	{
		// Token: 0x1700B237 RID: 45623
		// (get) Token: 0x06028691 RID: 165521 RVA: 0x00586840 File Offset: 0x00584A40
		// (set) Token: 0x06028692 RID: 165522 RVA: 0x00586848 File Offset: 0x00584A48
		public ERenjuController Controller { get; set; }

		// Token: 0x1700B238 RID: 45624
		// (get) Token: 0x06028693 RID: 165523 RVA: 0x00586851 File Offset: 0x00584A51
		// (set) Token: 0x06028694 RID: 165524 RVA: 0x00586859 File Offset: 0x00584A59
		public ERenjuOrder Order { get; set; }

		// Token: 0x1700B239 RID: 45625
		// (get) Token: 0x06028695 RID: 165525 RVA: 0x00586862 File Offset: 0x00584A62
		// (set) Token: 0x06028696 RID: 165526 RVA: 0x0058686A File Offset: 0x00584A6A
		public int RenjuCount { get; set; }

		// Token: 0x1700B23A RID: 45626
		// (get) Token: 0x06028697 RID: 165527 RVA: 0x00586873 File Offset: 0x00584A73
		// (set) Token: 0x06028698 RID: 165528 RVA: 0x0058687B File Offset: 0x00584A7B
		public List<int> EntityIds { get; set; }

		// Token: 0x1700B23B RID: 45627
		// (get) Token: 0x06028699 RID: 165529 RVA: 0x00586884 File Offset: 0x00584A84
		// (set) Token: 0x0602869A RID: 165530 RVA: 0x0058688C File Offset: 0x00584A8C
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700B23C RID: 45628
		// (get) Token: 0x0602869B RID: 165531 RVA: 0x00586895 File Offset: 0x00584A95
		// (set) Token: 0x0602869C RID: 165532 RVA: 0x0058689D File Offset: 0x00584A9D
		public byte NullMask { get; set; }

		// Token: 0x0602869D RID: 165533 RVA: 0x005868A6 File Offset: 0x00584AA6
		public IRenjuConfigT()
		{
			this.Controller = ERenjuController.Computer;
			this.Order = ERenjuOrder.Order0;
			this.RenjuCount = 0;
			this.EntityIds = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
