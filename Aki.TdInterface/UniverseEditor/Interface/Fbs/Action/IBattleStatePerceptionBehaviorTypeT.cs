using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F8 RID: 25080
	public class IBattleStatePerceptionBehaviorTypeT
	{
		// Token: 0x1700BAF4 RID: 47860
		// (get) Token: 0x0602B3AD RID: 177069 RVA: 0x005F4CCE File Offset: 0x005F2ECE
		// (set) Token: 0x0602B3AE RID: 177070 RVA: 0x005F4CD6 File Offset: 0x005F2ED6
		public EBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x0602B3AF RID: 177071 RVA: 0x005F4CDF File Offset: 0x005F2EDF
		public IBattleStatePerceptionBehaviorTypeT()
		{
			this.Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
		}
	}
}
