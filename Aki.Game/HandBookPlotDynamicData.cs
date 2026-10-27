using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

// Token: 0x02001DF8 RID: 7672
[NullableContext(2)]
[Nullable(0)]
public class HandBookPlotDynamicData
{
	// Token: 0x04006C4B RID: 27723
	public PlotAudio? PlotAudio;

	// Token: 0x04006C4C RID: 27724
	public string TalkOwnerName;

	// Token: 0x04006C4D RID: 27725
	public string TalkText;

	// Token: 0x04006C4E RID: 27726
	public ITalkOption TalkOption;

	// Token: 0x04006C4F RID: 27727
	public int TalkItemId = -1;

	// Token: 0x04006C50 RID: 27728
	public int PlotId = -1;

	// Token: 0x04006C51 RID: 27729
	public bool? IsChoseOption = new bool?(false);

	// Token: 0x04006C52 RID: 27730
	public int? OptionIndex = new int?(0);

	// Token: 0x04006C53 RID: 27731
	public bool? OptionTalker;

	// Token: 0x04006C54 RID: 27732
	public int MoveId;

	// Token: 0x04006C55 RID: 27733
	public string NodeText;

	// Token: 0x04006C56 RID: 27734
	[Nullable(1)]
	public string BelongToNode = "";
}
