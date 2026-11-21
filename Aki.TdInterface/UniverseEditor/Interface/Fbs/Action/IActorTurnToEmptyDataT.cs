using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006764 RID: 26468
	public class IActorTurnToEmptyDataT
	{
		// Token: 0x1700C075 RID: 49269
		// (get) Token: 0x0602CDCC RID: 183756 RVA: 0x0062287A File Offset: 0x00620A7A
		// (set) Token: 0x0602CDCD RID: 183757 RVA: 0x00622882 File Offset: 0x00620A82
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602CDCE RID: 183758 RVA: 0x0062288B File Offset: 0x00620A8B
		public IActorTurnToEmptyDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
