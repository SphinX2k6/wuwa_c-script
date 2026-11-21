using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535F RID: 21343
	public class IActivateSpecifiedPieceConfigT
	{
		// Token: 0x170096AF RID: 38575
		// (get) Token: 0x060213B7 RID: 136119 RVA: 0x0049621B File Offset: 0x0049441B
		// (set) Token: 0x060213B8 RID: 136120 RVA: 0x00496223 File Offset: 0x00494423
		public IJigsawConfigT Jigsaw { get; set; }

		// Token: 0x170096B0 RID: 38576
		// (get) Token: 0x060213B9 RID: 136121 RVA: 0x0049622C File Offset: 0x0049442C
		// (set) Token: 0x060213BA RID: 136122 RVA: 0x00496234 File Offset: 0x00494434
		public string SelfState { get; set; }

		// Token: 0x060213BB RID: 136123 RVA: 0x0049623D File Offset: 0x0049443D
		public IActivateSpecifiedPieceConfigT()
		{
			this.Jigsaw = null;
			this.SelfState = null;
		}
	}
}
