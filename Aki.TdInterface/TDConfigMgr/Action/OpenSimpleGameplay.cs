using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020EE RID: 8430
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenSimpleGameplay : ActionParams
	{
		// Token: 0x0600B946 RID: 47430 RVA: 0x001AC580 File Offset: 0x001AA780
		[NullableContext(1)]
		private OpenSimpleGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenSimpleGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenSimpleGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenSimpleGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x001AC5B8 File Offset: 0x001AA7B8
		[NullableContext(1)]
		public static OpenSimpleGameplay Create([Nullable(2)] OpenSimpleGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSimpleGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x001AC5CB File Offset: 0x001AA7CB
		[NullableContext(1)]
		public static OpenSimpleGameplay CreateFromSetValue([Nullable(2)] OpenSimpleGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenSimpleGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x001AC5DE File Offset: 0x001AA7DE
		[NullableContext(1)]
		public OpenSimpleGameplay_SetValue ToSetValue()
		{
			return new OpenSimpleGameplay_SetValue
			{
				GameplayConfig = this.GameplayConfig,
				FinishSendSelfEvent = this.FinishSendSelfEvent,
				FailSendSelfEvent = this.FailSendSelfEvent
			};
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600B94A RID: 47434 RVA: 0x001AC609 File Offset: 0x001AA809
		// (set) Token: 0x0600B94B RID: 47435 RVA: 0x001AC630 File Offset: 0x001AA830
		[Nullable(1)]
		public virtual IUiGame GameplayConfig
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayConfig;
				}
				OpenSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GameplayConfig;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().GameplayConfig = value;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600B94C RID: 47436 RVA: 0x001AC63E File Offset: 0x001AA83E
		// (set) Token: 0x0600B94D RID: 47437 RVA: 0x001AC665 File Offset: 0x001AA865
		public virtual string FinishSendSelfEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishSendSelfEvent;
				}
				OpenSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishSendSelfEvent;
			}
			set
			{
				this.GetOrCreatePoco().FinishSendSelfEvent = value;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600B94E RID: 47438 RVA: 0x001AC673 File Offset: 0x001AA873
		// (set) Token: 0x0600B94F RID: 47439 RVA: 0x001AC69A File Offset: 0x001AA89A
		public virtual string FailSendSelfEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FailSendSelfEvent;
				}
				OpenSimpleGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FailSendSelfEvent;
			}
			set
			{
				this.GetOrCreatePoco().FailSendSelfEvent = value;
			}
		}

		// Token: 0x04006EF3 RID: 28403
		protected new OpenSimpleGameplay FbInstance;

		// Token: 0x04006EF4 RID: 28404
		protected OpenSimpleGameplay_SetValue PocoInterface;
	}
}
