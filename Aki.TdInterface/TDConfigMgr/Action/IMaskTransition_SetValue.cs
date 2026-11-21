using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA8 RID: 7592
	[NullableContext(2)]
	[Nullable(0)]
	public class IMaskTransition_SetValue
	{
		// Token: 0x040061E8 RID: 25064
		public ELevelSequenceTransition Type;

		// Token: 0x040061E9 RID: 25065
		public float? Duration;

		// Token: 0x040061EA RID: 25066
		public ETransitionMask Mask;

		// Token: 0x040061EB RID: 25067
		public IEaseData FadeIn;

		// Token: 0x040061EC RID: 25068
		public IEaseData FadeOut;
	}
}
