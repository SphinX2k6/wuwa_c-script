using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E32 RID: 28210
	public class IReignsSetUiEffectT
	{
		// Token: 0x1700D239 RID: 53817
		// (get) Token: 0x06031D84 RID: 204164 RVA: 0x006BF19F File Offset: 0x006BD39F
		// (set) Token: 0x06031D85 RID: 204165 RVA: 0x006BF1A7 File Offset: 0x006BD3A7
		public string Effect { get; set; }

		// Token: 0x1700D23A RID: 53818
		// (get) Token: 0x06031D86 RID: 204166 RVA: 0x006BF1B0 File Offset: 0x006BD3B0
		// (set) Token: 0x06031D87 RID: 204167 RVA: 0x006BF1B8 File Offset: 0x006BD3B8
		public bool IsVisible { get; set; }

		// Token: 0x06031D88 RID: 204168 RVA: 0x006BF1C1 File Offset: 0x006BD3C1
		public IReignsSetUiEffectT()
		{
			this.Effect = null;
			this.IsVisible = false;
		}
	}
}
