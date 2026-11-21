using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027C RID: 636
	public class ICircuitConnectStraightLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x0002DB20 File Offset: 0x0002BD20
		private ICircuitConnectStraightLayout_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectStraightLayout 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectStraightLayout_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectStraightLayout_SetValue());
			}
			return result;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002DB58 File Offset: 0x0002BD58
		public static ICircuitConnectStraightLayout Create([Nullable(2)] ICircuitConnectStraightLayout instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectStraightLayout
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002DB6B File Offset: 0x0002BD6B
		public static ICircuitConnectStraightLayout CreateFromSetValue([Nullable(2)] ICircuitConnectStraightLayout_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectStraightLayout
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002DB7E File Offset: 0x0002BD7E
		public new ICircuitConnectStraightLayout_SetValue ToSetValue()
		{
			return new ICircuitConnectStraightLayout_SetValue
			{
				Type = this.Type,
				Disk = this.Disk
			};
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0002DB9D File Offset: 0x0002BD9D
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0002DBC8 File Offset: 0x0002BDC8
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0002DBD6 File Offset: 0x0002BDD6
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x0002DC01 File Offset: 0x0002BE01
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

		// Token: 0x04000B24 RID: 2852
		[Nullable(2)]
		protected new ICircuitConnectStraightLayout FbInstance;

		// Token: 0x04000B25 RID: 2853
		[Nullable(2)]
		protected new ICircuitConnectStraightLayout_SetValue PocoInterface;
	}
}
