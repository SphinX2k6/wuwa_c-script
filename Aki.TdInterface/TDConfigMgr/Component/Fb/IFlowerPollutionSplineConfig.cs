using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE7 RID: 3815
	public class IFlowerPollutionSplineConfig
	{
		// Token: 0x060055E2 RID: 21986 RVA: 0x000D2D0A File Offset: 0x000D0F0A
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

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x060055E3 RID: 21987 RVA: 0x000D2D2C File Offset: 0x000D0F2C
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

		// Token: 0x04003122 RID: 12578
		private IFlowerPollutionSplineConfig Instance;

		// Token: 0x04003123 RID: 12579
		private List<int> _SplineEntityIdsCache;

		// Token: 0x04003124 RID: 12580
		private bool _SplineEntityIdsInited;
	}
}
