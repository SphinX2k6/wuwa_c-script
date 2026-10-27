using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000748 RID: 1864
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemModuleDataSyncData
	{
		// Token: 0x06002841 RID: 10305 RVA: 0x0006AC60 File Offset: 0x00068E60
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

		// Token: 0x06002842 RID: 10306 RVA: 0x0006AC98 File Offset: 0x00068E98
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

		// Token: 0x06002843 RID: 10307 RVA: 0x0006ACAB File Offset: 0x00068EAB
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

		// Token: 0x06002844 RID: 10308 RVA: 0x0006ACBE File Offset: 0x00068EBE
		public ISystemModuleDataSyncData_SetValue ToSetValue()
		{
			return new ISystemModuleDataSyncData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x0006ACD1 File Offset: 0x00068ED1
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x0006ACFC File Offset: 0x00068EFC
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

		// Token: 0x04001B1E RID: 6942
		[Nullable(2)]
		protected ISystemModuleDataSyncData FbInstance;

		// Token: 0x04001B1F RID: 6943
		[Nullable(2)]
		protected ISystemModuleDataSyncData_SetValue PocoInterface;
	}
}
