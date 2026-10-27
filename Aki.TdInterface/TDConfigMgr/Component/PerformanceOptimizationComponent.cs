using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084F RID: 2127
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformanceOptimizationComponent : IComponentBase
	{
		// Token: 0x06002EE5 RID: 12005 RVA: 0x00079370 File Offset: 0x00077570
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

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000793A8 File Offset: 0x000775A8
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

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000793BB File Offset: 0x000775BB
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000793CE File Offset: 0x000775CE
		public new PerformanceOptimizationComponent_SetValue ToSetValue()
		{
			return new PerformanceOptimizationComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				PerformanceOptimizationList = this.PerformanceOptimizationList
			};
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000793FC File Offset: 0x000775FC
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00079436 File Offset: 0x00077636
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x00079444 File Offset: 0x00077644
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x0007946E File Offset: 0x0007766E
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

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x0007947C File Offset: 0x0007767C
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x000794A3 File Offset: 0x000776A3
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

		// Token: 0x04001EFF RID: 7935
		[Nullable(2)]
		protected new PerformanceOptimizationComponent FbInstance;

		// Token: 0x04001F00 RID: 7936
		[Nullable(2)]
		protected new PerformanceOptimizationComponent_SetValue PocoInterface;
	}
}
