using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB5 RID: 27573
	public class IDartMachineInteractTypeT
	{
		// Token: 0x1700CA48 RID: 51784
		// (get) Token: 0x0602F754 RID: 194388 RVA: 0x00679287 File Offset: 0x00677487
		// (set) Token: 0x0602F755 RID: 194389 RVA: 0x0067928F File Offset: 0x0067748F
		public EDartInteractType Type { get; set; }

		// Token: 0x1700CA49 RID: 51785
		// (get) Token: 0x0602F756 RID: 194390 RVA: 0x00679298 File Offset: 0x00677498
		// (set) Token: 0x0602F757 RID: 194391 RVA: 0x006792A0 File Offset: 0x006774A0
		public List<int> CanInviteCompetitorIds { get; set; }

		// Token: 0x1700CA4A RID: 51786
		// (get) Token: 0x0602F758 RID: 194392 RVA: 0x006792A9 File Offset: 0x006774A9
		// (set) Token: 0x0602F759 RID: 194393 RVA: 0x006792B1 File Offset: 0x006774B1
		public int ChampionId { get; set; }

		// Token: 0x1700CA4B RID: 51787
		// (get) Token: 0x0602F75A RID: 194394 RVA: 0x006792BA File Offset: 0x006774BA
		// (set) Token: 0x0602F75B RID: 194395 RVA: 0x006792C2 File Offset: 0x006774C2
		public byte NullMask { get; set; }

		// Token: 0x0602F75C RID: 194396 RVA: 0x006792CB File Offset: 0x006774CB
		public IDartMachineInteractTypeT()
		{
			this.Type = EDartInteractType.Machine;
			this.CanInviteCompetitorIds = null;
			this.ChampionId = 0;
			this.NullMask = 0;
		}
	}
}
