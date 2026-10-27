using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C50 RID: 3152
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelAISpline : ISplineType
	{
		// Token: 0x0600482A RID: 18474 RVA: 0x000B5762 File Offset: 0x000B3962
		public static ILevelAISpline Create(ILevelAISpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAISpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x000B5781 File Offset: 0x000B3981
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x000B578E File Offset: 0x000B398E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x000B579B File Offset: 0x000B399B
		[Nullable(2)]
		public virtual ILevelAiCycleLooply CycleOption
		{
			[NullableContext(2)]
			get
			{
				if (this._CycleOptionInited)
				{
					return this._CycleOptionCache;
				}
				this._CycleOptionInited = true;
				this._CycleOptionCache = ILevelAiCycleLooply.Create(this.Instance.CycleOption);
				return this._CycleOptionCache;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x000B57D0 File Offset: 0x000B39D0
		public virtual bool? UsePathFinding
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UsePathFinding);
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x000B5808 File Offset: 0x000B3A08
		public virtual bool? IsPassEveryKeyPoint
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPassEveryKeyPoint);
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x000B5840 File Offset: 0x000B3A40
		public virtual List<ILevelAISplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<ILevelAISplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(ILevelAISplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x04002919 RID: 10521
		private ILevelAISpline Instance;

		// Token: 0x0400291A RID: 10522
		[Nullable(2)]
		private ILevelAiCycleLooply _CycleOptionCache;

		// Token: 0x0400291B RID: 10523
		private bool _CycleOptionInited;

		// Token: 0x0400291C RID: 10524
		private List<ILevelAISplinePoint> _PointsCache;

		// Token: 0x0400291D RID: 10525
		private bool _PointsInited;
	}
}
