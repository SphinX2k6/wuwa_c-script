using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ECA RID: 24266
	public class ICommonBtSequenceT
	{
		// Token: 0x1700B56F RID: 46447
		// (get) Token: 0x06029A8B RID: 170635 RVA: 0x005B7A3B File Offset: 0x005B5C3B
		// (set) Token: 0x06029A8C RID: 170636 RVA: 0x005B7A43 File Offset: 0x005B5C43
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700B570 RID: 46448
		// (get) Token: 0x06029A8D RID: 170637 RVA: 0x005B7A4C File Offset: 0x005B5C4C
		// (set) Token: 0x06029A8E RID: 170638 RVA: 0x005B7A54 File Offset: 0x005B5C54
		public int Id { get; set; }

		// Token: 0x1700B571 RID: 46449
		// (get) Token: 0x06029A8F RID: 170639 RVA: 0x005B7A5D File Offset: 0x005B5C5D
		// (set) Token: 0x06029A90 RID: 170640 RVA: 0x005B7A65 File Offset: 0x005B5C65
		public string Desc { get; set; }

		// Token: 0x1700B572 RID: 46450
		// (get) Token: 0x06029A91 RID: 170641 RVA: 0x005B7A6E File Offset: 0x005B5C6E
		// (set) Token: 0x06029A92 RID: 170642 RVA: 0x005B7A76 File Offset: 0x005B5C76
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700B573 RID: 46451
		// (get) Token: 0x06029A93 RID: 170643 RVA: 0x005B7A7F File Offset: 0x005B5C7F
		// (set) Token: 0x06029A94 RID: 170644 RVA: 0x005B7A87 File Offset: 0x005B5C87
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700B574 RID: 46452
		// (get) Token: 0x06029A95 RID: 170645 RVA: 0x005B7A90 File Offset: 0x005B5C90
		// (set) Token: 0x06029A96 RID: 170646 RVA: 0x005B7A98 File Offset: 0x005B5C98
		public List<TCommonBtNodeUnion> Children { get; set; }

		// Token: 0x1700B575 RID: 46453
		// (get) Token: 0x06029A97 RID: 170647 RVA: 0x005B7AA1 File Offset: 0x005B5CA1
		// (set) Token: 0x06029A98 RID: 170648 RVA: 0x005B7AA9 File Offset: 0x005B5CA9
		public byte NullMask { get; set; }

		// Token: 0x06029A99 RID: 170649 RVA: 0x005B7AB2 File Offset: 0x005B5CB2
		public ICommonBtSequenceT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}
