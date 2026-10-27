using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B46 RID: 6982
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEffect
	{
		// Token: 0x0600956B RID: 38251 RVA: 0x0015974C File Offset: 0x0015794C
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

		// Token: 0x0600956C RID: 38252 RVA: 0x00159784 File Offset: 0x00157984
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

		// Token: 0x0600956D RID: 38253 RVA: 0x00159797 File Offset: 0x00157997
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

		// Token: 0x0600956E RID: 38254 RVA: 0x001597AA File Offset: 0x001579AA
		public IInteractEffect_SetValue ToSetValue()
		{
			return new IInteractEffect_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x001597C9 File Offset: 0x001579C9
		// (set) Token: 0x06009570 RID: 38256 RVA: 0x001597F4 File Offset: 0x001579F4
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

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x06009571 RID: 38257 RVA: 0x00159804 File Offset: 0x00157A04
		// (set) Token: 0x06009572 RID: 38258 RVA: 0x0015983E File Offset: 0x00157A3E
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

		// Token: 0x04005B70 RID: 23408
		[Nullable(2)]
		protected IInteractEffect FbInstance;

		// Token: 0x04005B71 RID: 23409
		[Nullable(2)]
		protected IInteractEffect_SetValue PocoInterface;
	}
}
