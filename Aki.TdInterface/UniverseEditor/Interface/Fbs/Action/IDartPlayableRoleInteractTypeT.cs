using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006547 RID: 25927
	public class IDartPlayableRoleInteractTypeT
	{
		// Token: 0x1700C0B8 RID: 49336
		// (get) Token: 0x0602CFBA RID: 184250 RVA: 0x0062CE34 File Offset: 0x0062B034
		// (set) Token: 0x0602CFBB RID: 184251 RVA: 0x0062CE3C File Offset: 0x0062B03C
		public EDartInteractType Type { get; set; }

		// Token: 0x1700C0B9 RID: 49337
		// (get) Token: 0x0602CFBC RID: 184252 RVA: 0x0062CE45 File Offset: 0x0062B045
		// (set) Token: 0x0602CFBD RID: 184253 RVA: 0x0062CE4D File Offset: 0x0062B04D
		public int CompetitorId { get; set; }

		// Token: 0x0602CFBE RID: 184254 RVA: 0x0062CE56 File Offset: 0x0062B056
		public IDartPlayableRoleInteractTypeT()
		{
			this.Type = EDartInteractType.Machine;
			this.CompetitorId = 0;
		}
	}
}
