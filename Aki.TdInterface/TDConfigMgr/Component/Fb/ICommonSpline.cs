using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C39 RID: 3129
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonSpline : ISplineType
	{
		// Token: 0x060047A5 RID: 18341 RVA: 0x000B4641 File Offset: 0x000B2841
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

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x000B4660 File Offset: 0x000B2860
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x000B4670 File Offset: 0x000B2870
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

		// Token: 0x040028BE RID: 10430
		private ICommonSpline Instance;

		// Token: 0x040028BF RID: 10431
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x040028C0 RID: 10432
		private bool _PointsInited;
	}
}
