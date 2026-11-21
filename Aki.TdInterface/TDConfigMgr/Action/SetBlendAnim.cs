using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240E RID: 9230
	public class SetBlendAnim : ActionParams
	{
		// Token: 0x0600C8D0 RID: 51408 RVA: 0x001CAF40 File Offset: 0x001C9140
		private SetBlendAnim_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetBlendAnim 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetBlendAnim_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetBlendAnim_SetValue());
			}
			return result;
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x001CAF78 File Offset: 0x001C9178
		public static SetBlendAnim Create([Nullable(2)] SetBlendAnim instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBlendAnim
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x001CAF8B File Offset: 0x001C918B
		public static SetBlendAnim CreateFromSetValue([Nullable(2)] SetBlendAnim_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetBlendAnim
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C8D3 RID: 51411 RVA: 0x001CAF9E File Offset: 0x001C919E
		public SetBlendAnim_SetValue ToSetValue()
		{
			return new SetBlendAnim_SetValue
			{
				Target = this.Target,
				BlendType = this.BlendType
			};
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600C8D4 RID: 51412 RVA: 0x001CAFC0 File Offset: 0x001C91C0
		// (set) Token: 0x0600C8D5 RID: 51413 RVA: 0x001CB021 File Offset: 0x001C9221
		public virtual IPlayerBlendAnimTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCache = IPlayerBlendAnimTarget.Create(this.FbInstance.Target);
				}
				else
				{
					SetBlendAnim_SetValue pocoInterface = this.PocoInterface;
					this._TargetCache = ((pocoInterface != null) ? pocoInterface.Target : null);
				}
				return this._TargetCache;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
				this._TargetInited = false;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600C8D6 RID: 51414 RVA: 0x001CB036 File Offset: 0x001C9236
		// (set) Token: 0x0600C8D7 RID: 51415 RVA: 0x001CB05D File Offset: 0x001C925D
		public virtual IBlendAnimTypeBase BlendType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlendType;
				}
				SetBlendAnim_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlendType;
			}
			set
			{
				this.GetOrCreatePoco().BlendType = value;
			}
		}

		// Token: 0x04007720 RID: 30496
		[Nullable(2)]
		protected new SetBlendAnim FbInstance;

		// Token: 0x04007721 RID: 30497
		[Nullable(2)]
		protected SetBlendAnim_SetValue PocoInterface;

		// Token: 0x04007722 RID: 30498
		private IPlayerBlendAnimTarget _TargetCache;

		// Token: 0x04007723 RID: 30499
		private bool _TargetInited;
	}
}
