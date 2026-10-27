using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC1 RID: 7105
	[NullableContext(2)]
	[Nullable(0)]
	public class IMaskTransition_SetValue
	{
		// Token: 0x04005CD3 RID: 23763
		public ELevelSequenceTransition Type;

		// Token: 0x04005CD4 RID: 23764
		public float? Duration;

		// Token: 0x04005CD5 RID: 23765
		public ETransitionMask Mask;

		// Token: 0x04005CD6 RID: 23766
		public IEaseData FadeIn;

		// Token: 0x04005CD7 RID: 23767
		public IEaseData FadeOut;
	}
}
