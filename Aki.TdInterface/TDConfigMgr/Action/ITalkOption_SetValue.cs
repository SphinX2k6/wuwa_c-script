using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A4 RID: 8612
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOption_SetValue
	{
		// Token: 0x040070F7 RID: 28919
		public string TidTalkOption;

		// Token: 0x040070F8 RID: 28920
		public int? TextId;

		// Token: 0x040070F9 RID: 28921
		public int? PlotLineId;

		// Token: 0x040070FA RID: 28922
		public string PlotLineKey;

		// Token: 0x040070FB RID: 28923
		public int? Icon;

		// Token: 0x040070FC RID: 28924
		public IChangeIcon ChangeIcon;

		// Token: 0x040070FD RID: 28925
		public bool? ReadMarkEnabled;

		// Token: 0x040070FE RID: 28926
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040070FF RID: 28927
		public ETalkOptionStyle? OptionStyle;

		// Token: 0x04007100 RID: 28928
		public ITalkOptionPreConditionBase PreCondition;

		// Token: 0x04007101 RID: 28929
		public bool? _folded;

		// Token: 0x04007102 RID: 28930
		public EEditFlag? _editFlag;

		// Token: 0x04007103 RID: 28931
		public IOptionLockTip OptionLockTip;

		// Token: 0x04007104 RID: 28932
		public ITalkOptionParamType TypeParams;

		// Token: 0x04007105 RID: 28933
		public bool? HiddenOption;

		// Token: 0x04007106 RID: 28934
		public string EdOptionComment;
	}
}
