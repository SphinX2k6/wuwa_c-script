using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051E RID: 1310
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorAutoEjectNextHookConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
		private IMotorAutoEjectNextHookConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorAutoEjectNextHookConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorAutoEjectNextHookConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorAutoEjectNextHookConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0004D328 File Offset: 0x0004B528
		public static IMotorAutoEjectNextHookConfig Create([Nullable(2)] IMotorAutoEjectNextHookConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectNextHookConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0004D33B File Offset: 0x0004B53B
		public static IMotorAutoEjectNextHookConfig CreateFromSetValue([Nullable(2)] IMotorAutoEjectNextHookConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorAutoEjectNextHookConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0004D34E File Offset: 0x0004B54E
		public new IMotorAutoEjectNextHookConfig_SetValue ToSetValue()
		{
			return new IMotorAutoEjectNextHookConfig_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0004D36D File Offset: 0x0004B56D
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0004D398 File Offset: 0x0004B598
		public override EMotorAutoEjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorAutoEjectType.NextHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0004D3A6 File Offset: 0x0004B5A6
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0004D3D1 File Offset: 0x0004B5D1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04001330 RID: 4912
		[Nullable(2)]
		protected new IMotorAutoEjectNextHookConfig FbInstance;

		// Token: 0x04001331 RID: 4913
		[Nullable(2)]
		protected new IMotorAutoEjectNextHookConfig_SetValue PocoInterface;
	}
}
