using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D18 RID: 3352
	public class IEffectSpline : ISplineType
	{
		// Token: 0x06004C56 RID: 19542 RVA: 0x000BF1B2 File Offset: 0x000BD3B2
		public static IEffectSpline Create(IEffectSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06004C57 RID: 19543 RVA: 0x000BF1D1 File Offset: 0x000BD3D1
		public override ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x000BF1DE File Offset: 0x000BD3DE
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x000BF1EB File Offset: 0x000BD3EB
		public virtual IEffectSplineCreationMode CreateOption
		{
			get
			{
				if (this._CreateOptionInited)
				{
					return this._CreateOptionCache;
				}
				this._CreateOptionInited = true;
				this._CreateOptionCache = ComponentReadHelper.ReadIEffectSpline_CreateOption(this.Instance);
				return this._CreateOptionCache;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x000BF21C File Offset: 0x000BD41C
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

		// Token: 0x04002B3F RID: 11071
		private IEffectSpline Instance;

		// Token: 0x04002B40 RID: 11072
		private IEffectSplineCreationMode _CreateOptionCache;

		// Token: 0x04002B41 RID: 11073
		private bool _CreateOptionInited;

		// Token: 0x04002B42 RID: 11074
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04002B43 RID: 11075
		private bool _PointsInited;
	}
}
