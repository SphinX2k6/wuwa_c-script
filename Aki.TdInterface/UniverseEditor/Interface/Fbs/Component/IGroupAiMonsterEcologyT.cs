using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200533F RID: 21311
	public class IGroupAiMonsterEcologyT
	{
		// Token: 0x17009C89 RID: 40073
		// (get) Token: 0x06022D9A RID: 142746 RVA: 0x004D4051 File Offset: 0x004D2251
		// (set) Token: 0x06022D9B RID: 142747 RVA: 0x004D4059 File Offset: 0x004D2259
		public EGroupAiMode Type { get; set; }

		// Token: 0x17009C8A RID: 40074
		// (get) Token: 0x06022D9C RID: 142748 RVA: 0x004D4062 File Offset: 0x004D2262
		// (set) Token: 0x06022D9D RID: 142749 RVA: 0x004D406A File Offset: 0x004D226A
		public int Leader { get; set; }

		// Token: 0x17009C8B RID: 40075
		// (get) Token: 0x06022D9E RID: 142750 RVA: 0x004D4073 File Offset: 0x004D2273
		// (set) Token: 0x06022D9F RID: 142751 RVA: 0x004D407B File Offset: 0x004D227B
		public List<IGroupAiMonsterMemberT> Members { get; set; }

		// Token: 0x06022DA0 RID: 142752 RVA: 0x004D4084 File Offset: 0x004D2284
		public IGroupAiMonsterEcologyT()
		{
			this.Type = EGroupAiMode.Default;
			this.Leader = 0;
			this.Members = null;
		}
	}
}
