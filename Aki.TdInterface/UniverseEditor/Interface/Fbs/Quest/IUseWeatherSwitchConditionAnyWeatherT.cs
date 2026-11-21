using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046BF RID: 18111
	public class IUseWeatherSwitchConditionAnyWeatherT
	{
		// Token: 0x17007EDF RID: 32479
		// (get) Token: 0x0601A9E5 RID: 109029 RVA: 0x003C912E File Offset: 0x003C732E
		// (set) Token: 0x0601A9E6 RID: 109030 RVA: 0x003C9136 File Offset: 0x003C7336
		public EUseWeatherSwitchCheckType Type { get; set; }

		// Token: 0x0601A9E7 RID: 109031 RVA: 0x003C913F File Offset: 0x003C733F
		public IUseWeatherSwitchConditionAnyWeatherT()
		{
			this.Type = EUseWeatherSwitchCheckType.SpecifiedWeather;
		}
	}
}
