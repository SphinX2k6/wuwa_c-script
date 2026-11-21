using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007691 RID: 30353
	public class IRoverRogueCreateRoomRewardT
	{
		// Token: 0x1700DEBA RID: 57018
		// (get) Token: 0x060353F0 RID: 218096 RVA: 0x007251BA File Offset: 0x007233BA
		// (set) Token: 0x060353F1 RID: 218097 RVA: 0x007251C2 File Offset: 0x007233C2
		public int RewardType { get; set; }

		// Token: 0x060353F2 RID: 218098 RVA: 0x007251CB File Offset: 0x007233CB
		public IRoverRogueCreateRoomRewardT()
		{
			this.RewardType = 0;
		}
	}
}
