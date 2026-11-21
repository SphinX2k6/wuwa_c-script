using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E9 RID: 2025
	public class ISystemModuleDataSyncData
	{
		// Token: 0x06002B65 RID: 11109 RVA: 0x00071E08 File Offset: 0x00070008
		private ISystemModuleDataSyncData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISystemModuleDataSyncData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISystemModuleDataSyncData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISystemModuleDataSyncData_SetValue());
			}
			return result;
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00071E40 File Offset: 0x00070040
		public static ISystemModuleDataSyncData Create([Nullable(2)] ISystemModuleDataSyncData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemModuleDataSyncData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00071E53 File Offset: 0x00070053
		public static ISystemModuleDataSyncData CreateFromSetValue([Nullable(2)] ISystemModuleDataSyncData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISystemModuleDataSyncData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00071E66 File Offset: 0x00070066
		public ISystemModuleDataSyncData_SetValue ToSetValue()
		{
			return new ISystemModuleDataSyncData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x00071E79 File Offset: 0x00070079
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x00071EA4 File Offset: 0x000700A4
		public virtual ESyncDataSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESyncDataSystemType.MotorRacing;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001D23 RID: 7459
		[Nullable(2)]
		protected ISystemModuleDataSyncData FbInstance;

		// Token: 0x04001D24 RID: 7460
		[Nullable(2)]
		protected ISystemModuleDataSyncData_SetValue PocoInterface;
	}
}
