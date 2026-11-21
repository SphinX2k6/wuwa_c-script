using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001567 RID: 5479
	public class IUseWeatherSwitchConditionAnyWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x06007B86 RID: 31622 RVA: 0x00125C55 File Offset: 0x00123E55
		public static IUseWeatherSwitchConditionAnyWeather Create(IUseWeatherSwitchConditionAnyWeather? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionAnyWeather
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x00125C74 File Offset: 0x00123E74
		public override EUseWeatherSwitchCheckType Type
		{
			get
			{
				return (EUseWeatherSwitchCheckType)this.Instance.Type;
			}
		}

		// Token: 0x0400472B RID: 18219
		private IUseWeatherSwitchConditionAnyWeather Instance;
	}
}
