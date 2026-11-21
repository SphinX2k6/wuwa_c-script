using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA9 RID: 27561
	public class IDartChampionOwnerInteractTypeT
	{
		// Token: 0x1700CA35 RID: 51765
		// (get) Token: 0x0602F6F1 RID: 194289 RVA: 0x00678724 File Offset: 0x00676924
		// (set) Token: 0x0602F6F2 RID: 194290 RVA: 0x0067872C File Offset: 0x0067692C
		public EDartInteractType Type { get; set; }

		// Token: 0x1700CA36 RID: 51766
		// (get) Token: 0x0602F6F3 RID: 194291 RVA: 0x00678735 File Offset: 0x00676935
		// (set) Token: 0x0602F6F4 RID: 194292 RVA: 0x0067873D File Offset: 0x0067693D
		public int CompetitorId { get; set; }

		// Token: 0x0602F6F5 RID: 194293 RVA: 0x00678746 File Offset: 0x00676946
		public IDartChampionOwnerInteractTypeT()
		{
			this.Type = EDartInteractType.Machine;
			this.CompetitorId = 0;
		}
	}
}
