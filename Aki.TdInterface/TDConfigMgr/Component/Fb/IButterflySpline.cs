using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C41 RID: 3137
	[NullableContext(1)]
	[Nullable(0)]
	public class IButterflySpline : ISplineType
	{
		// Token: 0x060047D8 RID: 18392 RVA: 0x000B4CBB File Offset: 0x000B2EBB
		public static IButterflySpline Create(IButterflySpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IButterflySpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x000B4CDA File Offset: 0x000B2EDA
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x000B4CE8 File Offset: 0x000B2EE8
		public virtual List<IButterflySplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<IButterflySplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(IButterflySplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x040028E4 RID: 10468
		private IButterflySpline Instance;

		// Token: 0x040028E5 RID: 10469
		private List<IButterflySplinePoint> _PointsCache;

		// Token: 0x040028E6 RID: 10470
		private bool _PointsInited;
	}
}
