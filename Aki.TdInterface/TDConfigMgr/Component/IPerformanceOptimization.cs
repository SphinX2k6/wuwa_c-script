using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F0 RID: 1520
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformanceOptimization
	{
		// Token: 0x0600204C RID: 8268 RVA: 0x0005A0AC File Offset: 0x000582AC
		private IPerformanceOptimization_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformanceOptimization 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformanceOptimization_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformanceOptimization_SetValue());
			}
			return result;
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0005A0E4 File Offset: 0x000582E4
		public static IPerformanceOptimization Create([Nullable(2)] IPerformanceOptimization instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformanceOptimization
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0005A0F7 File Offset: 0x000582F7
		public static IPerformanceOptimization CreateFromSetValue([Nullable(2)] IPerformanceOptimization_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformanceOptimization
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0005A10A File Offset: 0x0005830A
		public IPerformanceOptimization_SetValue ToSetValue()
		{
			return new IPerformanceOptimization_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0005A11D File Offset: 0x0005831D
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x0005A148 File Offset: 0x00058348
		public virtual EPerformanceOptimizationType Type
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

		// Token: 0x040016AF RID: 5807
		[Nullable(2)]
		protected IPerformanceOptimization FbInstance;

		// Token: 0x040016B0 RID: 5808
		[Nullable(2)]
		protected IPerformanceOptimization_SetValue PocoInterface;
	}
}
