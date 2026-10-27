using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D8C RID: 15756
	public class IChildQuestConfigT
	{
		// Token: 0x17006C56 RID: 27734
		// (get) Token: 0x06015E02 RID: 89602 RVA: 0x00328D88 File Offset: 0x00326F88
		// (set) Token: 0x06015E03 RID: 89603 RVA: 0x00328D90 File Offset: 0x00326F90
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x17006C57 RID: 27735
		// (get) Token: 0x06015E04 RID: 89604 RVA: 0x00328D99 File Offset: 0x00326F99
		// (set) Token: 0x06015E05 RID: 89605 RVA: 0x00328DA1 File Offset: 0x00326FA1
		public byte NullMask { get; set; }

		// Token: 0x06015E06 RID: 89606 RVA: 0x00328DAA File Offset: 0x00326FAA
		public IChildQuestConfigT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.NullMask = 0;
		}
	}
}
