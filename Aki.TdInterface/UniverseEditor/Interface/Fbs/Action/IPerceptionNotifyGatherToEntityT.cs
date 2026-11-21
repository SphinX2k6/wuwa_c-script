using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DA RID: 29658
	public class IPerceptionNotifyGatherToEntityT
	{
		// Token: 0x1700D9EB RID: 55787
		// (get) Token: 0x06033E30 RID: 212528 RVA: 0x006FF3AC File Offset: 0x006FD5AC
		// (set) Token: 0x06033E31 RID: 212529 RVA: 0x006FF3B4 File Offset: 0x006FD5B4
		public EBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x1700D9EC RID: 55788
		// (get) Token: 0x06033E32 RID: 212530 RVA: 0x006FF3BD File Offset: 0x006FD5BD
		// (set) Token: 0x06033E33 RID: 212531 RVA: 0x006FF3C5 File Offset: 0x006FD5C5
		public int EntityId { get; set; }

		// Token: 0x06033E34 RID: 212532 RVA: 0x006FF3CE File Offset: 0x006FD5CE
		public IPerceptionNotifyGatherToEntityT()
		{
			this.Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
			this.EntityId = 0;
		}
	}
}
