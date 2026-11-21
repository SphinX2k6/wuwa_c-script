using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C8 RID: 18120
	public class IUseWeatherSwitchConditionSpecifiedWeatherT
	{
		// Token: 0x17007EE8 RID: 32488
		// (get) Token: 0x0601AA19 RID: 109081 RVA: 0x003C95C8 File Offset: 0x003C77C8
		// (set) Token: 0x0601AA1A RID: 109082 RVA: 0x003C95D0 File Offset: 0x003C77D0
		public EUseWeatherSwitchCheckType Type { get; set; }

		// Token: 0x17007EE9 RID: 32489
		// (get) Token: 0x0601AA1B RID: 109083 RVA: 0x003C95D9 File Offset: 0x003C77D9
		// (set) Token: 0x0601AA1C RID: 109084 RVA: 0x003C95E1 File Offset: 0x003C77E1
		public int WeatherSwitchId { get; set; }

		// Token: 0x0601AA1D RID: 109085 RVA: 0x003C95EA File Offset: 0x003C77EA
		public IUseWeatherSwitchConditionSpecifiedWeatherT()
		{
			this.Type = EUseWeatherSwitchCheckType.SpecifiedWeather;
			this.WeatherSwitchId = 0;
		}
	}
}
