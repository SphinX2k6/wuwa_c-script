using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000583 RID: 1411
	public class IMotorAutoEjectConfigBase
	{
		// Token: 0x06001C7C RID: 7292 RVA: 0x00051FF0 File Offset: 0x000501F0
		private IMotorAutoEjectConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorAutoEjectConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorAutoEjectConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorAutoEjectConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00052028 File Offset: 0x00050228
		public static IMotorAutoEjectConfigBase Create([Nullable(2)] IMotorAutoEjectConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0005203B File Offset: 0x0005023B
		public static IMotorAutoEjectConfigBase CreateFromSetValue([Nullable(2)] IMotorAutoEjectConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorAutoEjectConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0005204E File Offset: 0x0005024E
		public IMotorAutoEjectConfigBase_SetValue ToSetValue()
		{
			return new IMotorAutoEjectConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00052061 File Offset: 0x00050261
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0005208C File Offset: 0x0005028C
		public virtual EMotorAutoEjectType Type
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

		// Token: 0x04001497 RID: 5271
		[Nullable(2)]
		protected IMotorAutoEjectConfigBase FbInstance;

		// Token: 0x04001498 RID: 5272
		[Nullable(2)]
		protected IMotorAutoEjectConfigBase_SetValue PocoInterface;
	}
}
