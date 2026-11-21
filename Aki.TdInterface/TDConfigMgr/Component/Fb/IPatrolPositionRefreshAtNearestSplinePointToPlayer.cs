using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D22 RID: 3362
	public class IPatrolPositionRefreshAtNearestSplinePointToPlayer : IPatrolPositionRefresh
	{
		// Token: 0x06004C86 RID: 19590 RVA: 0x000BF758 File Offset: 0x000BD958
		public static IPatrolPositionRefreshAtNearestSplinePointToPlayer Create(IPatrolPositionRefreshAtNearestSplinePointToPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshAtNearestSplinePointToPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x000BF777 File Offset: 0x000BD977
		public override EPatrolPositionRefreshType Type
		{
			get
			{
				return (EPatrolPositionRefreshType)this.Instance.Type;
			}
		}

		// Token: 0x04002B59 RID: 11097
		private IPatrolPositionRefreshAtNearestSplinePointToPlayer Instance;
	}
}
