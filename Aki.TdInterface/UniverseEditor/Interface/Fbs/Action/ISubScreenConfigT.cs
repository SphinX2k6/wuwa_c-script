using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D8 RID: 31192
	public class ISubScreenConfigT
	{
		// Token: 0x1700E4AD RID: 58541
		// (get) Token: 0x06036F52 RID: 225106 RVA: 0x007590B6 File Offset: 0x007572B6
		// (set) Token: 0x06036F53 RID: 225107 RVA: 0x007590BE File Offset: 0x007572BE
		public IVector2T Anchor { get; set; }

		// Token: 0x1700E4AE RID: 58542
		// (get) Token: 0x06036F54 RID: 225108 RVA: 0x007590C7 File Offset: 0x007572C7
		// (set) Token: 0x06036F55 RID: 225109 RVA: 0x007590CF File Offset: 0x007572CF
		public IVector2T Size { get; set; }

		// Token: 0x1700E4AF RID: 58543
		// (get) Token: 0x06036F56 RID: 225110 RVA: 0x007590D8 File Offset: 0x007572D8
		// (set) Token: 0x06036F57 RID: 225111 RVA: 0x007590E0 File Offset: 0x007572E0
		public bool IsSeamlessScreen { get; set; }

		// Token: 0x1700E4B0 RID: 58544
		// (get) Token: 0x06036F58 RID: 225112 RVA: 0x007590E9 File Offset: 0x007572E9
		// (set) Token: 0x06036F59 RID: 225113 RVA: 0x007590F1 File Offset: 0x007572F1
		public byte NullMask { get; set; }

		// Token: 0x06036F5A RID: 225114 RVA: 0x007590FA File Offset: 0x007572FA
		public ISubScreenConfigT()
		{
			this.Anchor = null;
			this.Size = null;
			this.IsSeamlessScreen = false;
			this.NullMask = 0;
		}
	}
}
