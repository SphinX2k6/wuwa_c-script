using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E2 RID: 25314
	public class IChangeEntityCampT
	{
		// Token: 0x1700BCED RID: 48365
		// (get) Token: 0x0602BC17 RID: 179223 RVA: 0x00605118 File Offset: 0x00603318
		// (set) Token: 0x0602BC18 RID: 179224 RVA: 0x00605120 File Offset: 0x00603320
		public int TargetEntity { get; set; }

		// Token: 0x1700BCEE RID: 48366
		// (get) Token: 0x0602BC19 RID: 179225 RVA: 0x00605129 File Offset: 0x00603329
		// (set) Token: 0x0602BC1A RID: 179226 RVA: 0x00605131 File Offset: 0x00603331
		public ECamp Camp { get; set; }

		// Token: 0x0602BC1B RID: 179227 RVA: 0x0060513A File Offset: 0x0060333A
		public IChangeEntityCampT()
		{
			this.TargetEntity = 0;
			this.Camp = ECamp.Player;
		}
	}
}
