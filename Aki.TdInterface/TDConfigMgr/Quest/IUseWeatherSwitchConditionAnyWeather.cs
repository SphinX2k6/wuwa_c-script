using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011F4 RID: 4596
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseWeatherSwitchConditionAnyWeather : IUseWeatherSwitchConditionBase
	{
		// Token: 0x0600685C RID: 26716 RVA: 0x000F947C File Offset: 0x000F767C
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

		// Token: 0x0600685D RID: 26717 RVA: 0x000F94B4 File Offset: 0x000F76B4
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

		// Token: 0x0600685E RID: 26718 RVA: 0x000F94C7 File Offset: 0x000F76C7
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

		// Token: 0x0600685F RID: 26719 RVA: 0x000F94DA File Offset: 0x000F76DA
		public new IUseWeatherSwitchConditionAnyWeather_SetValue ToSetValue()
		{
			return new IUseWeatherSwitchConditionAnyWeather_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x000F94ED File Offset: 0x000F76ED
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x000F9518 File Offset: 0x000F7718
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

		// Token: 0x04003E82 RID: 16002
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionAnyWeather FbInstance;

		// Token: 0x04003E83 RID: 16003
		[Nullable(2)]
		protected new IUseWeatherSwitchConditionAnyWeather_SetValue PocoInterface;
	}
}
