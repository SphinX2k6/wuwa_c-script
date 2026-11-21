using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D24 RID: 3364
	public class IPatrolSpline : ISplineType
	{
		// Token: 0x06004C8D RID: 19597 RVA: 0x000BF816 File Offset: 0x000BDA16
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

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06004C8E RID: 19598 RVA: 0x000BF835 File Offset: 0x000BDA35
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x000BF842 File Offset: 0x000BDA42
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

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x000BF874 File Offset: 0x000BDA74
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

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x000BF8AC File Offset: 0x000BDAAC
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

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004C92 RID: 19602 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
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

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x000BF91C File Offset: 0x000BDB1C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPatrolPositionRefreshConfig> PositionRefreshConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._PositionRefreshConfigsInited)
				{
					return this._PositionRefreshConfigsCache;
				}
				this._PositionRefreshConfigsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int positionRefreshConfigsLength = this.Instance.PositionRefreshConfigsLength;
				this._PositionRefreshConfigsCache = new List<IPatrolPositionRefreshConfig>(positionRefreshConfigsLength);
				for (int i = 0; i < positionRefreshConfigsLength; i++)
				{
					this._PositionRefreshConfigsCache.Add(IPatrolPositionRefreshConfig.Create(this.Instance.PositionRefreshConfigs(i)));
				}
				return this._PositionRefreshConfigsCache;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x000BF998 File Offset: 0x000BDB98
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

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x000BFA01 File Offset: 0x000BDC01
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

		// Token: 0x04002B5F RID: 11103
		private IPatrolSpline Instance;

		// Token: 0x04002B60 RID: 11104
		private ICycleModeType _CycleOptionCache;

		// Token: 0x04002B61 RID: 11105
		private bool _CycleOptionInited;

		// Token: 0x04002B62 RID: 11106
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPatrolPositionRefreshConfig> _PositionRefreshConfigsCache;

		// Token: 0x04002B63 RID: 11107
		private bool _PositionRefreshConfigsInited;

		// Token: 0x04002B64 RID: 11108
		private List<IPatrolSplinePoint> _PointsCache;

		// Token: 0x04002B65 RID: 11109
		private bool _PointsInited;

		// Token: 0x04002B66 RID: 11110
		[Nullable(2)]
		private IPatrolRange _PatrolRangeCache;

		// Token: 0x04002B67 RID: 11111
		private bool _PatrolRangeInited;
	}
}
