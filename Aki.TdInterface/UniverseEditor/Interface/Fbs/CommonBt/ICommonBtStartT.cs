using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ECD RID: 24269
	public class ICommonBtStartT
	{
		// Token: 0x1700B57F RID: 46463
		// (get) Token: 0x06029ACE RID: 170702 RVA: 0x005B862B File Offset: 0x005B682B
		// (set) Token: 0x06029ACF RID: 170703 RVA: 0x005B8633 File Offset: 0x005B6833
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700B580 RID: 46464
		// (get) Token: 0x06029AD0 RID: 170704 RVA: 0x005B863C File Offset: 0x005B683C
		// (set) Token: 0x06029AD1 RID: 170705 RVA: 0x005B8644 File Offset: 0x005B6844
		public int Id { get; set; }

		// Token: 0x1700B581 RID: 46465
		// (get) Token: 0x06029AD2 RID: 170706 RVA: 0x005B864D File Offset: 0x005B684D
		// (set) Token: 0x06029AD3 RID: 170707 RVA: 0x005B8655 File Offset: 0x005B6855
		public string Desc { get; set; }

		// Token: 0x1700B582 RID: 46466
		// (get) Token: 0x06029AD4 RID: 170708 RVA: 0x005B865E File Offset: 0x005B685E
		// (set) Token: 0x06029AD5 RID: 170709 RVA: 0x005B8666 File Offset: 0x005B6866
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700B583 RID: 46467
		// (get) Token: 0x06029AD6 RID: 170710 RVA: 0x005B866F File Offset: 0x005B686F
		// (set) Token: 0x06029AD7 RID: 170711 RVA: 0x005B8677 File Offset: 0x005B6877
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700B584 RID: 46468
		// (get) Token: 0x06029AD8 RID: 170712 RVA: 0x005B8680 File Offset: 0x005B6880
		// (set) Token: 0x06029AD9 RID: 170713 RVA: 0x005B8688 File Offset: 0x005B6888
		public TCommonBtNodeUnion Child { get; set; }

		// Token: 0x1700B585 RID: 46469
		// (get) Token: 0x06029ADA RID: 170714 RVA: 0x005B8691 File Offset: 0x005B6891
		// (set) Token: 0x06029ADB RID: 170715 RVA: 0x005B8699 File Offset: 0x005B6899
		public byte NullMask { get; set; }

		// Token: 0x06029ADC RID: 170716 RVA: 0x005B86A2 File Offset: 0x005B68A2
		public ICommonBtStartT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Child = null;
			this.NullMask = 0;
		}
	}
}
