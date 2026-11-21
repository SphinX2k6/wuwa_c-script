using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C1 RID: 16833
	public class ICompleteMessageQuestConditionT
	{
		// Token: 0x17007257 RID: 29271
		// (get) Token: 0x06017472 RID: 95346 RVA: 0x00352B9E File Offset: 0x00350D9E
		// (set) Token: 0x06017473 RID: 95347 RVA: 0x00352BA6 File Offset: 0x00350DA6
		public EPhoneMessageProgressType Type { get; set; }

		// Token: 0x06017474 RID: 95348 RVA: 0x00352BAF File Offset: 0x00350DAF
		public ICompleteMessageQuestConditionT()
		{
			this.Type = EPhoneMessageProgressType.CompleteMessage;
		}
	}
}
