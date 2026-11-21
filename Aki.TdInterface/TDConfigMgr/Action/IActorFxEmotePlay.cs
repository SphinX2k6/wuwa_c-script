using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EB RID: 6379
	public class IActorFxEmotePlay : IActorFxEmoteType
	{
		// Token: 0x060085D7 RID: 34263 RVA: 0x0013ED14 File Offset: 0x0013CF14
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

		// Token: 0x060085D8 RID: 34264 RVA: 0x0013ED4C File Offset: 0x0013CF4C
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

		// Token: 0x060085D9 RID: 34265 RVA: 0x0013ED5F File Offset: 0x0013CF5F
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

		// Token: 0x060085DA RID: 34266 RVA: 0x0013ED74 File Offset: 0x0013CF74
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

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x060085DB RID: 34267 RVA: 0x0013EDCE File Offset: 0x0013CFCE
		// (set) Token: 0x060085DC RID: 34268 RVA: 0x0013EDF9 File Offset: 0x0013CFF9
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

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x0013EE07 File Offset: 0x0013D007
		// (set) Token: 0x060085DE RID: 34270 RVA: 0x0013EE33 File Offset: 0x0013D033
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

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x0013EE44 File Offset: 0x0013D044
		// (set) Token: 0x060085E0 RID: 34272 RVA: 0x0013EEA5 File Offset: 0x0013D0A5
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

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x0013EEBC File Offset: 0x0013D0BC
		// (set) Token: 0x060085E2 RID: 34274 RVA: 0x0013EEF6 File Offset: 0x0013D0F6
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

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x0013EF04 File Offset: 0x0013D104
		// (set) Token: 0x060085E4 RID: 34276 RVA: 0x0013EF3E File Offset: 0x0013D13E
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

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x060085E5 RID: 34277 RVA: 0x0013EF4C File Offset: 0x0013D14C
		// (set) Token: 0x060085E6 RID: 34278 RVA: 0x0013EF86 File Offset: 0x0013D186
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

		// Token: 0x040054F8 RID: 21752
		[Nullable(2)]
		protected new IActorFxEmotePlay FbInstance;

		// Token: 0x040054F9 RID: 21753
		[Nullable(2)]
		protected new IActorFxEmotePlay_SetValue PocoInterface;

		// Token: 0x040054FA RID: 21754
		private IActorFxEmoteOverrideConfig _OverrideConfigCache;

		// Token: 0x040054FB RID: 21755
		private bool _OverrideConfigInited;
	}
}
