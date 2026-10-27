using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001410 RID: 5136
	public class IUseWeatherSwitchConditionAnyWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x060074C5 RID: 29893 RVA: 0x00117271 File Offset: 0x00115471
		[NullableContext(1)]
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

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x00117290 File Offset: 0x00115490
		public override EUseWeatherSwitchCheckType Type
		{
			get
			{
				return (EUseWeatherSwitchCheckType)this.Instance.Type;
			}
		}

		// Token: 0x0400439A RID: 17306
		private IUseWeatherSwitchConditionAnyWeather Instance;
	}
}
