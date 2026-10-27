using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004263 RID: 16995
	public class IUseWeatherSwitchConditionAnyWeatherT
	{
		// Token: 0x170078AE RID: 30894
		// (get) Token: 0x06019279 RID: 103033 RVA: 0x0039DA56 File Offset: 0x0039BC56
		// (set) Token: 0x0601927A RID: 103034 RVA: 0x0039DA5E File Offset: 0x0039BC5E
		public EUseWeatherSwitchCheckType Type { get; set; }

		// Token: 0x0601927B RID: 103035 RVA: 0x0039DA67 File Offset: 0x0039BC67
		public IUseWeatherSwitchConditionAnyWeatherT()
		{
			this.Type = EUseWeatherSwitchCheckType.SpecifiedWeather;
		}
	}
}
