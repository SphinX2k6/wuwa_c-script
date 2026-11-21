using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B9 RID: 28857
	public class ILiftMoveTypeDefaultT
	{
		// Token: 0x1700D366 RID: 54118
		// (get) Token: 0x060321C5 RID: 205253 RVA: 0x006C81A6 File Offset: 0x006C63A6
		// (set) Token: 0x060321C6 RID: 205254 RVA: 0x006C81AE File Offset: 0x006C63AE
		public ELiftMoveType Type { get; set; }

		// Token: 0x060321C7 RID: 205255 RVA: 0x006C81B7 File Offset: 0x006C63B7
		public ILiftMoveTypeDefaultT()
		{
			this.Type = ELiftMoveType.Default;
		}
	}
}
