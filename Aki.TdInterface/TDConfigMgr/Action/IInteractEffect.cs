using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF5 RID: 7413
	public class IInteractEffect
	{
		// Token: 0x06009D55 RID: 40277 RVA: 0x0016A428 File Offset: 0x00168628
		private IInteractEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x0016A460 File Offset: 0x00168660
		public static IInteractEffect Create([Nullable(2)] IInteractEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x0016A473 File Offset: 0x00168673
		public static IInteractEffect CreateFromSetValue([Nullable(2)] IInteractEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x0016A486 File Offset: 0x00168686
		public IInteractEffect_SetValue ToSetValue()
		{
			return new IInteractEffect_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x06009D59 RID: 40281 RVA: 0x0016A4A5 File Offset: 0x001686A5
		// (set) Token: 0x06009D5A RID: 40282 RVA: 0x0016A4D0 File Offset: 0x001686D0
		public virtual EInteractEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x06009D5B RID: 40283 RVA: 0x0016A4E0 File Offset: 0x001686E0
		// (set) Token: 0x06009D5C RID: 40284 RVA: 0x0016A51A File Offset: 0x0016871A
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IInteractEffect_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400600E RID: 24590
		[Nullable(2)]
		protected IInteractEffect FbInstance;

		// Token: 0x0400600F RID: 24591
		[Nullable(2)]
		protected IInteractEffect_SetValue PocoInterface;
	}
}
