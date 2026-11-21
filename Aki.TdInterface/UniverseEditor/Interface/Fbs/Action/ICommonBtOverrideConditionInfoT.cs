using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD4 RID: 27348
	public class ICommonBtOverrideConditionInfoT
	{
		// Token: 0x1700C8D3 RID: 51411
		// (get) Token: 0x0602EFCA RID: 192458 RVA: 0x006689B3 File Offset: 0x00666BB3
		// (set) Token: 0x0602EFCB RID: 192459 RVA: 0x006689BB File Offset: 0x00666BBB
		public ECommonBtPlaceholderTargetType Type { get; set; }

		// Token: 0x1700C8D4 RID: 51412
		// (get) Token: 0x0602EFCC RID: 192460 RVA: 0x006689C4 File Offset: 0x00666BC4
		// (set) Token: 0x0602EFCD RID: 192461 RVA: 0x006689CC File Offset: 0x00666BCC
		public ICondition2_UnionUnion Condition { get; set; }

		// Token: 0x0602EFCE RID: 192462 RVA: 0x006689D5 File Offset: 0x00666BD5
		public ICommonBtOverrideConditionInfoT()
		{
			this.Type = ECommonBtPlaceholderTargetType.Action;
			this.Condition = null;
		}
	}
}
