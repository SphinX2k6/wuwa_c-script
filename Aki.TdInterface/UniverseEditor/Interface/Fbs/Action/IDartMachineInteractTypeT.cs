using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006544 RID: 25924
	public class IDartMachineInteractTypeT
	{
		// Token: 0x1700C0B1 RID: 49329
		// (get) Token: 0x0602CFA0 RID: 184224 RVA: 0x0062CBDB File Offset: 0x0062ADDB
		// (set) Token: 0x0602CFA1 RID: 184225 RVA: 0x0062CBE3 File Offset: 0x0062ADE3
		public EDartInteractType Type { get; set; }

		// Token: 0x1700C0B2 RID: 49330
		// (get) Token: 0x0602CFA2 RID: 184226 RVA: 0x0062CBEC File Offset: 0x0062ADEC
		// (set) Token: 0x0602CFA3 RID: 184227 RVA: 0x0062CBF4 File Offset: 0x0062ADF4
		public List<int> CanInviteCompetitorIds { get; set; }

		// Token: 0x1700C0B3 RID: 49331
		// (get) Token: 0x0602CFA4 RID: 184228 RVA: 0x0062CBFD File Offset: 0x0062ADFD
		// (set) Token: 0x0602CFA5 RID: 184229 RVA: 0x0062CC05 File Offset: 0x0062AE05
		public int ChampionId { get; set; }

		// Token: 0x1700C0B4 RID: 49332
		// (get) Token: 0x0602CFA6 RID: 184230 RVA: 0x0062CC0E File Offset: 0x0062AE0E
		// (set) Token: 0x0602CFA7 RID: 184231 RVA: 0x0062CC16 File Offset: 0x0062AE16
		public byte NullMask { get; set; }

		// Token: 0x0602CFA8 RID: 184232 RVA: 0x0062CC1F File Offset: 0x0062AE1F
		public IDartMachineInteractTypeT()
		{
			this.Type = EDartInteractType.Machine;
			this.CanInviteCompetitorIds = null;
			this.ChampionId = 0;
			this.NullMask = 0;
		}
	}
}
