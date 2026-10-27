using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C03 RID: 7171
	public class IMontageData_SetValue
	{
		// Token: 0x04005D78 RID: 23928
		public int ActorIndex;

		// Token: 0x04005D79 RID: 23929
		public int? MontageId;

		// Token: 0x04005D7A RID: 23930
		public bool? IsAbpMontage;

		// Token: 0x04005D7B RID: 23931
		public bool? IsLoop;

		// Token: 0x04005D7C RID: 23932
		public bool? KeepPose;

		// Token: 0x04005D7D RID: 23933
		public float? DelayTime;

		// Token: 0x04005D7E RID: 23934
		public bool? EndLoopingMontage;

		// Token: 0x04005D7F RID: 23935
		public bool? EndMontageDirectly;

		// Token: 0x04005D80 RID: 23936
		public bool? StartFromLoop;

		// Token: 0x04005D81 RID: 23937
		[Nullable(2)]
		public IMontageParam OverlayMontage;

		// Token: 0x04005D82 RID: 23938
		public int? FaceExpressionId;

		// Token: 0x04005D83 RID: 23939
		public bool? KeepFaceExpression;

		// Token: 0x04005D84 RID: 23940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmotePlay> FxEmote;
	}
}
