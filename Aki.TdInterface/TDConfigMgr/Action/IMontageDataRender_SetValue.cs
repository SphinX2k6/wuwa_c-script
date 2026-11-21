using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF4 RID: 7668
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageDataRender_SetValue
	{
		// Token: 0x040062B4 RID: 25268
		public int ActorIndex;

		// Token: 0x040062B5 RID: 25269
		public IMontageParam BaseMontage;

		// Token: 0x040062B6 RID: 25270
		public bool? EndLoopingMontage;

		// Token: 0x040062B7 RID: 25271
		public bool? EndMontageDirectly;

		// Token: 0x040062B8 RID: 25272
		public bool? StartFromLoop;

		// Token: 0x040062B9 RID: 25273
		public IMontageParam OverlayMontage;

		// Token: 0x040062BA RID: 25274
		public int? FaceExpressionId;

		// Token: 0x040062BB RID: 25275
		public bool? KeepFaceExpression;

		// Token: 0x040062BC RID: 25276
		public float? DelayTime;

		// Token: 0x040062BD RID: 25277
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmotePlay> FxEmote;
	}
}
