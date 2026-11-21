using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3D RID: 3389
	public class IMotorSlideSpline : ISplineType
	{
		// Token: 0x06004D36 RID: 19766 RVA: 0x000C0F03 File Offset: 0x000BF103
		public static IMotorSlideSpline Create(IMotorSlideSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSlideSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x000C0F22 File Offset: 0x000BF122
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x000C0F2F File Offset: 0x000BF12F
		public virtual float RangeRadius
		{
			get
			{
				return this.Instance.RangeRadius;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x000C0F3C File Offset: 0x000BF13C
		public virtual List<IMotorSlideSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<IMotorSlideSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(IMotorSlideSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x04002BD2 RID: 11218
		private IMotorSlideSpline Instance;

		// Token: 0x04002BD3 RID: 11219
		private List<IMotorSlideSplinePoint> _PointsCache;

		// Token: 0x04002BD4 RID: 11220
		private bool _PointsInited;
	}
}
