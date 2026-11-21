using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001566 RID: 5478
	public class IUseWeatherSwitchConditionSpecifiedWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x06007B82 RID: 31618 RVA: 0x00125C14 File Offset: 0x00123E14
		public static IUseWeatherSwitchConditionSpecifiedWeather Create(IUseWeatherSwitchConditionSpecifiedWeather? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionSpecifiedWeather
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x00125C33 File Offset: 0x00123E33
		public override EUseWeatherSwitchCheckType Type
		{
			get
			{
				return (EUseWeatherSwitchCheckType)this.Instance.Type;
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x06007B84 RID: 31620 RVA: 0x00125C40 File Offset: 0x00123E40
		public virtual int WeatherSwitchId
		{
			get
			{
				return this.Instance.WeatherSwitchId;
			}
		}

		// Token: 0x0400472A RID: 18218
		private IUseWeatherSwitchConditionSpecifiedWeather Instance;
	}
}
