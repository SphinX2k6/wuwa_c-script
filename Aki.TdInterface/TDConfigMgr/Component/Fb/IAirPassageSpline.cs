using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2A RID: 3370
	public class IAirPassageSpline : ISplineType
	{
		// Token: 0x06004CB7 RID: 19639 RVA: 0x000BFEA5 File Offset: 0x000BE0A5
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

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x000BFEC4 File Offset: 0x000BE0C4
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06004CB9 RID: 19641 RVA: 0x000BFED1 File Offset: 0x000BE0D1
		public virtual string MiddleLineEffect
		{
			get
			{
				return this.Instance.MiddleLineEffect;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x000BFEDE File Offset: 0x000BE0DE
		public virtual string TailCircleEffect
		{
			get
			{
				return this.Instance.TailCircleEffect;
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x000BFEEB File Offset: 0x000BE0EB
		public virtual string MiddleCircleEffect
		{
			get
			{
				return this.Instance.MiddleCircleEffect;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x000BFEF8 File Offset: 0x000BE0F8
		public virtual string MiddleCircleOverlyingEffect
		{
			get
			{
				return this.Instance.MiddleCircleOverlyingEffect;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06004CBD RID: 19645 RVA: 0x000BFF05 File Offset: 0x000BE105
		public virtual float MiddleCircleSpace
		{
			get
			{
				return this.Instance.MiddleCircleSpace;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x000BFF12 File Offset: 0x000BE112
		public virtual float MiddleCircleRadius
		{
			get
			{
				return this.Instance.MiddleCircleRadius;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x000BFF1F File Offset: 0x000BE11F
		public virtual float MovableRadius
		{
			get
			{
				return this.Instance.MovableRadius;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x000BFF2C File Offset: 0x000BE12C
		public virtual float Resistance
		{
			get
			{
				return this.Instance.Resistance;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x000BFF39 File Offset: 0x000BE139
		public virtual float SpeedLimit
		{
			get
			{
				return this.Instance.SpeedLimit;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x000BFF46 File Offset: 0x000BE146
		public virtual float SprintSpeedLimit
		{
			get
			{
				return this.Instance.SprintSpeedLimit;
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x000BFF54 File Offset: 0x000BE154
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

		// Token: 0x04002B7F RID: 11135
		private IAirPassageSpline Instance;

		// Token: 0x04002B80 RID: 11136
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04002B81 RID: 11137
		private bool _PointsInited;
	}
}
