using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E6 RID: 9190
	public class SeasonWeatherChangeTo : ActionParams
	{
		// Token: 0x0600C820 RID: 51232 RVA: 0x001C9CB4 File Offset: 0x001C7EB4
		private SeasonWeatherChangeTo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SeasonWeatherChangeTo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SeasonWeatherChangeTo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SeasonWeatherChangeTo_SetValue());
			}
			return result;
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x001C9CEC File Offset: 0x001C7EEC
		public static SeasonWeatherChangeTo Create([Nullable(2)] SeasonWeatherChangeTo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeasonWeatherChangeTo
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C822 RID: 51234 RVA: 0x001C9CFF File Offset: 0x001C7EFF
		public static SeasonWeatherChangeTo CreateFromSetValue([Nullable(2)] SeasonWeatherChangeTo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SeasonWeatherChangeTo
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x001C9D12 File Offset: 0x001C7F12
		public SeasonWeatherChangeTo_SetValue ToSetValue()
		{
			return new SeasonWeatherChangeTo_SetValue
			{
				Season = this.Season,
				Weather = this.Weather
			};
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x001C9D31 File Offset: 0x001C7F31
		// (set) Token: 0x0600C825 RID: 51237 RVA: 0x001C9D5C File Offset: 0x001C7F5C
		public virtual int Season
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Season;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Season;
			}
			set
			{
				this.GetOrCreatePoco().Season = value;
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600C826 RID: 51238 RVA: 0x001C9D6C File Offset: 0x001C7F6C
		// (set) Token: 0x0600C827 RID: 51239 RVA: 0x001C9DA6 File Offset: 0x001C7FA6
		public virtual int? Weather
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weather;
				}
				SeasonWeatherChangeTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Weather;
			}
			set
			{
				this.GetOrCreatePoco().Weather = value;
			}
		}

		// Token: 0x040076D0 RID: 30416
		[Nullable(2)]
		protected new SeasonWeatherChangeTo FbInstance;

		// Token: 0x040076D1 RID: 30417
		[Nullable(2)]
		protected SeasonWeatherChangeTo_SetValue PocoInterface;
	}
}
