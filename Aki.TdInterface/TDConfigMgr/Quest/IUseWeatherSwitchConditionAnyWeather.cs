using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001330 RID: 4912
	public class IUseWeatherSwitchConditionAnyWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x06006E9D RID: 28317 RVA: 0x00106D88 File Offset: 0x00104F88
		private IUseWeatherSwitchConditionAnyWeather_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseWeatherSwitchConditionAnyWeather 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseWeatherSwitchConditionAnyWeather_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseWeatherSwitchConditionAnyWeather_SetValue());
			}
			return result;
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x00106DC0 File Offset: 0x00104FC0
		public static IUseWeatherSwitchConditionAnyWeather Create([Nullable(2)] IUseWeatherSwitchConditionAnyWeather instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionAnyWeather
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x00106DD3 File Offset: 0x00104FD3
		public static IUseWeatherSwitchConditionAnyWeather CreateFromSetValue([Nullable(2)] IUseWeatherSwitchConditionAnyWeather_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionAnyWeather
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x00106DE6 File Offset: 0x00104FE6
		public new IUseWeatherSwitchConditionAnyWeather_SetValue ToSetValue()
		{
			return new IUseWeatherSwitchConditionAnyWeather_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x00106DF9 File Offset: 0x00104FF9
		// (set) Token: 0x06006EA2 RID: 28322 RVA: 0x00106E24 File Offset: 0x00105024
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

		// Token: 0x040041F0 RID: 16880
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionAnyWeather FbInstance;

		// Token: 0x040041F1 RID: 16881
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionAnyWeather_SetValue PocoInterface;
	}
}
