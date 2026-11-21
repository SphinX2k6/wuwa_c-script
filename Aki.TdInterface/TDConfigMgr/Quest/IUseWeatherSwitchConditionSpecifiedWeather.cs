using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001334 RID: 4916
	public class IUseWeatherSwitchConditionSpecifiedWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x06006EAD RID: 28333 RVA: 0x00106F00 File Offset: 0x00105100
		private IUseWeatherSwitchConditionSpecifiedWeather_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseWeatherSwitchConditionSpecifiedWeather 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseWeatherSwitchConditionSpecifiedWeather_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseWeatherSwitchConditionSpecifiedWeather_SetValue());
			}
			return result;
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00106F38 File Offset: 0x00105138
		public static IUseWeatherSwitchConditionSpecifiedWeather Create([Nullable(2)] IUseWeatherSwitchConditionSpecifiedWeather instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionSpecifiedWeather
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x00106F4B File Offset: 0x0010514B
		public static IUseWeatherSwitchConditionSpecifiedWeather CreateFromSetValue([Nullable(2)] IUseWeatherSwitchConditionSpecifiedWeather_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionSpecifiedWeather
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00106F5E File Offset: 0x0010515E
		public new IUseWeatherSwitchConditionSpecifiedWeather_SetValue ToSetValue()
		{
			return new IUseWeatherSwitchConditionSpecifiedWeather_SetValue
			{
				Type = this.Type,
				WeatherSwitchId = this.WeatherSwitchId
			};
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06006EB1 RID: 28337 RVA: 0x00106F7D File Offset: 0x0010517D
		// (set) Token: 0x06006EB2 RID: 28338 RVA: 0x00106FA8 File Offset: 0x001051A8
		public override EUseWeatherSwitchCheckType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUseWeatherSwitchCheckType.SpecifiedWeather;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06006EB3 RID: 28339 RVA: 0x00106FB6 File Offset: 0x001051B6
		// (set) Token: 0x06006EB4 RID: 28340 RVA: 0x00106FE1 File Offset: 0x001051E1
		public virtual int WeatherSwitchId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeatherSwitchId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WeatherSwitchId;
			}
			set
			{
				this.GetOrCreatePoco().WeatherSwitchId = value;
			}
		}

		// Token: 0x040041F6 RID: 16886
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionSpecifiedWeather FbInstance;

		// Token: 0x040041F7 RID: 16887
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionSpecifiedWeather_SetValue PocoInterface;
	}
}
