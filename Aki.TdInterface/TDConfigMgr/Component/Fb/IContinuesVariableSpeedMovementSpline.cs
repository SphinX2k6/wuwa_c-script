using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2D RID: 3373
	public class IContinuesVariableSpeedMovementSpline : ISplineType
	{
		// Token: 0x06004CD3 RID: 19667 RVA: 0x000C01F3 File Offset: 0x000BE3F3
		public static IContinuesVariableSpeedMovementSpline Create(IContinuesVariableSpeedMovementSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IContinuesVariableSpeedMovementSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x000C0212 File Offset: 0x000BE412
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x000C0220 File Offset: 0x000BE420
		public virtual int? TransitionSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TransitionSpeed);
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x000C0256 File Offset: 0x000BE456
		[Nullable(2)]
		public virtual ITimePathConfig EntireTimePathConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._EntireTimePathConfigInited)
				{
					return this._EntireTimePathConfigCache;
				}
				this._EntireTimePathConfigInited = true;
				this._EntireTimePathConfigCache = ITimePathConfig.Create(this.Instance.EntireTimePathConfig);
				return this._EntireTimePathConfigCache;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x000C028C File Offset: 0x000BE48C
		public virtual EMoveCircleMode? CircleMode
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EMoveCircleMode?((EMoveCircleMode)this.Instance.CircleMode);
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x000C02C4 File Offset: 0x000BE4C4
		public virtual List<IContinuesVariableSpeedSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				int pointsLength = this.Instance.PointsLength;
				this._PointsCache = new List<IContinuesVariableSpeedSplinePoint>(pointsLength);
				for (int i = 0; i < pointsLength; i++)
				{
					this._PointsCache.Add(IContinuesVariableSpeedSplinePoint.Create(this.Instance.Points(i)));
				}
				return this._PointsCache;
			}
		}

		// Token: 0x04002B90 RID: 11152
		private IContinuesVariableSpeedMovementSpline Instance;

		// Token: 0x04002B91 RID: 11153
		[Nullable(2)]
		private ITimePathConfig _EntireTimePathConfigCache;

		// Token: 0x04002B92 RID: 11154
		private bool _EntireTimePathConfigInited;

		// Token: 0x04002B93 RID: 11155
		private List<IContinuesVariableSpeedSplinePoint> _PointsCache;

		// Token: 0x04002B94 RID: 11156
		private bool _PointsInited;
	}
}
