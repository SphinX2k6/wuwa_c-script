using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFD RID: 27901
	public class IPlayerLookAtT
	{
		// Token: 0x1700CFC9 RID: 53193
		// (get) Token: 0x06031331 RID: 201521 RVA: 0x006ACA27 File Offset: 0x006AAC27
		// (set) Token: 0x06031332 RID: 201522 RVA: 0x006ACA2F File Offset: 0x006AAC2F
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700CFCA RID: 53194
		// (get) Token: 0x06031333 RID: 201523 RVA: 0x006ACA38 File Offset: 0x006AAC38
		// (set) Token: 0x06031334 RID: 201524 RVA: 0x006ACA40 File Offset: 0x006AAC40
		public bool CameraMove { get; set; }

		// Token: 0x1700CFCB RID: 53195
		// (get) Token: 0x06031335 RID: 201525 RVA: 0x006ACA49 File Offset: 0x006AAC49
		// (set) Token: 0x06031336 RID: 201526 RVA: 0x006ACA51 File Offset: 0x006AAC51
		public bool PlayAnimation { get; set; }

		// Token: 0x1700CFCC RID: 53196
		// (get) Token: 0x06031337 RID: 201527 RVA: 0x006ACA5A File Offset: 0x006AAC5A
		// (set) Token: 0x06031338 RID: 201528 RVA: 0x006ACA62 File Offset: 0x006AAC62
		public byte NullMask { get; set; }

		// Token: 0x06031339 RID: 201529 RVA: 0x006ACA6B File Offset: 0x006AAC6B
		public IPlayerLookAtT()
		{
			this.Pos = null;
			this.CameraMove = false;
			this.PlayAnimation = false;
			this.NullMask = 0;
		}
	}
}
