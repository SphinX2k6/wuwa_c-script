using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200434C RID: 17228
	public class IPhysicsAngularLimitT
	{
		// Token: 0x1700799F RID: 31135
		// (get) Token: 0x060198C6 RID: 104646 RVA: 0x003A87DC File Offset: 0x003A69DC
		// (set) Token: 0x060198C7 RID: 104647 RVA: 0x003A87E4 File Offset: 0x003A69E4
		public TAngularConstraintMotionUnion Swing1Motion { get; set; }

		// Token: 0x170079A0 RID: 31136
		// (get) Token: 0x060198C8 RID: 104648 RVA: 0x003A87ED File Offset: 0x003A69ED
		// (set) Token: 0x060198C9 RID: 104649 RVA: 0x003A87F5 File Offset: 0x003A69F5
		public TAngularConstraintMotionUnion Swing2Motion { get; set; }

		// Token: 0x170079A1 RID: 31137
		// (get) Token: 0x060198CA RID: 104650 RVA: 0x003A87FE File Offset: 0x003A69FE
		// (set) Token: 0x060198CB RID: 104651 RVA: 0x003A8806 File Offset: 0x003A6A06
		public TAngularConstraintMotionUnion TwistMotion { get; set; }

		// Token: 0x170079A2 RID: 31138
		// (get) Token: 0x060198CC RID: 104652 RVA: 0x003A880F File Offset: 0x003A6A0F
		// (set) Token: 0x060198CD RID: 104653 RVA: 0x003A8817 File Offset: 0x003A6A17
		public IVectorInfoT AngularRotationOffset { get; set; }

		// Token: 0x060198CE RID: 104654 RVA: 0x003A8820 File Offset: 0x003A6A20
		public IPhysicsAngularLimitT()
		{
			this.Swing1Motion = null;
			this.Swing2Motion = null;
			this.TwistMotion = null;
			this.AngularRotationOffset = null;
		}
	}
}
