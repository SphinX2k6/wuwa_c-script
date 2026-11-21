using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676A RID: 26474
	public class IActorTurnToPlayerDataT
	{
		// Token: 0x1700C07D RID: 49277
		// (get) Token: 0x0602CDF4 RID: 183796 RVA: 0x00622BF2 File Offset: 0x00620DF2
		// (set) Token: 0x0602CDF5 RID: 183797 RVA: 0x00622BFA File Offset: 0x00620DFA
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602CDF6 RID: 183798 RVA: 0x00622C03 File Offset: 0x00620E03
		public IActorTurnToPlayerDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
