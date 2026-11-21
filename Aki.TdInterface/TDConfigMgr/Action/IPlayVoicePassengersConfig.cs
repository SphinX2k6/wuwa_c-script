using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F33 RID: 7987
	public class IPlayVoicePassengersConfig
	{
		// Token: 0x0600A9F9 RID: 43513 RVA: 0x00181974 File Offset: 0x0017FB74
		private IPlayVoicePassengersConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayVoicePassengersConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayVoicePassengersConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayVoicePassengersConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x001819AC File Offset: 0x0017FBAC
		public static IPlayVoicePassengersConfig Create([Nullable(2)] IPlayVoicePassengersConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayVoicePassengersConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x001819BF File Offset: 0x0017FBBF
		public static IPlayVoicePassengersConfig CreateFromSetValue([Nullable(2)] IPlayVoicePassengersConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayVoicePassengersConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x001819D2 File Offset: 0x0017FBD2
		public IPlayVoicePassengersConfig_SetValue ToSetValue()
		{
			return new IPlayVoicePassengersConfig_SetValue
			{
				Passengers = this.Passengers,
				MatchNone = this.MatchNone
			};
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600A9FD RID: 43517 RVA: 0x001819F1 File Offset: 0x0017FBF1
		// (set) Token: 0x0600A9FE RID: 43518 RVA: 0x00181A18 File Offset: 0x0017FC18
		public virtual List<int> Passengers
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Passengers;
				}
				IPlayVoicePassengersConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Passengers;
			}
			set
			{
				this.GetOrCreatePoco().Passengers = value;
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x00181A28 File Offset: 0x0017FC28
		// (set) Token: 0x0600AA00 RID: 43520 RVA: 0x00181A62 File Offset: 0x0017FC62
		public virtual bool? MatchNone
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MatchNone;
				}
				IPlayVoicePassengersConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MatchNone;
			}
			set
			{
				this.GetOrCreatePoco().MatchNone = value;
			}
		}

		// Token: 0x040065FF RID: 26111
		[Nullable(2)]
		protected IPlayVoicePassengersConfig FbInstance;

		// Token: 0x04006600 RID: 26112
		[Nullable(2)]
		protected IPlayVoicePassengersConfig_SetValue PocoInterface;
	}
}
