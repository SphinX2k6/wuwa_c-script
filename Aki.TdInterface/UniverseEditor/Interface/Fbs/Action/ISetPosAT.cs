using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705C RID: 28764
	public class ISetPosAT
	{
		// Token: 0x1700D5D4 RID: 54740
		// (get) Token: 0x06032EF2 RID: 208626 RVA: 0x006DF401 File Offset: 0x006DD601
		// (set) Token: 0x06032EF3 RID: 208627 RVA: 0x006DF409 File Offset: 0x006DD609
		public IPosAT Pos { get; set; }

		// Token: 0x06032EF4 RID: 208628 RVA: 0x006DF412 File Offset: 0x006DD612
		public ISetPosAT()
		{
			this.Pos = null;
		}
	}
}
