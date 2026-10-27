using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214A RID: 8522
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveEffect : ActionParams
	{
		// Token: 0x0600BB96 RID: 48022 RVA: 0x001B1048 File Offset: 0x001AF248
		private RemoveEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x001B1080 File Offset: 0x001AF280
		public static RemoveEffect Create([Nullable(2)] RemoveEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x001B1093 File Offset: 0x001AF293
		public static RemoveEffect CreateFromSetValue([Nullable(2)] RemoveEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x001B10A6 File Offset: 0x001AF2A6
		public RemoveEffect_SetValue ToSetValue()
		{
			return new RemoveEffect_SetValue
			{
				RemoveEffectConfig = this.RemoveEffectConfig
			};
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x001B10BC File Offset: 0x001AF2BC
		// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x001B111D File Offset: 0x001AF31D
		public virtual IRemoveScreenEffect RemoveEffectConfig
		{
			get
			{
				if (this._RemoveEffectConfigInited)
				{
					return this._RemoveEffectConfigCache;
				}
				this._RemoveEffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RemoveEffectConfigCache = IRemoveScreenEffect.Create(this.FbInstance.RemoveEffectConfig);
				}
				else
				{
					RemoveEffect_SetValue pocoInterface = this.PocoInterface;
					this._RemoveEffectConfigCache = ((pocoInterface != null) ? pocoInterface.RemoveEffectConfig : null);
				}
				return this._RemoveEffectConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RemoveEffectConfig = value;
				this._RemoveEffectConfigInited = false;
			}
		}

		// Token: 0x04007025 RID: 28709
		[Nullable(2)]
		protected new RemoveEffect FbInstance;

		// Token: 0x04007026 RID: 28710
		[Nullable(2)]
		protected RemoveEffect_SetValue PocoInterface;

		// Token: 0x04007027 RID: 28711
		private IRemoveScreenEffect _RemoveEffectConfigCache;

		// Token: 0x04007028 RID: 28712
		private bool _RemoveEffectConfigInited;
	}
}
