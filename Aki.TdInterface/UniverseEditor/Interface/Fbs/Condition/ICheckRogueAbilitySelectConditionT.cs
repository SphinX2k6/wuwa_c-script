using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF6 RID: 20470
	public class ICheckRogueAbilitySelectConditionT
	{
		// Token: 0x17009276 RID: 37494
		// (get) Token: 0x0601FF19 RID: 130841 RVA: 0x0046F436 File Offset: 0x0046D636
		// (set) Token: 0x0601FF1A RID: 130842 RVA: 0x0046F43E File Offset: 0x0046D63E
		public ECondition Type { get; set; }

		// Token: 0x17009277 RID: 37495
		// (get) Token: 0x0601FF1B RID: 130843 RVA: 0x0046F447 File Offset: 0x0046D647
		// (set) Token: 0x0601FF1C RID: 130844 RVA: 0x0046F44F File Offset: 0x0046D64F
		public int BoardId { get; set; }

		// Token: 0x17009278 RID: 37496
		// (get) Token: 0x0601FF1D RID: 130845 RVA: 0x0046F458 File Offset: 0x0046D658
		// (set) Token: 0x0601FF1E RID: 130846 RVA: 0x0046F460 File Offset: 0x0046D660
		public bool IsReceived { get; set; }

		// Token: 0x0601FF1F RID: 130847 RVA: 0x0046F469 File Offset: 0x0046D669
		public ICheckRogueAbilitySelectConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.BoardId = 0;
			this.IsReceived = false;
		}
	}
}
