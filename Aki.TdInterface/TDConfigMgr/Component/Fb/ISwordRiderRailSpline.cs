using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3F RID: 3391
	public class ISwordRiderRailSpline : ISplineType
	{
		// Token: 0x06004D44 RID: 19780 RVA: 0x000C1122 File Offset: 0x000BF322
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

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06004D45 RID: 19781 RVA: 0x000C1141 File Offset: 0x000BF341
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x000C114E File Offset: 0x000BF34E
		public virtual ESwordRiderRailWall WallType
		{
			get
			{
				return (ESwordRiderRailWall)this.Instance.WallType;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x000C115B File Offset: 0x000BF35B
		[Nullable(2)]
		public virtual string PathEffect
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.PathEffect;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x000C1168 File Offset: 0x000BF368
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

		// Token: 0x04002BDE RID: 11230
		private ISwordRiderRailSpline Instance;

		// Token: 0x04002BDF RID: 11231
		private List<ISwordRiderRailSplinePoint> _PointsCache;

		// Token: 0x04002BE0 RID: 11232
		private bool _PointsInited;
	}
}
