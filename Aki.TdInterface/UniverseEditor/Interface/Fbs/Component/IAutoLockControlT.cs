using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE7 RID: 20199
	public class IAutoLockControlT
	{
		// Token: 0x170090FD RID: 37117
		// (get) Token: 0x0601FD77 RID: 130423 RVA: 0x0046E2BA File Offset: 0x0046C4BA
		// (set) Token: 0x0601FD78 RID: 130424 RVA: 0x0046E2C2 File Offset: 0x0046C4C2
		public IConditionGroupT EnableCondition { get; set; }

		// Token: 0x170090FE RID: 37118
		// (get) Token: 0x0601FD79 RID: 130425 RVA: 0x0046E2CB File Offset: 0x0046C4CB
		// (set) Token: 0x0601FD7A RID: 130426 RVA: 0x0046E2D3 File Offset: 0x0046C4D3
		public IConditionGroupT DisableCondition { get; set; }

		// Token: 0x0601FD7B RID: 130427 RVA: 0x0046E2DC File Offset: 0x0046C4DC
		public IAutoLockControlT()
		{
			this.EnableCondition = null;
			this.DisableCondition = null;
		}
	}
}
