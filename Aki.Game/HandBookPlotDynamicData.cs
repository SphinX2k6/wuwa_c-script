using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

// Token: 0x020012BA RID: 4794
[NullableContext(2)]
[Nullable(0)]
public class HandBookPlotDynamicData
{
	// Token: 0x04006D2C RID: 27948
	public PlotAudio? PlotAudio;

	// Token: 0x04006D2D RID: 27949
	public string TalkOwnerName;

	// Token: 0x04006D2E RID: 27950
	public string TalkText;

	// Token: 0x04006D2F RID: 27951
	public ITalkOption TalkOption;

	// Token: 0x04006D30 RID: 27952
	public int TalkItemId = -1;

	// Token: 0x04006D31 RID: 27953
	public int PlotId = -1;

	// Token: 0x04006D32 RID: 27954
	public bool? IsChoseOption = new bool?(false);

	// Token: 0x04006D33 RID: 27955
	public int? OptionIndex = new int?(0);

	// Token: 0x04006D34 RID: 27956
	public bool? OptionTalker;

	// Token: 0x04006D35 RID: 27957
	public int MoveId;

	// Token: 0x04006D36 RID: 27958
	public string NodeText;

	// Token: 0x04006D37 RID: 27959
	[Nullable(1)]
	public string BelongToNode = "";
}
