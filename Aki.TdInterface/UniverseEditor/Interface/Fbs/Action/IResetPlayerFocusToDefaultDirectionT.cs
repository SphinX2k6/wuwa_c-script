using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007616 RID: 30230
	public class IResetPlayerFocusToDefaultDirectionT
	{
		// Token: 0x1700DE20 RID: 56864
		// (get) Token: 0x060350BF RID: 217279 RVA: 0x0072026A File Offset: 0x0071E46A
		// (set) Token: 0x060350C0 RID: 217280 RVA: 0x00720272 File Offset: 0x0071E472
		public EResetPlayerFocusType Type { get; set; }

		// Token: 0x060350C1 RID: 217281 RVA: 0x0072027B File Offset: 0x0071E47B
		public IResetPlayerFocusToDefaultDirectionT()
		{
			this.Type = EResetPlayerFocusType.ResetToDefaultDirection;
		}
	}
}
