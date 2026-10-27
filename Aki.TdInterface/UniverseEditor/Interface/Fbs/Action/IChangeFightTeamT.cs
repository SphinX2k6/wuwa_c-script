using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062FA RID: 25338
	public class IChangeFightTeamT
	{
		// Token: 0x1700BD1D RID: 48413
		// (get) Token: 0x0602BCE1 RID: 179425 RVA: 0x0060656C File Offset: 0x0060476C
		// (set) Token: 0x0602BCE2 RID: 179426 RVA: 0x00606574 File Offset: 0x00604774
		public int TeamIndex { get; set; }

		// Token: 0x1700BD1E RID: 48414
		// (get) Token: 0x0602BCE3 RID: 179427 RVA: 0x0060657D File Offset: 0x0060477D
		// (set) Token: 0x0602BCE4 RID: 179428 RVA: 0x00606585 File Offset: 0x00604785
		public byte NullMask { get; set; }

		// Token: 0x0602BCE5 RID: 179429 RVA: 0x0060658E File Offset: 0x0060478E
		public IChangeFightTeamT()
		{
			this.TeamIndex = 0;
			this.NullMask = 0;
		}
	}
}
