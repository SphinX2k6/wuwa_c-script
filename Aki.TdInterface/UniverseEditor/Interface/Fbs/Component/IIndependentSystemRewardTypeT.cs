using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005979 RID: 22905
	public class IIndependentSystemRewardTypeT
	{
		// Token: 0x1700A665 RID: 42597
		// (get) Token: 0x0602556F RID: 152943 RVA: 0x0051FF5A File Offset: 0x0051E15A
		// (set) Token: 0x06025570 RID: 152944 RVA: 0x0051FF62 File Offset: 0x0051E162
		public EIndependentSystemRewardType Type { get; set; }

		// Token: 0x06025571 RID: 152945 RVA: 0x0051FF6B File Offset: 0x0051E16B
		public IIndependentSystemRewardTypeT()
		{
			this.Type = EIndependentSystemRewardType.DarkTide;
		}
	}
}
