using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D30 RID: 3376
	public class IRangeSpline : ISplineType
	{
		// Token: 0x06004CE8 RID: 19688 RVA: 0x000C0529 File Offset: 0x000BE729
		public static IRangeSpline Create(IRangeSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x000C0548 File Offset: 0x000BE748
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x000C0555 File Offset: 0x000BE755
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x000C0564 File Offset: 0x000BE764
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

		// Token: 0x04002BA1 RID: 11169
		private IRangeSpline Instance;

		// Token: 0x04002BA2 RID: 11170
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04002BA3 RID: 11171
		private bool _PointsInited;
	}
}
