using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200140F RID: 5135
	public class IUseWeatherSwitchConditionSpecifiedWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x060074C1 RID: 29889 RVA: 0x00117230 File Offset: 0x00115430
		[NullableContext(1)]
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

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x0011724F File Offset: 0x0011544F
		public override EUseWeatherSwitchCheckType Type
		{
			get
			{
				return (EUseWeatherSwitchCheckType)this.Instance.Type;
			}
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x060074C3 RID: 29891 RVA: 0x0011725C File Offset: 0x0011545C
		public virtual int WeatherSwitchId
		{
			get
			{
				return this.Instance.WeatherSwitchId;
			}
		}

		// Token: 0x04004399 RID: 17305
		private IUseWeatherSwitchConditionSpecifiedWeather Instance;
	}
}
