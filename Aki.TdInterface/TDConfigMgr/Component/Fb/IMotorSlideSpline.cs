using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C64 RID: 3172
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSlideSpline : ISplineType
	{
		// Token: 0x060048B1 RID: 18609 RVA: 0x000B690F File Offset: 0x000B4B0F
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

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x000B692E File Offset: 0x000B4B2E
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x000B693B File Offset: 0x000B4B3B
		public virtual float RangeRadius
		{
			get
			{
				return this.Instance.RangeRadius;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x000B6948 File Offset: 0x000B4B48
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

		// Token: 0x04002971 RID: 10609
		private IMotorSlideSpline Instance;

		// Token: 0x04002972 RID: 10610
		private List<IMotorSlideSplinePoint> _PointsCache;

		// Token: 0x04002973 RID: 10611
		private bool _PointsInited;
	}
}
