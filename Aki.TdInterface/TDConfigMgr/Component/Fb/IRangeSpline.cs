using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C57 RID: 3159
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeSpline : ISplineType
	{
		// Token: 0x06004863 RID: 18531 RVA: 0x000B5F35 File Offset: 0x000B4135
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

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x000B5F54 File Offset: 0x000B4154
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x000B5F61 File Offset: 0x000B4161
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x000B5F70 File Offset: 0x000B4170
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

		// Token: 0x04002940 RID: 10560
		private IRangeSpline Instance;

		// Token: 0x04002941 RID: 10561
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04002942 RID: 10562
		private bool _PointsInited;
	}
}
