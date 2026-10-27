using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC7 RID: 24263
	public class ICommonBtSelectorT
	{
		// Token: 0x1700B55E RID: 46430
		// (get) Token: 0x06029A3F RID: 170559 RVA: 0x005B6C23 File Offset: 0x005B4E23
		// (set) Token: 0x06029A40 RID: 170560 RVA: 0x005B6C2B File Offset: 0x005B4E2B
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700B55F RID: 46431
		// (get) Token: 0x06029A41 RID: 170561 RVA: 0x005B6C34 File Offset: 0x005B4E34
		// (set) Token: 0x06029A42 RID: 170562 RVA: 0x005B6C3C File Offset: 0x005B4E3C
		public int Id { get; set; }

		// Token: 0x1700B560 RID: 46432
		// (get) Token: 0x06029A43 RID: 170563 RVA: 0x005B6C45 File Offset: 0x005B4E45
		// (set) Token: 0x06029A44 RID: 170564 RVA: 0x005B6C4D File Offset: 0x005B4E4D
		public string Desc { get; set; }

		// Token: 0x1700B561 RID: 46433
		// (get) Token: 0x06029A45 RID: 170565 RVA: 0x005B6C56 File Offset: 0x005B4E56
		// (set) Token: 0x06029A46 RID: 170566 RVA: 0x005B6C5E File Offset: 0x005B4E5E
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700B562 RID: 46434
		// (get) Token: 0x06029A47 RID: 170567 RVA: 0x005B6C67 File Offset: 0x005B4E67
		// (set) Token: 0x06029A48 RID: 170568 RVA: 0x005B6C6F File Offset: 0x005B4E6F
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700B563 RID: 46435
		// (get) Token: 0x06029A49 RID: 170569 RVA: 0x005B6C78 File Offset: 0x005B4E78
		// (set) Token: 0x06029A4A RID: 170570 RVA: 0x005B6C80 File Offset: 0x005B4E80
		public List<TCommonBtNodeUnion> Children { get; set; }

		// Token: 0x1700B564 RID: 46436
		// (get) Token: 0x06029A4B RID: 170571 RVA: 0x005B6C89 File Offset: 0x005B4E89
		// (set) Token: 0x06029A4C RID: 170572 RVA: 0x005B6C91 File Offset: 0x005B4E91
		public byte NullMask { get; set; }

		// Token: 0x06029A4D RID: 170573 RVA: 0x005B6C9A File Offset: 0x005B4E9A
		public ICommonBtSelectorT()
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
