using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F1F RID: 24351
	public class ISimpleCombatComponentT
	{
		// Token: 0x1700B41F RID: 46111
		// (get) Token: 0x06028E08 RID: 167432 RVA: 0x00595D66 File Offset: 0x00593F66
		// (set) Token: 0x06028E09 RID: 167433 RVA: 0x00595D6E File Offset: 0x00593F6E
		public bool Disabled { get; set; }

		// Token: 0x1700B420 RID: 46112
		// (get) Token: 0x06028E0A RID: 167434 RVA: 0x00595D77 File Offset: 0x00593F77
		// (set) Token: 0x06028E0B RID: 167435 RVA: 0x00595D7F File Offset: 0x00593F7F
		public int Id { get; set; }

		// Token: 0x1700B421 RID: 46113
		// (get) Token: 0x06028E0C RID: 167436 RVA: 0x00595D88 File Offset: 0x00593F88
		// (set) Token: 0x06028E0D RID: 167437 RVA: 0x00595D90 File Offset: 0x00593F90
		public byte NullMask { get; set; }

		// Token: 0x06028E0E RID: 167438 RVA: 0x00595D99 File Offset: 0x00593F99
		public ISimpleCombatComponentT()
		{
			this.Disabled = false;
			this.Id = 0;
			this.NullMask = 0;
		}
	}
}
