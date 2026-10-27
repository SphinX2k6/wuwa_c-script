using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006336 RID: 25398
	public class IChangeTimerUiConfigT
	{
		// Token: 0x1700BD8D RID: 48525
		// (get) Token: 0x0602BEEA RID: 179946 RVA: 0x00609EB6 File Offset: 0x006080B6
		// (set) Token: 0x0602BEEB RID: 179947 RVA: 0x00609EBE File Offset: 0x006080BE
		public EChangeTimerUiType UiType { get; set; }

		// Token: 0x0602BEEC RID: 179948 RVA: 0x00609EC7 File Offset: 0x006080C7
		public IChangeTimerUiConfigT()
		{
			this.UiType = EChangeTimerUiType.None;
		}
	}
}
