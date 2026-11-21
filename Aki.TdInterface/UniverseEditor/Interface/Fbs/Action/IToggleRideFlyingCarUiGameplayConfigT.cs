using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C03 RID: 31747
	public class IToggleRideFlyingCarUiGameplayConfigT
	{
		// Token: 0x1700EDC5 RID: 60869
		// (get) Token: 0x06039394 RID: 234388 RVA: 0x007BAEE6 File Offset: 0x007B90E6
		// (set) Token: 0x06039395 RID: 234389 RVA: 0x007BAEEE File Offset: 0x007B90EE
		public EToggleRideFlyingCarUiGameplayType Type { get; set; }

		// Token: 0x06039396 RID: 234390 RVA: 0x007BAEF7 File Offset: 0x007B90F7
		public IToggleRideFlyingCarUiGameplayConfigT()
		{
			this.Type = EToggleRideFlyingCarUiGameplayType.Enable;
		}
	}
}
