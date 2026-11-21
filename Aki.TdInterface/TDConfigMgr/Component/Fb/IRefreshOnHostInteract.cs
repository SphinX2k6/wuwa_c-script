using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B75 RID: 2933
	public class IRefreshOnHostInteract : IRefreshConditionBase
	{
		// Token: 0x06004328 RID: 17192 RVA: 0x000AA86A File Offset: 0x000A8A6A
		public static IRefreshOnHostInteract Create(IRefreshOnHostInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnHostInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06004329 RID: 17193 RVA: 0x000AA889 File Offset: 0x000A8A89
		public override ERewardDropType Type
		{
			get
			{
				return (ERewardDropType)this.Instance.Type;
			}
		}

		// Token: 0x04002518 RID: 9496
		private IRefreshOnHostInteract Instance;
	}
}
