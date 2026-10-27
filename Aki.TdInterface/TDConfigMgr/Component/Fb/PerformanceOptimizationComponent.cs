using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA5 RID: 3493
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformanceOptimizationComponent : IComponentBase
	{
		// Token: 0x06004F61 RID: 20321 RVA: 0x000C4A8E File Offset: 0x000C2C8E
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

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06004F62 RID: 20322 RVA: 0x000C4AB0 File Offset: 0x000C2CB0
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

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x000C4AE8 File Offset: 0x000C2CE8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x000C4AFE File Offset: 0x000C2CFE
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

		// Token: 0x04002D8C RID: 11660
		private IPerformanceOptimizationComponent Instance;

		// Token: 0x04002D8D RID: 11661
		private List<IPerformanceOptimization> _PerformanceOptimizationListCache;

		// Token: 0x04002D8E RID: 11662
		private bool _PerformanceOptimizationListInited;
	}
}
