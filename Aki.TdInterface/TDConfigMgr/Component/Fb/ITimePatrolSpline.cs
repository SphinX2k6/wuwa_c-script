using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C56 RID: 3158
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimePatrolSpline : ISplineType
	{
		// Token: 0x0600485F RID: 18527 RVA: 0x000B5E96 File Offset: 0x000B4096
		public static ITimePatrolSpline Create(ITimePatrolSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimePatrolSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x000B5EB5 File Offset: 0x000B40B5
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x000B5EC4 File Offset: 0x000B40C4
		public virtual List<ITimePatrolSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<ITimePatrolSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(ITimePatrolSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x0400293D RID: 10557
		private ITimePatrolSpline Instance;

		// Token: 0x0400293E RID: 10558
		private List<ITimePatrolSplinePoint> _PointsCache;

		// Token: 0x0400293F RID: 10559
		private bool _PointsInited;
	}
}
