using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C73 RID: 27763
	public class IPerceptionNotifyGatherToEntityT
	{
		// Token: 0x1700CED0 RID: 52944
		// (get) Token: 0x06030ED5 RID: 200405 RVA: 0x006A4EAC File Offset: 0x006A30AC
		// (set) Token: 0x06030ED6 RID: 200406 RVA: 0x006A4EB4 File Offset: 0x006A30B4
		public EBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x1700CED1 RID: 52945
		// (get) Token: 0x06030ED7 RID: 200407 RVA: 0x006A4EBD File Offset: 0x006A30BD
		// (set) Token: 0x06030ED8 RID: 200408 RVA: 0x006A4EC5 File Offset: 0x006A30C5
		public int EntityId { get; set; }

		// Token: 0x06030ED9 RID: 200409 RVA: 0x006A4ECE File Offset: 0x006A30CE
		public IPerceptionNotifyGatherToEntityT()
		{
			this.Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
			this.EntityId = 0;
		}
	}
}
