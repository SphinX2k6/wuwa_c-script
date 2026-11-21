using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B1 RID: 5297
	public class ICompleteMessageQuestCondition : IPhoneMessageProgressTypeBase
	{
		// Token: 0x0600782F RID: 30767 RVA: 0x0011FF70 File Offset: 0x0011E170
		public static ICompleteMessageQuestCondition Create(ICompleteMessageQuestCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICompleteMessageQuestCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x0011FF8F File Offset: 0x0011E18F
		public override EPhoneMessageProgressType Type
		{
			get
			{
				return (EPhoneMessageProgressType)this.Instance.Type;
			}
		}

		// Token: 0x04004519 RID: 17689
		private ICompleteMessageQuestCondition Instance;
	}
}
