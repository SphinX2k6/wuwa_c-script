using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED0 RID: 24272
	public class ICommonBtTaskT
	{
		// Token: 0x1700B58F RID: 46479
		// (get) Token: 0x06029B0A RID: 170762 RVA: 0x005B904A File Offset: 0x005B724A
		// (set) Token: 0x06029B0B RID: 170763 RVA: 0x005B9052 File Offset: 0x005B7252
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700B590 RID: 46480
		// (get) Token: 0x06029B0C RID: 170764 RVA: 0x005B905B File Offset: 0x005B725B
		// (set) Token: 0x06029B0D RID: 170765 RVA: 0x005B9063 File Offset: 0x005B7263
		public int Id { get; set; }

		// Token: 0x1700B591 RID: 46481
		// (get) Token: 0x06029B0E RID: 170766 RVA: 0x005B906C File Offset: 0x005B726C
		// (set) Token: 0x06029B0F RID: 170767 RVA: 0x005B9074 File Offset: 0x005B7274
		public string Desc { get; set; }

		// Token: 0x1700B592 RID: 46482
		// (get) Token: 0x06029B10 RID: 170768 RVA: 0x005B907D File Offset: 0x005B727D
		// (set) Token: 0x06029B11 RID: 170769 RVA: 0x005B9085 File Offset: 0x005B7285
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700B593 RID: 46483
		// (get) Token: 0x06029B12 RID: 170770 RVA: 0x005B908E File Offset: 0x005B728E
		// (set) Token: 0x06029B13 RID: 170771 RVA: 0x005B9096 File Offset: 0x005B7296
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700B594 RID: 46484
		// (get) Token: 0x06029B14 RID: 170772 RVA: 0x005B909F File Offset: 0x005B729F
		// (set) Token: 0x06029B15 RID: 170773 RVA: 0x005B90A7 File Offset: 0x005B72A7
		public ICommonBtActionInfoT ActionInfo { get; set; }

		// Token: 0x1700B595 RID: 46485
		// (get) Token: 0x06029B16 RID: 170774 RVA: 0x005B90B0 File Offset: 0x005B72B0
		// (set) Token: 0x06029B17 RID: 170775 RVA: 0x005B90B8 File Offset: 0x005B72B8
		public byte NullMask { get; set; }

		// Token: 0x06029B18 RID: 170776 RVA: 0x005B90C1 File Offset: 0x005B72C1
		public ICommonBtTaskT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.ActionInfo = null;
			this.NullMask = 0;
		}
	}
}
