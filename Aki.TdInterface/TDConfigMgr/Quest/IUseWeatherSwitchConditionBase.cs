using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001332 RID: 4914
	public class IUseWeatherSwitchConditionBase
	{
		// Token: 0x06006EA5 RID: 28325 RVA: 0x00106E44 File Offset: 0x00105044
		private IUseWeatherSwitchConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseWeatherSwitchConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseWeatherSwitchConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseWeatherSwitchConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x00106E7C File Offset: 0x0010507C
		public static IUseWeatherSwitchConditionBase Create([Nullable(2)] IUseWeatherSwitchConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x00106E8F File Offset: 0x0010508F
		public static IUseWeatherSwitchConditionBase CreateFromSetValue([Nullable(2)] IUseWeatherSwitchConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x00106EA2 File Offset: 0x001050A2
		public IUseWeatherSwitchConditionBase_SetValue ToSetValue()
		{
			return new IUseWeatherSwitchConditionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06006EA9 RID: 28329 RVA: 0x00106EB5 File Offset: 0x001050B5
		// (set) Token: 0x06006EAA RID: 28330 RVA: 0x00106EE0 File Offset: 0x001050E0
		public virtual EUseWeatherSwitchCheckType Type
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

		// Token: 0x040041F3 RID: 16883
		[Nullable(2)]
		protected IUseWeatherSwitchConditionBase FbInstance;

		// Token: 0x040041F4 RID: 16884
		[Nullable(2)]
		protected IUseWeatherSwitchConditionBase_SetValue PocoInterface;
	}
}
