using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B59 RID: 23385
	public class IMotorHookEndDirT
	{
		// Token: 0x1700AABE RID: 43710
		// (get) Token: 0x060267CE RID: 157646 RVA: 0x00545597 File Offset: 0x00543797
		// (set) Token: 0x060267CF RID: 157647 RVA: 0x0054559F File Offset: 0x0054379F
		public IVectorInfoT EndRot { get; set; }

		// Token: 0x1700AABF RID: 43711
		// (get) Token: 0x060267D0 RID: 157648 RVA: 0x005455A8 File Offset: 0x005437A8
		// (set) Token: 0x060267D1 RID: 157649 RVA: 0x005455B0 File Offset: 0x005437B0
		public string TransitionCurve { get; set; }

		// Token: 0x060267D2 RID: 157650 RVA: 0x005455B9 File Offset: 0x005437B9
		public IMotorHookEndDirT()
		{
			this.EndRot = null;
			this.TransitionCurve = null;
		}
	}
}
