using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEB RID: 3563
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerPollutionSplineConfig
	{
		// Token: 0x060050BB RID: 20667 RVA: 0x000C7442 File Offset: 0x000C5642
		public static IFlowerPollutionSplineConfig Create(IFlowerPollutionSplineConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerPollutionSplineConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x000C7464 File Offset: 0x000C5664
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this._SplineEntityIdsInited)
				{
					return this._SplineEntityIdsCache;
				}
				this._SplineEntityIdsInited = true;
				int splineEntityIdsLength = this.Instance.SplineEntityIdsLength;
				this._SplineEntityIdsCache = new List<int>(splineEntityIdsLength);
				for (int i = 0; i < splineEntityIdsLength; i++)
				{
					this._SplineEntityIdsCache.Add(this.Instance.SplineEntityIds(i));
				}
				return this._SplineEntityIdsCache;
			}
		}

		// Token: 0x04002E5A RID: 11866
		private IFlowerPollutionSplineConfig Instance;

		// Token: 0x04002E5B RID: 11867
		private List<int> _SplineEntityIdsCache;

		// Token: 0x04002E5C RID: 11868
		private bool _SplineEntityIdsInited;
	}
}
