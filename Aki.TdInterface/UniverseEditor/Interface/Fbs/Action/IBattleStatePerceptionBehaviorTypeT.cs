using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006866 RID: 26726
	public class IBattleStatePerceptionBehaviorTypeT
	{
		// Token: 0x1700C477 RID: 50295
		// (get) Token: 0x0602DAF4 RID: 187124 RVA: 0x0063F742 File Offset: 0x0063D942
		// (set) Token: 0x0602DAF5 RID: 187125 RVA: 0x0063F74A File Offset: 0x0063D94A
		public EBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x0602DAF6 RID: 187126 RVA: 0x0063F753 File Offset: 0x0063D953
		public IBattleStatePerceptionBehaviorTypeT()
		{
			this.Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
		}
	}
}
