using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1E RID: 3358
	public class IPatrolPositionRefreshTrigger
	{
		// Token: 0x06004C7A RID: 19578 RVA: 0x000BF688 File Offset: 0x000BD888
		public static IPatrolPositionRefreshTrigger Create(IPatrolPositionRefreshTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x000BF6A7 File Offset: 0x000BD8A7
		public virtual EPatrolPositionRefreshTriggerType Type
		{
			get
			{
				return (EPatrolPositionRefreshTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04002B55 RID: 11093
		private IPatrolPositionRefreshTrigger Instance;
	}
}
