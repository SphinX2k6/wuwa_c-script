using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011F8 RID: 4600
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseWeatherSwitchConditionSpecifiedWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x0600686C RID: 26732 RVA: 0x000F95F4 File Offset: 0x000F77F4
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

		// Token: 0x0600686D RID: 26733 RVA: 0x000F962C File Offset: 0x000F782C
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

		// Token: 0x0600686E RID: 26734 RVA: 0x000F963F File Offset: 0x000F783F
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

		// Token: 0x0600686F RID: 26735 RVA: 0x000F9652 File Offset: 0x000F7852
		public new IUseWeatherSwitchConditionSpecifiedWeather_SetValue ToSetValue()
		{
			return new IUseWeatherSwitchConditionSpecifiedWeather_SetValue
			{
				Type = this.Type,
				WeatherSwitchId = this.WeatherSwitchId
			};
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06006870 RID: 26736 RVA: 0x000F9671 File Offset: 0x000F7871
		// (set) Token: 0x06006871 RID: 26737 RVA: 0x000F969C File Offset: 0x000F789C
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

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06006872 RID: 26738 RVA: 0x000F96AA File Offset: 0x000F78AA
		// (set) Token: 0x06006873 RID: 26739 RVA: 0x000F96D5 File Offset: 0x000F78D5
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

		// Token: 0x04003E88 RID: 16008
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionSpecifiedWeather FbInstance;

		// Token: 0x04003E89 RID: 16009
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionSpecifiedWeather_SetValue PocoInterface;
	}
}
