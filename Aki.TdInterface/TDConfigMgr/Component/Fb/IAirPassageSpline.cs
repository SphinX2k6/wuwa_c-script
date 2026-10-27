using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C51 RID: 3153
	[NullableContext(1)]
	[Nullable(0)]
	public class IAirPassageSpline : ISplineType
	{
		// Token: 0x06004832 RID: 18482 RVA: 0x000B58B1 File Offset: 0x000B3AB1
		public static IAirPassageSpline Create(IAirPassageSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x000B58D0 File Offset: 0x000B3AD0
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x000B58DD File Offset: 0x000B3ADD
		public virtual string MiddleLineEffect
		{
			get
			{
				return this.Instance.MiddleLineEffect;
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x000B58EA File Offset: 0x000B3AEA
		public virtual string TailCircleEffect
		{
			get
			{
				return this.Instance.TailCircleEffect;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x000B58F7 File Offset: 0x000B3AF7
		public virtual string MiddleCircleEffect
		{
			get
			{
				return this.Instance.MiddleCircleEffect;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x000B5904 File Offset: 0x000B3B04
		public virtual string MiddleCircleOverlyingEffect
		{
			get
			{
				return this.Instance.MiddleCircleOverlyingEffect;
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x000B5911 File Offset: 0x000B3B11
		public virtual float MiddleCircleSpace
		{
			get
			{
				return this.Instance.MiddleCircleSpace;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x000B591E File Offset: 0x000B3B1E
		public virtual float MiddleCircleRadius
		{
			get
			{
				return this.Instance.MiddleCircleRadius;
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x000B592B File Offset: 0x000B3B2B
		public virtual float MovableRadius
		{
			get
			{
				return this.Instance.MovableRadius;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x000B5938 File Offset: 0x000B3B38
		public virtual float Resistance
		{
			get
			{
				return this.Instance.Resistance;
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x000B5945 File Offset: 0x000B3B45
		public virtual float SpeedLimit
		{
			get
			{
				return this.Instance.SpeedLimit;
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x000B5952 File Offset: 0x000B3B52
		public virtual float SprintSpeedLimit
		{
			get
			{
				return this.Instance.SprintSpeedLimit;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x000B5960 File Offset: 0x000B3B60
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

		// Token: 0x0400291E RID: 10526
		private IAirPassageSpline Instance;

		// Token: 0x0400291F RID: 10527
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04002920 RID: 10528
		private bool _PointsInited;
	}
}
