using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200650A RID: 25866
	public class ICommonBtSelectorT
	{
		// Token: 0x1700BEC9 RID: 48841
		// (get) Token: 0x0602C0F3 RID: 180467 RVA: 0x00600107 File Offset: 0x005FE307
		// (set) Token: 0x0602C0F4 RID: 180468 RVA: 0x0060010F File Offset: 0x005FE30F
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700BECA RID: 48842
		// (get) Token: 0x0602C0F5 RID: 180469 RVA: 0x00600118 File Offset: 0x005FE318
		// (set) Token: 0x0602C0F6 RID: 180470 RVA: 0x00600120 File Offset: 0x005FE320
		public int Id { get; set; }

		// Token: 0x1700BECB RID: 48843
		// (get) Token: 0x0602C0F7 RID: 180471 RVA: 0x00600129 File Offset: 0x005FE329
		// (set) Token: 0x0602C0F8 RID: 180472 RVA: 0x00600131 File Offset: 0x005FE331
		public string Desc { get; set; }

		// Token: 0x1700BECC RID: 48844
		// (get) Token: 0x0602C0F9 RID: 180473 RVA: 0x0060013A File Offset: 0x005FE33A
		// (set) Token: 0x0602C0FA RID: 180474 RVA: 0x00600142 File Offset: 0x005FE342
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700BECD RID: 48845
		// (get) Token: 0x0602C0FB RID: 180475 RVA: 0x0060014B File Offset: 0x005FE34B
		// (set) Token: 0x0602C0FC RID: 180476 RVA: 0x00600153 File Offset: 0x005FE353
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700BECE RID: 48846
		// (get) Token: 0x0602C0FD RID: 180477 RVA: 0x0060015C File Offset: 0x005FE35C
		// (set) Token: 0x0602C0FE RID: 180478 RVA: 0x00600164 File Offset: 0x005FE364
		public List<TCommonBtNodeUnion> Children { get; set; }

		// Token: 0x1700BECF RID: 48847
		// (get) Token: 0x0602C0FF RID: 180479 RVA: 0x0060016D File Offset: 0x005FE36D
		// (set) Token: 0x0602C100 RID: 180480 RVA: 0x00600175 File Offset: 0x005FE375
		public byte NullMask { get; set; }

		// Token: 0x0602C101 RID: 180481 RVA: 0x0060017E File Offset: 0x005FE37E
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
