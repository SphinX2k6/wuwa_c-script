using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063CF RID: 25551
	public class IDynamicSummonGongduolaPointT
	{
		// Token: 0x1700BCCD RID: 48333
		// (get) Token: 0x0602B672 RID: 177778 RVA: 0x005EA50E File Offset: 0x005E870E
		// (set) Token: 0x0602B673 RID: 177779 RVA: 0x005EA516 File Offset: 0x005E8716
		public int EntityId { get; set; }

		// Token: 0x1700BCCE RID: 48334
		// (get) Token: 0x0602B674 RID: 177780 RVA: 0x005EA51F File Offset: 0x005E871F
		// (set) Token: 0x0602B675 RID: 177781 RVA: 0x005EA527 File Offset: 0x005E8727
		public string Id { get; set; }

		// Token: 0x1700BCCF RID: 48335
		// (get) Token: 0x0602B676 RID: 177782 RVA: 0x005EA530 File Offset: 0x005E8730
		// (set) Token: 0x0602B677 RID: 177783 RVA: 0x005EA538 File Offset: 0x005E8738
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700BCD0 RID: 48336
		// (get) Token: 0x0602B678 RID: 177784 RVA: 0x005EA541 File Offset: 0x005E8741
		// (set) Token: 0x0602B679 RID: 177785 RVA: 0x005EA549 File Offset: 0x005E8749
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700BCD1 RID: 48337
		// (get) Token: 0x0602B67A RID: 177786 RVA: 0x005EA552 File Offset: 0x005E8752
		// (set) Token: 0x0602B67B RID: 177787 RVA: 0x005EA55A File Offset: 0x005E875A
		public EWorldAxisType Gravity { get; set; }

		// Token: 0x0602B67C RID: 177788 RVA: 0x005EA563 File Offset: 0x005E8763
		public IDynamicSummonGongduolaPointT()
		{
			this.EntityId = 0;
			this.Id = null;
			this.Position = null;
			this.Rotation = null;
			this.Gravity = EWorldAxisType.PositiveX;
		}
	}
}
