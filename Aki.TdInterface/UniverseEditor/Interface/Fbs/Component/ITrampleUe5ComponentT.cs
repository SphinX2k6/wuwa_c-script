using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E3 RID: 24803
	public class ITrampleUe5ComponentT
	{
		// Token: 0x1700B87C RID: 47228
		// (get) Token: 0x0602A01A RID: 172058 RVA: 0x005BBE90 File Offset: 0x005BA090
		// (set) Token: 0x0602A01B RID: 172059 RVA: 0x005BBE98 File Offset: 0x005BA098
		public bool Disabled { get; set; }

		// Token: 0x1700B87D RID: 47229
		// (get) Token: 0x0602A01C RID: 172060 RVA: 0x005BBEA1 File Offset: 0x005BA0A1
		// (set) Token: 0x0602A01D RID: 172061 RVA: 0x005BBEA9 File Offset: 0x005BA0A9
		public bool IsDisposable { get; set; }

		// Token: 0x1700B87E RID: 47230
		// (get) Token: 0x0602A01E RID: 172062 RVA: 0x005BBEB2 File Offset: 0x005BA0B2
		// (set) Token: 0x0602A01F RID: 172063 RVA: 0x005BBEBA File Offset: 0x005BA0BA
		public List<IActionInfoT> TriggerActions { get; set; }

		// Token: 0x1700B87F RID: 47231
		// (get) Token: 0x0602A020 RID: 172064 RVA: 0x005BBEC3 File Offset: 0x005BA0C3
		// (set) Token: 0x0602A021 RID: 172065 RVA: 0x005BBECB File Offset: 0x005BA0CB
		public List<IActionInfoT> RecoveryActions { get; set; }

		// Token: 0x1700B880 RID: 47232
		// (get) Token: 0x0602A022 RID: 172066 RVA: 0x005BBED4 File Offset: 0x005BA0D4
		// (set) Token: 0x0602A023 RID: 172067 RVA: 0x005BBEDC File Offset: 0x005BA0DC
		public byte NullMask { get; set; }

		// Token: 0x0602A024 RID: 172068 RVA: 0x005BBEE5 File Offset: 0x005BA0E5
		public ITrampleUe5ComponentT()
		{
			this.Disabled = false;
			this.IsDisposable = false;
			this.TriggerActions = null;
			this.RecoveryActions = null;
			this.NullMask = 0;
		}
	}
}
