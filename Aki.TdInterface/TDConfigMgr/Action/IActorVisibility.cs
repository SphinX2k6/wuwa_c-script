using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001923 RID: 6435
	public class IActorVisibility
	{
		// Token: 0x060086F9 RID: 34553 RVA: 0x00140DC0 File Offset: 0x0013EFC0
		private IActorVisibility_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorVisibility 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorVisibility_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorVisibility_SetValue());
			}
			return result;
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x00140DF8 File Offset: 0x0013EFF8
		public static IActorVisibility Create([Nullable(2)] IActorVisibility instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibility
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x00140E0B File Offset: 0x0013F00B
		public static IActorVisibility CreateFromSetValue([Nullable(2)] IActorVisibility_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorVisibility
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x00140E20 File Offset: 0x0013F020
		public IActorVisibility_SetValue ToSetValue()
		{
			return new IActorVisibility_SetValue
			{
				ActorIndex = this.ActorIndex,
				PlayMode = this.PlayMode,
				Effect = this.Effect,
				FadeDuration = this.FadeDuration,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x060086FD RID: 34557 RVA: 0x00140E6E File Offset: 0x0013F06E
		// (set) Token: 0x060086FE RID: 34558 RVA: 0x00140E99 File Offset: 0x0013F099
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x060086FF RID: 34559 RVA: 0x00140EA7 File Offset: 0x0013F0A7
		// (set) Token: 0x06008700 RID: 34560 RVA: 0x00140ED2 File Offset: 0x0013F0D2
		public virtual EActorVisibilityPlayMode PlayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayMode;
				}
				if (this.PocoInterface == null)
				{
					return EActorVisibilityPlayMode.FadeIn;
				}
				return this.PocoInterface.PlayMode;
			}
			set
			{
				this.GetOrCreatePoco().PlayMode = value;
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06008701 RID: 34561 RVA: 0x00140EE0 File Offset: 0x0013F0E0
		// (set) Token: 0x06008702 RID: 34562 RVA: 0x00140F41 File Offset: 0x0013F141
		public virtual IActorVisibilityEffectDefault Effect
		{
			get
			{
				if (this._EffectInited)
				{
					return this._EffectCache;
				}
				this._EffectInited = true;
				if (this.FbInstance != null)
				{
					this._EffectCache = IActorVisibilityEffectDefault.Create(this.FbInstance.Effect);
				}
				else
				{
					IActorVisibility_SetValue pocoInterface = this.PocoInterface;
					this._EffectCache = ((pocoInterface != null) ? pocoInterface.Effect : null);
				}
				return this._EffectCache;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
				this._EffectInited = false;
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06008703 RID: 34563 RVA: 0x00140F58 File Offset: 0x0013F158
		// (set) Token: 0x06008704 RID: 34564 RVA: 0x00140F92 File Offset: 0x0013F192
		public virtual float? FadeDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeDuration;
				}
				IActorVisibility_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeDuration;
			}
			set
			{
				this.GetOrCreatePoco().FadeDuration = value;
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06008705 RID: 34565 RVA: 0x00140FA0 File Offset: 0x0013F1A0
		// (set) Token: 0x06008706 RID: 34566 RVA: 0x00140FDA File Offset: 0x0013F1DA
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorVisibility_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400557F RID: 21887
		[Nullable(2)]
		protected IActorVisibility FbInstance;

		// Token: 0x04005580 RID: 21888
		[Nullable(2)]
		protected IActorVisibility_SetValue PocoInterface;

		// Token: 0x04005581 RID: 21889
		private IActorVisibilityEffectDefault _EffectCache;

		// Token: 0x04005582 RID: 21890
		private bool _EffectInited;
	}
}
