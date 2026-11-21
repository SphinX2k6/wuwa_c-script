using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C90 RID: 27792
	public class IDynamicSettlementConfigT
	{
		// Token: 0x1700CBDD RID: 52189
		// (get) Token: 0x0602FE36 RID: 196150 RVA: 0x00685256 File Offset: 0x00683456
		// (set) Token: 0x0602FE37 RID: 196151 RVA: 0x0068525E File Offset: 0x0068345E
		public EDynamicSettlementType Type { get; set; }

		// Token: 0x0602FE38 RID: 196152 RVA: 0x00685267 File Offset: 0x00683467
		public IDynamicSettlementConfigT()
		{
			this.Type = EDynamicSettlementType.Battle;
		}
	}
}
