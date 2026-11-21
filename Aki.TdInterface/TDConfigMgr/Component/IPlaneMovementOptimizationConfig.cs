using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200069F RID: 1695
	public class IPlaneMovementOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x060023E0 RID: 9184 RVA: 0x000622D8 File Offset: 0x000604D8
		private IPlaneMovementOptimizationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlaneMovementOptimizationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlaneMovementOptimizationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlaneMovementOptimizationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00062310 File Offset: 0x00060510
		public static IPlaneMovementOptimizationConfig Create([Nullable(2)] IPlaneMovementOptimizationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlaneMovementOptimizationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00062323 File Offset: 0x00060523
		public static IPlaneMovementOptimizationConfig CreateFromSetValue([Nullable(2)] IPlaneMovementOptimizationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlaneMovementOptimizationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00062336 File Offset: 0x00060536
		public new IPlaneMovementOptimizationConfig_SetValue ToSetValue()
		{
			return new IPlaneMovementOptimizationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x00062349 File Offset: 0x00060549
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x00062374 File Offset: 0x00060574
		public override EPerformanceOptimizationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPerformanceOptimizationType.PlaneMovementOptimization;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040018F9 RID: 6393
		[Nullable(2)]
		protected new IPlaneMovementOptimizationConfig FbInstance;

		// Token: 0x040018FA RID: 6394
		[Nullable(2)]
		protected new IPlaneMovementOptimizationConfig_SetValue PocoInterface;
	}
}
