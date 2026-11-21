using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F2 RID: 2290
	public class PerformanceOptimizationComponent : IComponentBase
	{
		// Token: 0x06003221 RID: 12833 RVA: 0x00080858 File Offset: 0x0007EA58
		private PerformanceOptimizationComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PerformanceOptimizationComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PerformanceOptimizationComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PerformanceOptimizationComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00080890 File Offset: 0x0007EA90
		public static PerformanceOptimizationComponent Create([Nullable(2)] PerformanceOptimizationComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformanceOptimizationComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000808A3 File Offset: 0x0007EAA3
		public static PerformanceOptimizationComponent CreateFromSetValue([Nullable(2)] PerformanceOptimizationComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PerformanceOptimizationComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000808B6 File Offset: 0x0007EAB6
		public new PerformanceOptimizationComponent_SetValue ToSetValue()
		{
			return new PerformanceOptimizationComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PerformanceOptimizationList = this.PerformanceOptimizationList
			};
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x000808E4 File Offset: 0x0007EAE4
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x0008091E File Offset: 0x0007EB1E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				PerformanceOptimizationComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x0008092C File Offset: 0x0007EB2C
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x00080956 File Offset: 0x0007EB56
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x00080964 File Offset: 0x0007EB64
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x0008098B File Offset: 0x0007EB8B
		public virtual List<IPerformanceOptimization> PerformanceOptimizationList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceOptimizationList;
				}
				PerformanceOptimizationComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformanceOptimizationList;
			}
			set
			{
				this.GetOrCreatePoco().PerformanceOptimizationList = value;
			}
		}

		// Token: 0x04002111 RID: 8465
		[Nullable(2)]
		protected new PerformanceOptimizationComponent FbInstance;

		// Token: 0x04002112 RID: 8466
		[Nullable(2)]
		protected new PerformanceOptimizationComponent_SetValue PocoInterface;
	}
}
