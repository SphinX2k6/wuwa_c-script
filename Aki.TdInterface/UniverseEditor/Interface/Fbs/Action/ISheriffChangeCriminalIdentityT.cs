using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007888 RID: 30856
	public class ISheriffChangeCriminalIdentityT
	{
		// Token: 0x1700E24A RID: 57930
		// (get) Token: 0x06036484 RID: 222340 RVA: 0x00745290 File Offset: 0x00743490
		// (set) Token: 0x06036485 RID: 222341 RVA: 0x00745298 File Offset: 0x00743498
		public int CriminalId { get; set; }

		// Token: 0x1700E24B RID: 57931
		// (get) Token: 0x06036486 RID: 222342 RVA: 0x007452A1 File Offset: 0x007434A1
		// (set) Token: 0x06036487 RID: 222343 RVA: 0x007452A9 File Offset: 0x007434A9
		public int IdentityId { get; set; }

		// Token: 0x06036488 RID: 222344 RVA: 0x007452B2 File Offset: 0x007434B2
		public ISheriffChangeCriminalIdentityT()
		{
			this.CriminalId = 0;
			this.IdentityId = 0;
		}
	}
}
