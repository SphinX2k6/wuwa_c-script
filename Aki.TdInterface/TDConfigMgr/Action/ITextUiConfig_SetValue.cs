using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002202 RID: 8706
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextUiConfig_SetValue
	{
		// Token: 0x040071E9 RID: 29161
		public ETextUiType Type;

		// Token: 0x040071EA RID: 29162
		public string InitTipText;

		// Token: 0x040071EB RID: 29163
		public string ProgressTipText;

		// Token: 0x040071EC RID: 29164
		public string SkipText;

		// Token: 0x040071ED RID: 29165
		public string FinishText;

		// Token: 0x040071EE RID: 29166
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> InitDialogues;

		// Token: 0x040071EF RID: 29167
		public int? SkipConfirmBoxId;

		// Token: 0x040071F0 RID: 29168
		public string LoopAudioEvent;
	}
}
