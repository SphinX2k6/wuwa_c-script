using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AB RID: 9131
	public class RemoveEffect : ActionParams
	{
		// Token: 0x0600C724 RID: 50980 RVA: 0x001C81FC File Offset: 0x001C63FC
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

		// Token: 0x0600C725 RID: 50981 RVA: 0x001C8234 File Offset: 0x001C6434
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

		// Token: 0x0600C726 RID: 50982 RVA: 0x001C8247 File Offset: 0x001C6447
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

		// Token: 0x0600C727 RID: 50983 RVA: 0x001C825A File Offset: 0x001C645A
		public RemoveEffect_SetValue ToSetValue()
		{
			return new RemoveEffect_SetValue
			{
				RemoveEffectConfig = this.RemoveEffectConfig
			};
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600C728 RID: 50984 RVA: 0x001C8270 File Offset: 0x001C6470
		// (set) Token: 0x0600C729 RID: 50985 RVA: 0x001C82D1 File Offset: 0x001C64D1
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

		// Token: 0x0400765A RID: 30298
		[Nullable(2)]
		protected new RemoveEffect FbInstance;

		// Token: 0x0400765B RID: 30299
		[Nullable(2)]
		protected RemoveEffect_SetValue PocoInterface;

		// Token: 0x0400765C RID: 30300
		private IRemoveScreenEffect _RemoveEffectConfigCache;

		// Token: 0x0400765D RID: 30301
		private bool _RemoveEffectConfigInited;
	}
}
