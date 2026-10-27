using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C76 RID: 27766
	public class IPerceptionNotifyGatherToPlayerT
	{
		// Token: 0x1700CED4 RID: 52948
		// (get) Token: 0x06030EE9 RID: 200425 RVA: 0x006A504A File Offset: 0x006A324A
		// (set) Token: 0x06030EEA RID: 200426 RVA: 0x006A5052 File Offset: 0x006A3252
		public EBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x06030EEB RID: 200427 RVA: 0x006A505B File Offset: 0x006A325B
		public IPerceptionNotifyGatherToPlayerT()
		{
			this.Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
		}
	}
}
