using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0C RID: 3340
	public class ICommonSpline : ISplineType
	{
		// Token: 0x06004C15 RID: 19477 RVA: 0x000BE9F1 File Offset: 0x000BCBF1
		public static ICommonSpline Create(ICommonSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06004C16 RID: 19478 RVA: 0x000BEA10 File Offset: 0x000BCC10
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x000BEA20 File Offset: 0x000BCC20
		public virtual List<ICommonSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<ICommonSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(ICommonSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x04002B13 RID: 11027
		private ICommonSpline Instance;

		// Token: 0x04002B14 RID: 11028
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04002B15 RID: 11029
		private bool _PointsInited;
	}
}
