using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F69 RID: 8041
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOption_SetValue
	{
		// Token: 0x04006B0F RID: 27407
		public string TidTalkOption;

		// Token: 0x04006B10 RID: 27408
		public int? TextId;

		// Token: 0x04006B11 RID: 27409
		public int? PlotLineId;

		// Token: 0x04006B12 RID: 27410
		public string PlotLineKey;

		// Token: 0x04006B13 RID: 27411
		public int? Icon;

		// Token: 0x04006B14 RID: 27412
		public IChangeIcon ChangeIcon;

		// Token: 0x04006B15 RID: 27413
		public bool? ReadMarkEnabled;

		// Token: 0x04006B16 RID: 27414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006B17 RID: 27415
		public ETalkOptionStyle? OptionStyle;

		// Token: 0x04006B18 RID: 27416
		public ITalkOptionPreConditionBase PreCondition;

		// Token: 0x04006B19 RID: 27417
		public bool? _folded;

		// Token: 0x04006B1A RID: 27418
		public EEditFlag? _editFlag;

		// Token: 0x04006B1B RID: 27419
		public IOptionLockTip OptionLockTip;

		// Token: 0x04006B1C RID: 27420
		public ITalkOptionParamType TypeParams;

		// Token: 0x04006B1D RID: 27421
		public bool? HiddenOption;

		// Token: 0x04006B1E RID: 27422
		public string EdOptionComment;
	}
}
