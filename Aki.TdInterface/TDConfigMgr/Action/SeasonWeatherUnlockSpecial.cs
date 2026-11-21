using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EA RID: 9194
	public class SeasonWeatherUnlockSpecial : ActionParams
	{
		// Token: 0x0600C832 RID: 51250 RVA: 0x001C9E80 File Offset: 0x001C8080
		private SeasonWeatherUnlockSpecial_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SeasonWeatherUnlockSpecial 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SeasonWeatherUnlockSpecial_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SeasonWeatherUnlockSpecial_SetValue());
			}
			return result;
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x001C9EB8 File Offset: 0x001C80B8
		public static SeasonWeatherUnlockSpecial Create([Nullable(2)] SeasonWeatherUnlockSpecial instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeasonWeatherUnlockSpecial
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x001C9ECB File Offset: 0x001C80CB
		public static SeasonWeatherUnlockSpecial CreateFromSetValue([Nullable(2)] SeasonWeatherUnlockSpecial_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SeasonWeatherUnlockSpecial
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C835 RID: 51253 RVA: 0x001C9EDE File Offset: 0x001C80DE
		public SeasonWeatherUnlockSpecial_SetValue ToSetValue()
		{
			return new SeasonWeatherUnlockSpecial_SetValue
			{
				Weather = this.Weather
			};
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600C836 RID: 51254 RVA: 0x001C9EF1 File Offset: 0x001C80F1
		// (set) Token: 0x0600C837 RID: 51255 RVA: 0x001C9F1C File Offset: 0x001C811C
		public virtual int Weather
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weather;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weather;
			}
			set
			{
				this.GetOrCreatePoco().Weather = value;
			}
		}

		// Token: 0x040076D7 RID: 30423
		[Nullable(2)]
		protected new SeasonWeatherUnlockSpecial FbInstance;

		// Token: 0x040076D8 RID: 30424
		[Nullable(2)]
		protected SeasonWeatherUnlockSpecial_SetValue PocoInterface;
	}
}
