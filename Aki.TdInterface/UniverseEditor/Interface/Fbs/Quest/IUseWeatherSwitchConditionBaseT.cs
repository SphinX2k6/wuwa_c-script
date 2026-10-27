using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004266 RID: 16998
	public class IUseWeatherSwitchConditionBaseT
	{
		// Token: 0x170078B1 RID: 30897
		// (get) Token: 0x0601928B RID: 103051 RVA: 0x0039DBCE File Offset: 0x0039BDCE
		// (set) Token: 0x0601928C RID: 103052 RVA: 0x0039DBD6 File Offset: 0x0039BDD6
		public EUseWeatherSwitchCheckType Type { get; set; }

		// Token: 0x0601928D RID: 103053 RVA: 0x0039DBDF File Offset: 0x0039BDDF
		public IUseWeatherSwitchConditionBaseT()
		{
			this.Type = EUseWeatherSwitchCheckType.SpecifiedWeather;
		}
	}
}
