using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A0 RID: 1184
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemLockingConfig
	{
		// Token: 0x060017DA RID: 6106 RVA: 0x00047CB4 File Offset: 0x00045EB4
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

		// Token: 0x060017DB RID: 6107 RVA: 0x00047CEC File Offset: 0x00045EEC
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

		// Token: 0x060017DC RID: 6108 RVA: 0x00047CFF File Offset: 0x00045EFF
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

		// Token: 0x060017DD RID: 6109 RVA: 0x00047D12 File Offset: 0x00045F12
		public IItemLockingConfig_SetValue ToSetValue()
		{
			return new IItemLockingConfig_SetValue
			{
				EffectPath = this.EffectPath,
				TeleControlPerform = this.TeleControlPerform
			};
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00047D31 File Offset: 0x00045F31
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x00047D5C File Offset: 0x00045F5C
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00047D6C File Offset: 0x00045F6C
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00047DA6 File Offset: 0x00045FA6
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

		// Token: 0x040011C6 RID: 4550
		[Nullable(2)]
		protected IItemLockingConfig FbInstance;

		// Token: 0x040011C7 RID: 4551
		[Nullable(2)]
		protected IItemLockingConfig_SetValue PocoInterface;
	}
}
