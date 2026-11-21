using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B74 RID: 2932
	public class IRefreshOnDeath : IRefreshConditionBase
	{
		// Token: 0x06004325 RID: 17189 RVA: 0x000AA836 File Offset: 0x000A8A36
		public static IRefreshOnDeath Create(IRefreshOnDeath? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnDeath
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x000AA855 File Offset: 0x000A8A55
		public override ERewardDropType Type
		{
			get
			{
				return (ERewardDropType)this.Instance.Type;
			}
		}

		// Token: 0x04002517 RID: 9495
		private IRefreshOnDeath Instance;
	}
}
