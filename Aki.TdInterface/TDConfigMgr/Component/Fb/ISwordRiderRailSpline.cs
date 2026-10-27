using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C66 RID: 3174
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwordRiderRailSpline : ISplineType
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x000B6B2E File Offset: 0x000B4D2E
		public static ISwordRiderRailSpline Create(ISwordRiderRailSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwordRiderRailSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x000B6B4D File Offset: 0x000B4D4D
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x000B6B5A File Offset: 0x000B4D5A
		public virtual ESwordRiderRailWall WallType
		{
			get
			{
				return (ESwordRiderRailWall)this.Instance.WallType;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x060048C2 RID: 18626 RVA: 0x000B6B67 File Offset: 0x000B4D67
		[Nullable(2)]
		public virtual string PathEffect
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PathEffect;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x000B6B74 File Offset: 0x000B4D74
		public virtual List<ISwordRiderRailSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<ISwordRiderRailSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(ISwordRiderRailSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x0400297D RID: 10621
		private ISwordRiderRailSpline Instance;

		// Token: 0x0400297E RID: 10622
		private List<ISwordRiderRailSplinePoint> _PointsCache;

		// Token: 0x0400297F RID: 10623
		private bool _PointsInited;
	}
}
