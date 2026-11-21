using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725C RID: 29276
	public class IMotorParkourTrackingEventT
	{
		// Token: 0x1700D6AB RID: 54955
		// (get) Token: 0x06033029 RID: 208937 RVA: 0x006E2C9D File Offset: 0x006E0E9D
		// (set) Token: 0x0603302A RID: 208938 RVA: 0x006E2CA5 File Offset: 0x006E0EA5
		public ETrackingEventType Type { get; set; }

		// Token: 0x1700D6AC RID: 54956
		// (get) Token: 0x0603302B RID: 208939 RVA: 0x006E2CAE File Offset: 0x006E0EAE
		// (set) Token: 0x0603302C RID: 208940 RVA: 0x006E2CB6 File Offset: 0x006E0EB6
		public EMotorParkourPhase MotorParkourPhase { get; set; }

		// Token: 0x1700D6AD RID: 54957
		// (get) Token: 0x0603302D RID: 208941 RVA: 0x006E2CBF File Offset: 0x006E0EBF
		// (set) Token: 0x0603302E RID: 208942 RVA: 0x006E2CC7 File Offset: 0x006E0EC7
		public TVarRefUnion MotorParkourScoreVarRef { get; set; }

		// Token: 0x0603302F RID: 208943 RVA: 0x006E2CD0 File Offset: 0x006E0ED0
		public IMotorParkourTrackingEventT()
		{
			this.Type = ETrackingEventType.EasterEgg;
			this.MotorParkourPhase = EMotorParkourPhase.Start;
			this.MotorParkourScoreVarRef = null;
		}
	}
}
