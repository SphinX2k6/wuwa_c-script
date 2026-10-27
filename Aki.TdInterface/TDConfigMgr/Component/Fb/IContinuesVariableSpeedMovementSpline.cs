using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C54 RID: 3156
	[NullableContext(1)]
	[Nullable(0)]
	public class IContinuesVariableSpeedMovementSpline : ISplineType
	{
		// Token: 0x0600484E RID: 18510 RVA: 0x000B5BFF File Offset: 0x000B3DFF
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

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x000B5C1E File Offset: 0x000B3E1E
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06004850 RID: 18512 RVA: 0x000B5C2C File Offset: 0x000B3E2C
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

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x000B5C62 File Offset: 0x000B3E62
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

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x000B5C98 File Offset: 0x000B3E98
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

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x000B5CD0 File Offset: 0x000B3ED0
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

		// Token: 0x0400292F RID: 10543
		private IContinuesVariableSpeedMovementSpline Instance;

		// Token: 0x04002930 RID: 10544
		[Nullable(2)]
		private ITimePathConfig _EntireTimePathConfigCache;

		// Token: 0x04002931 RID: 10545
		private bool _EntireTimePathConfigInited;

		// Token: 0x04002932 RID: 10546
		private List<IContinuesVariableSpeedSplinePoint> _PointsCache;

		// Token: 0x04002933 RID: 10547
		private bool _PointsInited;
	}
}
