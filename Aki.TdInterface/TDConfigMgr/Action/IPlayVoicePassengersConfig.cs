using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D22 RID: 7458
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayVoicePassengersConfig
	{
		// Token: 0x0600A00D RID: 40973 RVA: 0x0016D550 File Offset: 0x0016B750
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

		// Token: 0x0600A00E RID: 40974 RVA: 0x0016D588 File Offset: 0x0016B788
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

		// Token: 0x0600A00F RID: 40975 RVA: 0x0016D59B File Offset: 0x0016B79B
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

		// Token: 0x0600A010 RID: 40976 RVA: 0x0016D5AE File Offset: 0x0016B7AE
		public IPlayVoicePassengersConfig_SetValue ToSetValue()
		{
			return new IPlayVoicePassengersConfig_SetValue
			{
				Passengers = this.Passengers,
				MatchNone = this.MatchNone
			};
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600A011 RID: 40977 RVA: 0x0016D5CD File Offset: 0x0016B7CD
		// (set) Token: 0x0600A012 RID: 40978 RVA: 0x0016D5F4 File Offset: 0x0016B7F4
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

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600A013 RID: 40979 RVA: 0x0016D604 File Offset: 0x0016B804
		// (set) Token: 0x0600A014 RID: 40980 RVA: 0x0016D63E File Offset: 0x0016B83E
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

		// Token: 0x04006083 RID: 24707
		[Nullable(2)]
		protected IPlayVoicePassengersConfig FbInstance;

		// Token: 0x04006084 RID: 24708
		[Nullable(2)]
		protected IPlayVoicePassengersConfig_SetValue PocoInterface;
	}
}
