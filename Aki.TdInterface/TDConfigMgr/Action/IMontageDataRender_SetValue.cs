using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C05 RID: 7173
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageDataRender_SetValue
	{
		// Token: 0x04005D8D RID: 23949
		public int ActorIndex;

		// Token: 0x04005D8E RID: 23950
		public IMontageParam BaseMontage;

		// Token: 0x04005D8F RID: 23951
		public bool? EndLoopingMontage;

		// Token: 0x04005D90 RID: 23952
		public bool? EndMontageDirectly;

		// Token: 0x04005D91 RID: 23953
		public bool? StartFromLoop;

		// Token: 0x04005D92 RID: 23954
		public IMontageParam OverlayMontage;

		// Token: 0x04005D93 RID: 23955
		public int? FaceExpressionId;

		// Token: 0x04005D94 RID: 23956
		public bool? KeepFaceExpression;

		// Token: 0x04005D95 RID: 23957
		public float? DelayTime;

		// Token: 0x04005D96 RID: 23958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmotePlay> FxEmote;
	}
}
