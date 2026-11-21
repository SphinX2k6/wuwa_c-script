using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D14 RID: 3348
	public class IButterflySpline : ISplineType
	{
		// Token: 0x06004C48 RID: 19528 RVA: 0x000BF06B File Offset: 0x000BD26B
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

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x000BF08A File Offset: 0x000BD28A
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x000BF098 File Offset: 0x000BD298
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

		// Token: 0x04002B39 RID: 11065
		private IButterflySpline Instance;

		// Token: 0x04002B3A RID: 11066
		private List<IButterflySplinePoint> _PointsCache;

		// Token: 0x04002B3B RID: 11067
		private bool _PointsInited;
	}
}
