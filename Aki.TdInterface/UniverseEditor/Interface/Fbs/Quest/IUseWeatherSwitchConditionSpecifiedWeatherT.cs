using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426C RID: 17004
	public class IUseWeatherSwitchConditionSpecifiedWeatherT
	{
		// Token: 0x170078B7 RID: 30903
		// (get) Token: 0x060192AD RID: 103085 RVA: 0x0039DEF0 File Offset: 0x0039C0F0
		// (set) Token: 0x060192AE RID: 103086 RVA: 0x0039DEF8 File Offset: 0x0039C0F8
		public EUseWeatherSwitchCheckType Type { get; set; }

		// Token: 0x170078B8 RID: 30904
		// (get) Token: 0x060192AF RID: 103087 RVA: 0x0039DF01 File Offset: 0x0039C101
		// (set) Token: 0x060192B0 RID: 103088 RVA: 0x0039DF09 File Offset: 0x0039C109
		public int WeatherSwitchId { get; set; }

		// Token: 0x060192B1 RID: 103089 RVA: 0x0039DF12 File Offset: 0x0039C112
		public IUseWeatherSwitchConditionSpecifiedWeatherT()
		{
			this.Type = EUseWeatherSwitchCheckType.SpecifiedWeather;
			this.WeatherSwitchId = 0;
		}
	}
}
