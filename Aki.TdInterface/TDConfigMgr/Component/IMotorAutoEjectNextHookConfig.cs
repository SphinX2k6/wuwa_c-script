using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000585 RID: 1413
	public class IMotorAutoEjectNextHookConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06001C84 RID: 7300 RVA: 0x000520AC File Offset: 0x000502AC
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

		// Token: 0x06001C85 RID: 7301 RVA: 0x000520E4 File Offset: 0x000502E4
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

		// Token: 0x06001C86 RID: 7302 RVA: 0x000520F7 File Offset: 0x000502F7
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

		// Token: 0x06001C87 RID: 7303 RVA: 0x0005210A File Offset: 0x0005030A
		public new IMotorAutoEjectNextHookConfig_SetValue ToSetValue()
		{
			return new IMotorAutoEjectNextHookConfig_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00052129 File Offset: 0x00050329
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00052154 File Offset: 0x00050354
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00052162 File Offset: 0x00050362
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x0005218D File Offset: 0x0005038D
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

		// Token: 0x0400149A RID: 5274
		[Nullable(2)]
		protected new IMotorAutoEjectNextHookConfig FbInstance;

		// Token: 0x0400149B RID: 5275
		[Nullable(2)]
		protected new IMotorAutoEjectNextHookConfig_SetValue PocoInterface;
	}
}
