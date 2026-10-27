using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006105 RID: 24837
	public class IActorTurnToEntityDataT
	{
		// Token: 0x1700B70E RID: 46862
		// (get) Token: 0x0602A6FF RID: 173823 RVA: 0x005D8AAC File Offset: 0x005D6CAC
		// (set) Token: 0x0602A700 RID: 173824 RVA: 0x005D8AB4 File Offset: 0x005D6CB4
		public EActorTurnToMode Type { get; set; }

		// Token: 0x1700B70F RID: 46863
		// (get) Token: 0x0602A701 RID: 173825 RVA: 0x005D8ABD File Offset: 0x005D6CBD
		// (set) Token: 0x0602A702 RID: 173826 RVA: 0x005D8AC5 File Offset: 0x005D6CC5
		public int EntityId { get; set; }

		// Token: 0x0602A703 RID: 173827 RVA: 0x005D8ACE File Offset: 0x005D6CCE
		public IActorTurnToEntityDataT()
		{
			this.Type = EActorTurnToMode.Talker;
			this.EntityId = 0;
		}
	}
}
