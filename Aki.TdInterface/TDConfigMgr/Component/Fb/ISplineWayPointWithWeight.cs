using System;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D33 RID: 3379
	public class ISplineWayPointWithWeight : ISplineWayPoint
	{
		// Token: 0x06004CF3 RID: 19699 RVA: 0x000C063D File Offset: 0x000BE83D
		public static ISplineWayPointWithWeight Create(ISplineWayPointWithWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineWayPointWithWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x000C065C File Offset: 0x000BE85C
		public override int Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004CF5 RID: 19701 RVA: 0x000C0669 File Offset: 0x000BE869
		public override int PointId
		{
			get
			{
				return this.Instance.PointId;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004CF6 RID: 19702 RVA: 0x000C0676 File Offset: 0x000BE876
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002BA6 RID: 11174
		private ISplineWayPointWithWeight Instance;
	}
}
