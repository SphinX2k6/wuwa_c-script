using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005708 RID: 22280
	public class IPatrolCycleLooplyT
	{
		// Token: 0x1700A5E4 RID: 42468
		// (get) Token: 0x0602540B RID: 152587 RVA: 0x00523F88 File Offset: 0x00522188
		// (set) Token: 0x0602540C RID: 152588 RVA: 0x00523F90 File Offset: 0x00522190
		public EPatrolCycleMode Type { get; set; }

		// Token: 0x1700A5E5 RID: 42469
		// (get) Token: 0x0602540D RID: 152589 RVA: 0x00523F99 File Offset: 0x00522199
		// (set) Token: 0x0602540E RID: 152590 RVA: 0x00523FA1 File Offset: 0x005221A1
		public bool IsCircle { get; set; }

		// Token: 0x0602540F RID: 152591 RVA: 0x00523FAA File Offset: 0x005221AA
		public IPatrolCycleLooplyT()
		{
			this.Type = EPatrolCycleMode.Loop;
			this.IsCircle = false;
		}
	}
}
