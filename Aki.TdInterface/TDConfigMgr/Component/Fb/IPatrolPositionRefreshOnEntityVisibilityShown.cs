using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D20 RID: 3360
	public class IPatrolPositionRefreshOnEntityVisibilityShown : IPatrolPositionRefreshTrigger
	{
		// Token: 0x06004C80 RID: 19584 RVA: 0x000BF6F0 File Offset: 0x000BD8F0
		public static IPatrolPositionRefreshOnEntityVisibilityShown Create(IPatrolPositionRefreshOnEntityVisibilityShown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshOnEntityVisibilityShown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x000BF70F File Offset: 0x000BD90F
		public override EPatrolPositionRefreshTriggerType Type
		{
			get
			{
				return (EPatrolPositionRefreshTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04002B57 RID: 11095
		private IPatrolPositionRefreshOnEntityVisibilityShown Instance;
	}
}
