using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E3 RID: 6115
	[NullableContext(2)]
	[Nullable(0)]
	public class IAstrologyTextUiConfig_SetValue
	{
		// Token: 0x04005355 RID: 21333
		public ETextUiType Type;

		// Token: 0x04005356 RID: 21334
		public string InitTipText;

		// Token: 0x04005357 RID: 21335
		public string ProgressTipText;

		// Token: 0x04005358 RID: 21336
		public string SkipText;

		// Token: 0x04005359 RID: 21337
		public string FinishText;

		// Token: 0x0400535A RID: 21338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> InitDialogues;

		// Token: 0x0400535B RID: 21339
		public int? SkipConfirmBoxId;

		// Token: 0x0400535C RID: 21340
		public string LoopAudioEvent;
	}
}
