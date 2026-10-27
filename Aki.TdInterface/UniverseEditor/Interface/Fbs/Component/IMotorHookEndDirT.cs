using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BB RID: 21947
	public class IMotorHookEndDirT
	{
		// Token: 0x1700A236 RID: 41526
		// (get) Token: 0x060245C1 RID: 148929 RVA: 0x0050501F File Offset: 0x0050321F
		// (set) Token: 0x060245C2 RID: 148930 RVA: 0x00505027 File Offset: 0x00503227
		public IVectorInfoT EndRot { get; set; }

		// Token: 0x1700A237 RID: 41527
		// (get) Token: 0x060245C3 RID: 148931 RVA: 0x00505030 File Offset: 0x00503230
		// (set) Token: 0x060245C4 RID: 148932 RVA: 0x00505038 File Offset: 0x00503238
		public string TransitionCurve { get; set; }

		// Token: 0x060245C5 RID: 148933 RVA: 0x00505041 File Offset: 0x00503241
		public IMotorHookEndDirT()
		{
			this.EndRot = null;
			this.TransitionCurve = null;
		}
	}
}
