using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200026C RID: 620
	public class ICircuitConnectCurveLayout : ICircuitConnectLayoutBase
	{
		// Token: 0x06000AEE RID: 2798 RVA: 0x0002D170 File Offset: 0x0002B370
		private ICircuitConnectCurveLayout_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircuitConnectCurveLayout 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircuitConnectCurveLayout_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircuitConnectCurveLayout_SetValue());
			}
			return result;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002D1A8 File Offset: 0x0002B3A8
		public static ICircuitConnectCurveLayout Create([Nullable(2)] ICircuitConnectCurveLayout instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectCurveLayout
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002D1BB File Offset: 0x0002B3BB
		public static ICircuitConnectCurveLayout CreateFromSetValue([Nullable(2)] ICircuitConnectCurveLayout_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircuitConnectCurveLayout
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002D1CE File Offset: 0x0002B3CE
		public new ICircuitConnectCurveLayout_SetValue ToSetValue()
		{
			return new ICircuitConnectCurveLayout_SetValue
			{
				Type = this.Type,
				Disk = this.Disk
			};
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0002D1ED File Offset: 0x0002B3ED
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x0002D218 File Offset: 0x0002B418
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0002D226 File Offset: 0x0002B426
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x0002D251 File Offset: 0x0002B451
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

		// Token: 0x04000AFB RID: 2811
		[Nullable(2)]
		protected new ICircuitConnectCurveLayout FbInstance;

		// Token: 0x04000AFC RID: 2812
		[Nullable(2)]
		protected new ICircuitConnectCurveLayout_SetValue PocoInterface;
	}
}
