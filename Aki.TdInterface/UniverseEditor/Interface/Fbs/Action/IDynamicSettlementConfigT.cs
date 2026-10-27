using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200661F RID: 26143
	public class IDynamicSettlementConfigT
	{
		// Token: 0x1700C23F RID: 49727
		// (get) Token: 0x0602D665 RID: 185957 RVA: 0x006386EE File Offset: 0x006368EE
		// (set) Token: 0x0602D666 RID: 185958 RVA: 0x006386F6 File Offset: 0x006368F6
		public EDynamicSettlementType Type { get; set; }

		// Token: 0x0602D667 RID: 185959 RVA: 0x006386FF File Offset: 0x006368FF
		public IDynamicSettlementConfigT()
		{
			this.Type = EDynamicSettlementType.Battle;
		}
	}
}
