using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B73 RID: 2931
	public class IRefreshConditionBase
	{
		// Token: 0x06004322 RID: 17186 RVA: 0x000AA802 File Offset: 0x000A8A02
		public static IRefreshConditionBase Create(IRefreshConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06004323 RID: 17187 RVA: 0x000AA821 File Offset: 0x000A8A21
		public virtual ERewardDropType Type
		{
			get
			{
				return (ERewardDropType)this.Instance.Type;
			}
		}

		// Token: 0x04002516 RID: 9494
		private IRefreshConditionBase Instance;
	}
}
