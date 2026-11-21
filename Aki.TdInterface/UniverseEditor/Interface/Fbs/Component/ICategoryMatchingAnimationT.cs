using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548B RID: 21643
	public class ICategoryMatchingAnimationT
	{
		// Token: 0x17009A22 RID: 39458
		// (get) Token: 0x060220C3 RID: 139459 RVA: 0x004B18F1 File Offset: 0x004AFAF1
		// (set) Token: 0x060220C4 RID: 139460 RVA: 0x004B18F9 File Offset: 0x004AFAF9
		public IVectorInfoT MatchPos { get; set; }

		// Token: 0x17009A23 RID: 39459
		// (get) Token: 0x060220C5 RID: 139461 RVA: 0x004B1902 File Offset: 0x004AFB02
		// (set) Token: 0x060220C6 RID: 139462 RVA: 0x004B190A File Offset: 0x004AFB0A
		public IVectorInfoT MatchRot { get; set; }

		// Token: 0x17009A24 RID: 39460
		// (get) Token: 0x060220C7 RID: 139463 RVA: 0x004B1913 File Offset: 0x004AFB13
		// (set) Token: 0x060220C8 RID: 139464 RVA: 0x004B191B File Offset: 0x004AFB1B
		public string MatchReferenceKey { get; set; }

		// Token: 0x17009A25 RID: 39461
		// (get) Token: 0x060220C9 RID: 139465 RVA: 0x004B1924 File Offset: 0x004AFB24
		// (set) Token: 0x060220CA RID: 139466 RVA: 0x004B192C File Offset: 0x004AFB2C
		public string MatchSequence { get; set; }

		// Token: 0x17009A26 RID: 39462
		// (get) Token: 0x060220CB RID: 139467 RVA: 0x004B1935 File Offset: 0x004AFB35
		// (set) Token: 0x060220CC RID: 139468 RVA: 0x004B193D File Offset: 0x004AFB3D
		public IVectorInfoT MatchSequenceOffset { get; set; }

		// Token: 0x060220CD RID: 139469 RVA: 0x004B1946 File Offset: 0x004AFB46
		public ICategoryMatchingAnimationT()
		{
			this.MatchPos = null;
			this.MatchRot = null;
			this.MatchReferenceKey = null;
			this.MatchSequence = null;
			this.MatchSequenceOffset = null;
		}
	}
}
