using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE6 RID: 28390
	public class IRogueRandomEventOptionT
	{
		// Token: 0x1700D337 RID: 54071
		// (get) Token: 0x060322B9 RID: 205497 RVA: 0x006C7D69 File Offset: 0x006C5F69
		// (set) Token: 0x060322BA RID: 205498 RVA: 0x006C7D71 File Offset: 0x006C5F71
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700D338 RID: 54072
		// (get) Token: 0x060322BB RID: 205499 RVA: 0x006C7D7A File Offset: 0x006C5F7A
		// (set) Token: 0x060322BC RID: 205500 RVA: 0x006C7D82 File Offset: 0x006C5F82
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700D339 RID: 54073
		// (get) Token: 0x060322BD RID: 205501 RVA: 0x006C7D8B File Offset: 0x006C5F8B
		// (set) Token: 0x060322BE RID: 205502 RVA: 0x006C7D93 File Offset: 0x006C5F93
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700D33A RID: 54074
		// (get) Token: 0x060322BF RID: 205503 RVA: 0x006C7D9C File Offset: 0x006C5F9C
		// (set) Token: 0x060322C0 RID: 205504 RVA: 0x006C7DA4 File Offset: 0x006C5FA4
		public int EventId { get; set; }

		// Token: 0x1700D33B RID: 54075
		// (get) Token: 0x060322C1 RID: 205505 RVA: 0x006C7DAD File Offset: 0x006C5FAD
		// (set) Token: 0x060322C2 RID: 205506 RVA: 0x006C7DB5 File Offset: 0x006C5FB5
		public byte NullMask { get; set; }

		// Token: 0x060322C3 RID: 205507 RVA: 0x006C7DBE File Offset: 0x006C5FBE
		public IRogueRandomEventOptionT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.EventId = 0;
			this.NullMask = 0;
		}
	}
}
