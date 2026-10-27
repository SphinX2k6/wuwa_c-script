using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BC RID: 28860
	public class ISheriffChangeCriminalIdentityT
	{
		// Token: 0x1700D667 RID: 54887
		// (get) Token: 0x060331E2 RID: 209378 RVA: 0x006E4C84 File Offset: 0x006E2E84
		// (set) Token: 0x060331E3 RID: 209379 RVA: 0x006E4C8C File Offset: 0x006E2E8C
		public int CriminalId { get; set; }

		// Token: 0x1700D668 RID: 54888
		// (get) Token: 0x060331E4 RID: 209380 RVA: 0x006E4C95 File Offset: 0x006E2E95
		// (set) Token: 0x060331E5 RID: 209381 RVA: 0x006E4C9D File Offset: 0x006E2E9D
		public int IdentityId { get; set; }

		// Token: 0x060331E6 RID: 209382 RVA: 0x006E4CA6 File Offset: 0x006E2EA6
		public ISheriffChangeCriminalIdentityT()
		{
			this.CriminalId = 0;
			this.IdentityId = 0;
		}
	}
}
