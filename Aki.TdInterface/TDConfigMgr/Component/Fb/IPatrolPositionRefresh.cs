using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D21 RID: 3361
	public class IPatrolPositionRefresh
	{
		// Token: 0x06004C83 RID: 19587 RVA: 0x000BF724 File Offset: 0x000BD924
		public static IPatrolPositionRefresh Create(IPatrolPositionRefresh? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefresh
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06004C84 RID: 19588 RVA: 0x000BF743 File Offset: 0x000BD943
		public virtual EPatrolPositionRefreshType Type
		{
			get
			{
				return (EPatrolPositionRefreshType)this.Instance.Type;
			}
		}

		// Token: 0x04002B58 RID: 11096
		private IPatrolPositionRefresh Instance;
	}
}
