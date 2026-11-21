using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2F RID: 3375
	public class ITimePatrolSpline : ISplineType
	{
		// Token: 0x06004CE4 RID: 19684 RVA: 0x000C048A File Offset: 0x000BE68A
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

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x000C04A9 File Offset: 0x000BE6A9
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x000C04B8 File Offset: 0x000BE6B8
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

		// Token: 0x04002B9E RID: 11166
		private ITimePatrolSpline Instance;

		// Token: 0x04002B9F RID: 11167
		private List<ITimePatrolSplinePoint> _PointsCache;

		// Token: 0x04002BA0 RID: 11168
		private bool _PointsInited;
	}
}
