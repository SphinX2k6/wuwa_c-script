using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF2 RID: 7666
	public class IMontageData_SetValue
	{
		// Token: 0x0400629F RID: 25247
		public int ActorIndex;

		// Token: 0x040062A0 RID: 25248
		public int? MontageId;

		// Token: 0x040062A1 RID: 25249
		public bool? IsAbpMontage;

		// Token: 0x040062A2 RID: 25250
		public bool? IsLoop;

		// Token: 0x040062A3 RID: 25251
		public bool? KeepPose;

		// Token: 0x040062A4 RID: 25252
		public float? DelayTime;

		// Token: 0x040062A5 RID: 25253
		public bool? EndLoopingMontage;

		// Token: 0x040062A6 RID: 25254
		public bool? EndMontageDirectly;

		// Token: 0x040062A7 RID: 25255
		public bool? StartFromLoop;

		// Token: 0x040062A8 RID: 25256
		[Nullable(2)]
		public IMontageParam OverlayMontage;

		// Token: 0x040062A9 RID: 25257
		public int? FaceExpressionId;

		// Token: 0x040062AA RID: 25258
		public bool? KeepFaceExpression;

		// Token: 0x040062AB RID: 25259
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmotePlay> FxEmote;
	}
}
