using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E06 RID: 11782
	public class SeasonWeatherUnlockSpecial : ActionParams
	{
		// Token: 0x06010014 RID: 65556 RVA: 0x0024DCAA File Offset: 0x0024BEAA
		public static SeasonWeatherUnlockSpecial Create(ISeasonWeatherUnlockSpecial? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeasonWeatherUnlockSpecial
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x06010015 RID: 65557 RVA: 0x0024DCC9 File Offset: 0x0024BEC9
		public virtual int Weather
		{
			get
			{
				return this.Instance.Weather;
			}
		}

		// Token: 0x04008BC0 RID: 35776
		private ISeasonWeatherUnlockSpecial Instance;
	}
}
