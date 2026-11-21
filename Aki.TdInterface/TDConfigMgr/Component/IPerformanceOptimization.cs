using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200068D RID: 1677
	public class IPerformanceOptimization
	{
		// Token: 0x0600234E RID: 9038 RVA: 0x00060D28 File Offset: 0x0005EF28
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

		// Token: 0x0600234F RID: 9039 RVA: 0x00060D60 File Offset: 0x0005EF60
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

		// Token: 0x06002350 RID: 9040 RVA: 0x00060D73 File Offset: 0x0005EF73
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

		// Token: 0x06002351 RID: 9041 RVA: 0x00060D86 File Offset: 0x0005EF86
		public IPerformanceOptimization_SetValue ToSetValue()
		{
			return new IPerformanceOptimization_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x00060D99 File Offset: 0x0005EF99
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x00060DC4 File Offset: 0x0005EFC4
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

		// Token: 0x0400189F RID: 6303
		[Nullable(2)]
		protected IPerformanceOptimization FbInstance;

		// Token: 0x040018A0 RID: 6304
		[Nullable(2)]
		protected IPerformanceOptimization_SetValue PocoInterface;
	}
}
