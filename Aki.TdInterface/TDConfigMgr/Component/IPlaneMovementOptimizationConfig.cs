using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000602 RID: 1538
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlaneMovementOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x060020DA RID: 8410 RVA: 0x0005B5C4 File Offset: 0x000597C4
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

		// Token: 0x060020DB RID: 8411 RVA: 0x0005B5FC File Offset: 0x000597FC
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

		// Token: 0x060020DC RID: 8412 RVA: 0x0005B60F File Offset: 0x0005980F
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

		// Token: 0x060020DD RID: 8413 RVA: 0x0005B622 File Offset: 0x00059822
		public new IPlaneMovementOptimizationConfig_SetValue ToSetValue()
		{
			return new IPlaneMovementOptimizationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0005B635 File Offset: 0x00059835
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0005B660 File Offset: 0x00059860
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

		// Token: 0x04001707 RID: 5895
		[Nullable(2)]
		protected new IPlaneMovementOptimizationConfig FbInstance;

		// Token: 0x04001708 RID: 5896
		[Nullable(2)]
		protected new IPlaneMovementOptimizationConfig_SetValue PocoInterface;
	}
}
