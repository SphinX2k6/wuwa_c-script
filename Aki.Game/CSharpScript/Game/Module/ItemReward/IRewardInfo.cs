using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200478B RID: 18315
	[NullableContext(2)]
	public interface IRewardInfo
	{
		// Token: 0x17005CEC RID: 23788
		// (get) Token: 0x0602E056 RID: 188502
		// (set) Token: 0x0602E057 RID: 188503
		ERewardInfoType Type { get; set; }

		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x0602E058 RID: 188504
		// (set) Token: 0x0602E059 RID: 188505
		EUiViewName ViewName { get; set; }

		// Token: 0x17005CEE RID: 23790
		// (get) Token: 0x0602E05A RID: 188506
		// (set) Token: 0x0602E05B RID: 188507
		string AudioId { get; set; }
	}
}
