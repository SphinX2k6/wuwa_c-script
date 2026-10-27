using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200498F RID: 18831
	public class ICheckBvbChallengeStateT
	{
		// Token: 0x17008808 RID: 34824
		// (get) Token: 0x0601D5D8 RID: 120280 RVA: 0x00423D42 File Offset: 0x00421F42
		// (set) Token: 0x0601D5D9 RID: 120281 RVA: 0x00423D4A File Offset: 0x00421F4A
		public ECondition Type { get; set; }

		// Token: 0x17008809 RID: 34825
		// (get) Token: 0x0601D5DA RID: 120282 RVA: 0x00423D53 File Offset: 0x00421F53
		// (set) Token: 0x0601D5DB RID: 120283 RVA: 0x00423D5B File Offset: 0x00421F5B
		public int ChallengeId { get; set; }

		// Token: 0x1700880A RID: 34826
		// (get) Token: 0x0601D5DC RID: 120284 RVA: 0x00423D64 File Offset: 0x00421F64
		// (set) Token: 0x0601D5DD RID: 120285 RVA: 0x00423D6C File Offset: 0x00421F6C
		public EBvbChallengeStateType ChallengeState { get; set; }

		// Token: 0x0601D5DE RID: 120286 RVA: 0x00423D75 File Offset: 0x00421F75
		public ICheckBvbChallengeStateT()
		{
			this.Type = ECondition.CompareVar;
			this.ChallengeId = 0;
			this.ChallengeState = EBvbChallengeStateType.Default;
		}
	}
}
