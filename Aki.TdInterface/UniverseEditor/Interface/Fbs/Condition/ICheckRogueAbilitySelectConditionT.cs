using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B0F RID: 19215
	public class ICheckRogueAbilitySelectConditionT
	{
		// Token: 0x17008B66 RID: 35686
		// (get) Token: 0x0601E38E RID: 123790 RVA: 0x0043CC8A File Offset: 0x0043AE8A
		// (set) Token: 0x0601E38F RID: 123791 RVA: 0x0043CC92 File Offset: 0x0043AE92
		public ECondition Type { get; set; }

		// Token: 0x17008B67 RID: 35687
		// (get) Token: 0x0601E390 RID: 123792 RVA: 0x0043CC9B File Offset: 0x0043AE9B
		// (set) Token: 0x0601E391 RID: 123793 RVA: 0x0043CCA3 File Offset: 0x0043AEA3
		public int BoardId { get; set; }

		// Token: 0x17008B68 RID: 35688
		// (get) Token: 0x0601E392 RID: 123794 RVA: 0x0043CCAC File Offset: 0x0043AEAC
		// (set) Token: 0x0601E393 RID: 123795 RVA: 0x0043CCB4 File Offset: 0x0043AEB4
		public bool IsReceived { get; set; }

		// Token: 0x0601E394 RID: 123796 RVA: 0x0043CCBD File Offset: 0x0043AEBD
		public ICheckRogueAbilitySelectConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.BoardId = 0;
			this.IsReceived = false;
		}
	}
}
