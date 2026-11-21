using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548E RID: 21646
	public class ICategoryMatchingAnimationBaseT
	{
		// Token: 0x17009A2B RID: 39467
		// (get) Token: 0x060220E3 RID: 139491 RVA: 0x004B1D26 File Offset: 0x004AFF26
		// (set) Token: 0x060220E4 RID: 139492 RVA: 0x004B1D2E File Offset: 0x004AFF2E
		public IVectorInfoT MatchPos { get; set; }

		// Token: 0x17009A2C RID: 39468
		// (get) Token: 0x060220E5 RID: 139493 RVA: 0x004B1D37 File Offset: 0x004AFF37
		// (set) Token: 0x060220E6 RID: 139494 RVA: 0x004B1D3F File Offset: 0x004AFF3F
		public IVectorInfoT MatchRot { get; set; }

		// Token: 0x17009A2D RID: 39469
		// (get) Token: 0x060220E7 RID: 139495 RVA: 0x004B1D48 File Offset: 0x004AFF48
		// (set) Token: 0x060220E8 RID: 139496 RVA: 0x004B1D50 File Offset: 0x004AFF50
		public string MatchReferenceKey { get; set; }

		// Token: 0x060220E9 RID: 139497 RVA: 0x004B1D59 File Offset: 0x004AFF59
		public ICategoryMatchingAnimationBaseT()
		{
			this.MatchPos = null;
			this.MatchRot = null;
			this.MatchReferenceKey = null;
		}
	}
}
