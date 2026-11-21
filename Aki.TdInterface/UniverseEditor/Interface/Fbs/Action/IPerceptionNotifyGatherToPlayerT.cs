using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DD RID: 29661
	public class IPerceptionNotifyGatherToPlayerT
	{
		// Token: 0x1700D9EF RID: 55791
		// (get) Token: 0x06033E44 RID: 212548 RVA: 0x006FF54A File Offset: 0x006FD74A
		// (set) Token: 0x06033E45 RID: 212549 RVA: 0x006FF552 File Offset: 0x006FD752
		public EBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x06033E46 RID: 212550 RVA: 0x006FF55B File Offset: 0x006FD75B
		public IPerceptionNotifyGatherToPlayerT()
		{
			this.Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
		}
	}
}
