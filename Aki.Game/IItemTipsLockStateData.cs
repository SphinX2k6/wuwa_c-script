using System;
using System.Runtime.CompilerServices;

// Token: 0x020018F2 RID: 6386
[NullableContext(2)]
public interface IItemTipsLockStateData
{
	// Token: 0x17000F92 RID: 3986
	// (get) Token: 0x0600BB24 RID: 47908
	bool? IsShowLockIcon { get; }

	// Token: 0x17000F93 RID: 3987
	// (get) Token: 0x0600BB25 RID: 47909
	bool? IsShowHelpButton { get; }

	// Token: 0x17000F94 RID: 3988
	// (get) Token: 0x0600BB26 RID: 47910
	string TipsTextKey { get; }

	// Token: 0x17000F95 RID: 3989
	// (get) Token: 0x0600BB27 RID: 47911
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

	// Token: 0x17000F96 RID: 3990
	// (get) Token: 0x0600BB28 RID: 47912
	Action HelpBtnCallback { get; }
}
