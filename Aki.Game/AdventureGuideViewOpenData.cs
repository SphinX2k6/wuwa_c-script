using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000B4C RID: 2892
public class AdventureGuideViewOpenData
{
	// Token: 0x04004B49 RID: 19273
	public EUiTabViewName? OpenTabViewName;

	// Token: 0x04004B4A RID: 19274
	public int? OpenParam;

	// Token: 0x04004B4B RID: 19275
	[Nullable(1)]
	public int[] NewSoundDetectTracingIdList = new int[0];

	// Token: 0x04004B4C RID: 19276
	public bool SkipAdventureManualRequest;

	// Token: 0x04004B4D RID: 19277
	public int? JumpToGridId;
}
