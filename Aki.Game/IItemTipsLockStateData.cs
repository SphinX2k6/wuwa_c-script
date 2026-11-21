using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DAB RID: 3499
[NullableContext(2)]
public interface IItemTipsLockStateData
{
	// Token: 0x17000FB5 RID: 4021
	// (get) Token: 0x06008F0E RID: 36622
	bool? IsShowLockIcon { get; }

	// Token: 0x17000FB6 RID: 4022
	// (get) Token: 0x06008F0F RID: 36623
	bool? IsShowHelpButton { get; }

	// Token: 0x17000FB7 RID: 4023
	// (get) Token: 0x06008F10 RID: 36624
	string TipsTextKey { get; }

	// Token: 0x17000FB8 RID: 4024
	// (get) Token: 0x06008F11 RID: 36625
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] TipsTextParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }

	// Token: 0x17000FB9 RID: 4025
	// (get) Token: 0x06008F12 RID: 36626
	Action HelpBtnCallback { get; }
}
