using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBF RID: 8127
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextUiConfig_SetValue
	{
		// Token: 0x04006BEE RID: 27630
		public ETextUiType Type;

		// Token: 0x04006BEF RID: 27631
		public string InitTipText;

		// Token: 0x04006BF0 RID: 27632
		public string ProgressTipText;

		// Token: 0x04006BF1 RID: 27633
		public string SkipText;

		// Token: 0x04006BF2 RID: 27634
		public string FinishText;

		// Token: 0x04006BF3 RID: 27635
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> InitDialogues;

		// Token: 0x04006BF4 RID: 27636
		public int? SkipConfirmBoxId;

		// Token: 0x04006BF5 RID: 27637
		public string LoopAudioEvent;
	}
}
