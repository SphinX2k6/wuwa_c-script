using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007278 RID: 29304
	public class ISwordIntentTipT
	{
		// Token: 0x1700D96E RID: 55662
		// (get) Token: 0x06033FE9 RID: 212969 RVA: 0x006FDF36 File Offset: 0x006FC136
		// (set) Token: 0x06033FEA RID: 212970 RVA: 0x006FDF3E File Offset: 0x006FC13E
		public ECommonTipType Type { get; set; }

		// Token: 0x06033FEB RID: 212971 RVA: 0x006FDF47 File Offset: 0x006FC147
		public ISwordIntentTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
		}
	}
}
