using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001694 RID: 5780
public class AdventureGuideViewOpenData
{
	// Token: 0x04004AA2 RID: 19106
	public EUiTabViewName? OpenTabViewName;

	// Token: 0x04004AA3 RID: 19107
	public int? OpenParam;

	// Token: 0x04004AA4 RID: 19108
	[Nullable(1)]
	public int[] NewSoundDetectTracingIdList = new int[0];

	// Token: 0x04004AA5 RID: 19109
	public bool SkipAdventureManualRequest;

	// Token: 0x04004AA6 RID: 19110
	public int? JumpToGridId;
}
