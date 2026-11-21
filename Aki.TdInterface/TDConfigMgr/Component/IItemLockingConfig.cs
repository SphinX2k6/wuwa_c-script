using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F9 RID: 1273
	public class IItemLockingConfig
	{
		// Token: 0x06001974 RID: 6516 RVA: 0x0004B9FC File Offset: 0x00049BFC
		private IItemLockingConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemLockingConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemLockingConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemLockingConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0004BA34 File Offset: 0x00049C34
		public static IItemLockingConfig Create([Nullable(2)] IItemLockingConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemLockingConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0004BA47 File Offset: 0x00049C47
		public static IItemLockingConfig CreateFromSetValue([Nullable(2)] IItemLockingConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemLockingConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0004BA5A File Offset: 0x00049C5A
		public IItemLockingConfig_SetValue ToSetValue()
		{
			return new IItemLockingConfig_SetValue
			{
				EffectPath = this.EffectPath,
				TeleControlPerform = this.TeleControlPerform
			};
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0004BA79 File Offset: 0x00049C79
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0004BAA4 File Offset: 0x00049CA4
		public virtual string EffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectPath = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0004BAB4 File Offset: 0x00049CB4
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0004BAEE File Offset: 0x00049CEE
		public virtual ETeleControlLockingPerform? TeleControlPerform
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleControlPerform;
				}
				IItemLockingConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TeleControlPerform;
			}
			set
			{
				this.GetOrCreatePoco().TeleControlPerform = value;
			}
		}

		// Token: 0x040012E8 RID: 4840
		[Nullable(2)]
		protected IItemLockingConfig FbInstance;

		// Token: 0x040012E9 RID: 4841
		[Nullable(2)]
		protected IItemLockingConfig_SetValue PocoInterface;
	}
}
