using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200176A RID: 5994
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmotePlay : IActorFxEmoteType
	{
		// Token: 0x06007EE7 RID: 32487 RVA: 0x0012FAB4 File Offset: 0x0012DCB4
		private IActorFxEmotePlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmotePlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmotePlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmotePlay_SetValue());
			}
			return result;
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x0012FAEC File Offset: 0x0012DCEC
		public static IActorFxEmotePlay Create([Nullable(2)] IActorFxEmotePlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmotePlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x0012FAFF File Offset: 0x0012DCFF
		public static IActorFxEmotePlay CreateFromSetValue([Nullable(2)] IActorFxEmotePlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmotePlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x0012FB14 File Offset: 0x0012DD14
		public new IActorFxEmotePlay_SetValue ToSetValue()
		{
			return new IActorFxEmotePlay_SetValue
			{
				Type = this.Type,
				FxEmoteId = this.FxEmoteId,
				OverrideConfig = this.OverrideConfig,
				DelayTime = this.DelayTime,
				LoopPlay = this.LoopPlay,
				KeepPlay = this.KeepPlay
			};
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x0012FB6E File Offset: 0x0012DD6E
		// (set) Token: 0x06007EEC RID: 32492 RVA: 0x0012FB99 File Offset: 0x0012DD99
		public override EActorFxEmoteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFxEmoteType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x06007EED RID: 32493 RVA: 0x0012FBA7 File Offset: 0x0012DDA7
		// (set) Token: 0x06007EEE RID: 32494 RVA: 0x0012FBD3 File Offset: 0x0012DDD3
		public virtual long FxEmoteId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FxEmoteId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.FxEmoteId;
			}
			set
			{
				this.GetOrCreatePoco().FxEmoteId = value;
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x06007EEF RID: 32495 RVA: 0x0012FBE4 File Offset: 0x0012DDE4
		// (set) Token: 0x06007EF0 RID: 32496 RVA: 0x0012FC45 File Offset: 0x0012DE45
		[Nullable(2)]
		public virtual IActorFxEmoteOverrideConfig OverrideConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._OverrideConfigInited)
				{
					return this._OverrideConfigCache;
				}
				this._OverrideConfigInited = true;
				if (this.FbInstance != null)
				{
					this._OverrideConfigCache = IActorFxEmoteOverrideConfig.Create(this.FbInstance.OverrideConfig);
				}
				else
				{
					IActorFxEmotePlay_SetValue pocoInterface = this.PocoInterface;
					this._OverrideConfigCache = ((pocoInterface != null) ? pocoInterface.OverrideConfig : null);
				}
				return this._OverrideConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OverrideConfig = value;
				this._OverrideConfigInited = false;
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x06007EF1 RID: 32497 RVA: 0x0012FC5C File Offset: 0x0012DE5C
		// (set) Token: 0x06007EF2 RID: 32498 RVA: 0x0012FC96 File Offset: 0x0012DE96
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorFxEmotePlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x0012FCA4 File Offset: 0x0012DEA4
		// (set) Token: 0x06007EF4 RID: 32500 RVA: 0x0012FCDE File Offset: 0x0012DEDE
		public virtual bool? LoopPlay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopPlay;
				}
				IActorFxEmotePlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopPlay;
			}
			set
			{
				this.GetOrCreatePoco().LoopPlay = value;
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x0012FCEC File Offset: 0x0012DEEC
		// (set) Token: 0x06007EF6 RID: 32502 RVA: 0x0012FD26 File Offset: 0x0012DF26
		public virtual bool? KeepPlay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPlay;
				}
				IActorFxEmotePlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPlay;
			}
			set
			{
				this.GetOrCreatePoco().KeepPlay = value;
			}
		}

		// Token: 0x040050C2 RID: 20674
		[Nullable(2)]
		protected new IActorFxEmotePlay FbInstance;

		// Token: 0x040050C3 RID: 20675
		[Nullable(2)]
		protected new IActorFxEmotePlay_SetValue PocoInterface;

		// Token: 0x040050C4 RID: 20676
		private IActorFxEmoteOverrideConfig _OverrideConfigCache;

		// Token: 0x040050C5 RID: 20677
		private bool _OverrideConfigInited;
	}
}
