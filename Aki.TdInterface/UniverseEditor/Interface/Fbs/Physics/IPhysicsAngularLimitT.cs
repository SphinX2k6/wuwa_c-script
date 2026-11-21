using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047AE RID: 18350
	public class IPhysicsAngularLimitT
	{
		// Token: 0x17007FD4 RID: 32724
		// (get) Token: 0x0601B054 RID: 110676 RVA: 0x003D4204 File Offset: 0x003D2404
		// (set) Token: 0x0601B055 RID: 110677 RVA: 0x003D420C File Offset: 0x003D240C
		public TAngularConstraintMotionUnion Swing1Motion { get; set; }

		// Token: 0x17007FD5 RID: 32725
		// (get) Token: 0x0601B056 RID: 110678 RVA: 0x003D4215 File Offset: 0x003D2415
		// (set) Token: 0x0601B057 RID: 110679 RVA: 0x003D421D File Offset: 0x003D241D
		public TAngularConstraintMotionUnion Swing2Motion { get; set; }

		// Token: 0x17007FD6 RID: 32726
		// (get) Token: 0x0601B058 RID: 110680 RVA: 0x003D4226 File Offset: 0x003D2426
		// (set) Token: 0x0601B059 RID: 110681 RVA: 0x003D422E File Offset: 0x003D242E
		public TAngularConstraintMotionUnion TwistMotion { get; set; }

		// Token: 0x17007FD7 RID: 32727
		// (get) Token: 0x0601B05A RID: 110682 RVA: 0x003D4237 File Offset: 0x003D2437
		// (set) Token: 0x0601B05B RID: 110683 RVA: 0x003D423F File Offset: 0x003D243F
		public IVectorInfoT AngularRotationOffset { get; set; }

		// Token: 0x0601B05C RID: 110684 RVA: 0x003D4248 File Offset: 0x003D2448
		public IPhysicsAngularLimitT()
		{
			this.Swing1Motion = null;
			this.Swing2Motion = null;
			this.TwistMotion = null;
			this.AngularRotationOffset = null;
		}
	}
}
