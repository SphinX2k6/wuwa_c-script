using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA1 RID: 3745
	public class PerformanceOptimizationComponent : IComponentBase
	{
		// Token: 0x06005486 RID: 21638 RVA: 0x000D02DE File Offset: 0x000CE4DE
		public static PerformanceOptimizationComponent Create(IPerformanceOptimizationComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformanceOptimizationComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x000D0300 File Offset: 0x000CE500
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x000D0338 File Offset: 0x000CE538
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x000D034E File Offset: 0x000CE54E
		public virtual List<IPerformanceOptimization> PerformanceOptimizationList
		{
			get
			{
				if (this._PerformanceOptimizationListInited)
				{
					return this._PerformanceOptimizationListCache;
				}
				this._PerformanceOptimizationListInited = true;
				this._PerformanceOptimizationListCache = ComponentReadHelper.ReadPerformanceOptimizationComponent_PerformanceOptimizationList(this.Instance);
				return this._PerformanceOptimizationListCache;
			}
		}

		// Token: 0x04003052 RID: 12370
		private IPerformanceOptimizationComponent Instance;

		// Token: 0x04003053 RID: 12371
		private List<IPerformanceOptimization> _PerformanceOptimizationListCache;

		// Token: 0x04003054 RID: 12372
		private bool _PerformanceOptimizationListInited;
	}
}
