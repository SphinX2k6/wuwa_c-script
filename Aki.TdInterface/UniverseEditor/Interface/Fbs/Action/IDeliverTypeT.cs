using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006577 RID: 25975
	public class IDeliverTypeT
	{
		// Token: 0x1700C0FE RID: 49406
		// (get) Token: 0x0602D104 RID: 184580 RVA: 0x0062EDAA File Offset: 0x0062CFAA
		// (set) Token: 0x0602D105 RID: 184581 RVA: 0x0062EDB2 File Offset: 0x0062CFB2
		public EDeliverType Type { get; set; }

		// Token: 0x0602D106 RID: 184582 RVA: 0x0062EDBB File Offset: 0x0062CFBB
		public IDeliverTypeT()
		{
			this.Type = EDeliverType.ItemIdCellIndependent;
		}
	}
}
