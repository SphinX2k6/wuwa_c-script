using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C5 RID: 22725
	public class IGroupAiMonsterEcologyT
	{
		// Token: 0x1700A4C1 RID: 42177
		// (get) Token: 0x06024E4E RID: 151118 RVA: 0x00510F25 File Offset: 0x0050F125
		// (set) Token: 0x06024E4F RID: 151119 RVA: 0x00510F2D File Offset: 0x0050F12D
		public EGroupAiMode Type { get; set; }

		// Token: 0x1700A4C2 RID: 42178
		// (get) Token: 0x06024E50 RID: 151120 RVA: 0x00510F36 File Offset: 0x0050F136
		// (set) Token: 0x06024E51 RID: 151121 RVA: 0x00510F3E File Offset: 0x0050F13E
		public int Leader { get; set; }

		// Token: 0x1700A4C3 RID: 42179
		// (get) Token: 0x06024E52 RID: 151122 RVA: 0x00510F47 File Offset: 0x0050F147
		// (set) Token: 0x06024E53 RID: 151123 RVA: 0x00510F4F File Offset: 0x0050F14F
		public List<IGroupAiMonsterMemberT> Members { get; set; }

		// Token: 0x06024E54 RID: 151124 RVA: 0x00510F58 File Offset: 0x0050F158
		public IGroupAiMonsterEcologyT()
		{
			this.Type = EGroupAiMode.Default;
			this.Leader = 0;
			this.Members = null;
		}
	}
}
