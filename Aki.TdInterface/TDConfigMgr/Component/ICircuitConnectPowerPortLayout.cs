using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027A RID: 634
	public class ICircuitConnectPowerPortLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x0002DA20 File Offset: 0x0002BC20
		private ICircuitConnectPowerPortLayout_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectPowerPortLayout 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectPowerPortLayout_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectPowerPortLayout_SetValue());
			}
			return result;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0002DA58 File Offset: 0x0002BC58
		public static ICircuitConnectPowerPortLayout Create([Nullable(2)] ICircuitConnectPowerPortLayout instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectPowerPortLayout
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0002DA6B File Offset: 0x0002BC6B
		public static ICircuitConnectPowerPortLayout CreateFromSetValue([Nullable(2)] ICircuitConnectPowerPortLayout_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectPowerPortLayout
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0002DA7E File Offset: 0x0002BC7E
		public new ICircuitConnectPowerPortLayout_SetValue ToSetValue()
		{
			return new ICircuitConnectPowerPortLayout_SetValue
			{
				Type = this.Type,
				Disk = this.Disk
			};
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0002DA9D File Offset: 0x0002BC9D
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x0002DAC8 File Offset: 0x0002BCC8
		public override ECircuitConnectElementType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECircuitConnectElementType.Straight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0002DAD6 File Offset: 0x0002BCD6
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x0002DB01 File Offset: 0x0002BD01
		public virtual ETurntableConnectorDisk Disk
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disk;
				}
				if (this.PocoInterface == null)
				{
					return ETurntableConnectorDisk.Disk0;
				}
				return this.PocoInterface.Disk;
			}
			set
			{
				this.GetOrCreatePoco().Disk = value;
			}
		}

		// Token: 0x04000B20 RID: 2848
		[Nullable(2)]
		protected new ICircuitConnectPowerPortLayout FbInstance;

		// Token: 0x04000B21 RID: 2849
		[Nullable(2)]
		protected new ICircuitConnectPowerPortLayout_SetValue PocoInterface;
	}
}
