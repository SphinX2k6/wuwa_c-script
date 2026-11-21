using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C2 RID: 18114
	public class IUseWeatherSwitchConditionBaseT
	{
		// Token: 0x17007EE2 RID: 32482
		// (get) Token: 0x0601A9F7 RID: 109047 RVA: 0x003C92A6 File Offset: 0x003C74A6
		// (set) Token: 0x0601A9F8 RID: 109048 RVA: 0x003C92AE File Offset: 0x003C74AE
		public EUseWeatherSwitchCheckType Type { get; set; }

		// Token: 0x0601A9F9 RID: 109049 RVA: 0x003C92B7 File Offset: 0x003C74B7
		public IUseWeatherSwitchConditionBaseT()
		{
			this.Type = EUseWeatherSwitchCheckType.SpecifiedWeather;
		}
	}
}
