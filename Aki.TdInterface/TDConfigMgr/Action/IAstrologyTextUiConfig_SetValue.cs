using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196C RID: 6508
	[NullableContext(2)]
	[Nullable(0)]
	public class IAstrologyTextUiConfig_SetValue
	{
		// Token: 0x0400579D RID: 22429
		public ETextUiType Type;

		// Token: 0x0400579E RID: 22430
		public string InitTipText;

		// Token: 0x0400579F RID: 22431
		public string ProgressTipText;

		// Token: 0x040057A0 RID: 22432
		public string SkipText;

		// Token: 0x040057A1 RID: 22433
		public string FinishText;

		// Token: 0x040057A2 RID: 22434
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> InitDialogues;

		// Token: 0x040057A3 RID: 22435
		public int? SkipConfirmBoxId;

		// Token: 0x040057A4 RID: 22436
		public string LoopAudioEvent;
	}
}
