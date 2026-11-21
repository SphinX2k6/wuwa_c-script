using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007455 RID: 29781
	public class IPlayDissolveEffectInActorPosConfigT
	{
		// Token: 0x1700DAE0 RID: 56032
		// (get) Token: 0x0603422B RID: 213547 RVA: 0x0070653E File Offset: 0x0070473E
		// (set) Token: 0x0603422C RID: 213548 RVA: 0x00706546 File Offset: 0x00704746
		public EAspectRatio AspectRatio { get; set; }

		// Token: 0x0603422D RID: 213549 RVA: 0x0070654F File Offset: 0x0070474F
		public IPlayDissolveEffectInActorPosConfigT()
		{
			this.AspectRatio = EAspectRatio.Ratio16x9;
		}
	}
}
