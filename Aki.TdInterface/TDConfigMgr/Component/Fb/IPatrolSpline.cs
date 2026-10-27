using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4B RID: 3147
	[NullableContext(1)]
	[Nullable(0)]
	public class IPatrolSpline : ISplineType
	{
		// Token: 0x06004809 RID: 18441 RVA: 0x000B52A0 File Offset: 0x000B34A0
		public static IPatrolSpline Create(IPatrolSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x0600480A RID: 18442 RVA: 0x000B52BF File Offset: 0x000B34BF
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x000B52CC File Offset: 0x000B34CC
		public virtual ICycleModeType CycleOption
		{
			get
			{
				if (this._CycleOptionInited)
				{
					return this._CycleOptionCache;
				}
				this._CycleOptionInited = true;
				this._CycleOptionCache = ComponentReadHelper.ReadIPatrolSpline_CycleOption(this.Instance);
				return this._CycleOptionCache;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x000B52FC File Offset: 0x000B34FC
		public virtual bool? IsNavigation
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNavigation);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x000B5334 File Offset: 0x000B3534
		public virtual float? TurnSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TurnSpeed);
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x000B536C File Offset: 0x000B356C
		public virtual bool? IsFloating
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFloating);
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x000B53A4 File Offset: 0x000B35A4
		public virtual List<IPatrolSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<IPatrolSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(IPatrolSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06004810 RID: 18448 RVA: 0x000B540D File Offset: 0x000B360D
		[Nullable(2)]
		public virtual IPatrolRange PatrolRange
		{
			[NullableContext(2)]
			get
			{
				if (this._PatrolRangeInited)
				{
					return this._PatrolRangeCache;
				}
				this._PatrolRangeInited = true;
				this._PatrolRangeCache = IPatrolRange.Create(this.Instance.PatrolRange);
				return this._PatrolRangeCache;
			}
		}

		// Token: 0x04002900 RID: 10496
		private IPatrolSpline Instance;

		// Token: 0x04002901 RID: 10497
		private ICycleModeType _CycleOptionCache;

		// Token: 0x04002902 RID: 10498
		private bool _CycleOptionInited;

		// Token: 0x04002903 RID: 10499
		private List<IPatrolSplinePoint> _PointsCache;

		// Token: 0x04002904 RID: 10500
		private bool _PointsInited;

		// Token: 0x04002905 RID: 10501
		[Nullable(2)]
		private IPatrolRange _PatrolRangeCache;

		// Token: 0x04002906 RID: 10502
		private bool _PatrolRangeInited;
	}
}
