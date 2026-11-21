using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005573 RID: 21875
	public interface IPanelPosRange
	{
		// Token: 0x17006920 RID: 26912
		// (get) Token: 0x06036393 RID: 222099
		// (set) Token: 0x06036394 RID: 222100
		int RowStartIndex { get; set; }

		// Token: 0x17006921 RID: 26913
		// (get) Token: 0x06036395 RID: 222101
		// (set) Token: 0x06036396 RID: 222102
		int RowEndIndex { get; set; }

		// Token: 0x17006922 RID: 26914
		// (get) Token: 0x06036397 RID: 222103
		// (set) Token: 0x06036398 RID: 222104
		int ColStartIndex { get; set; }

		// Token: 0x17006923 RID: 26915
		// (get) Token: 0x06036399 RID: 222105
		// (set) Token: 0x0603639A RID: 222106
		int ColEndIndex { get; set; }
	}
}
