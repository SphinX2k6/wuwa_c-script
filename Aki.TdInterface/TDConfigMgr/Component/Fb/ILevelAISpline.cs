using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D29 RID: 3369
	public class ILevelAISpline : ISplineType
	{
		// Token: 0x06004CAF RID: 19631 RVA: 0x000BFD56 File Offset: 0x000BDF56
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

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x000BFD75 File Offset: 0x000BDF75
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x000BFD82 File Offset: 0x000BDF82
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x000BFD8F File Offset: 0x000BDF8F
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

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x000BFDC4 File Offset: 0x000BDFC4
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

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x000BFDFC File Offset: 0x000BDFFC
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

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x000BFE34 File Offset: 0x000BE034
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

		// Token: 0x04002B7A RID: 11130
		private ILevelAISpline Instance;

		// Token: 0x04002B7B RID: 11131
		[Nullable(2)]
		private ILevelAiCycleLooply _CycleOptionCache;

		// Token: 0x04002B7C RID: 11132
		private bool _CycleOptionInited;

		// Token: 0x04002B7D RID: 11133
		private List<ILevelAISplinePoint> _PointsCache;

		// Token: 0x04002B7E RID: 11134
		private bool _PointsInited;
	}
}
