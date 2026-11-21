using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1F RID: 3359
	public class IPatrolPositionRefreshOnEntityAwake : IPatrolPositionRefreshTrigger
	{
		// Token: 0x06004C7D RID: 19581 RVA: 0x000BF6BC File Offset: 0x000BD8BC
		public static IPatrolPositionRefreshOnEntityAwake Create(IPatrolPositionRefreshOnEntityAwake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshOnEntityAwake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x000BF6DB File Offset: 0x000BD8DB
		public override EPatrolPositionRefreshTriggerType Type
		{
			get
			{
				return (EPatrolPositionRefreshTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04002B56 RID: 11094
		private IPatrolPositionRefreshOnEntityAwake Instance;
	}
}
