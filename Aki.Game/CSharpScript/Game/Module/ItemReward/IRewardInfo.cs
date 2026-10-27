using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B4 RID: 22452
	[NullableContext(2)]
	public interface IRewardInfo
	{
		// Token: 0x17008924 RID: 35108
		// (get) Token: 0x06039146 RID: 233798
		// (set) Token: 0x06039147 RID: 233799
		ERewardInfoType Type { get; set; }

		// Token: 0x17008925 RID: 35109
		// (get) Token: 0x06039148 RID: 233800
		// (set) Token: 0x06039149 RID: 233801
		EUiViewName ViewName { get; set; }

		// Token: 0x17008926 RID: 35110
		// (get) Token: 0x0603914A RID: 233802
		// (set) Token: 0x0603914B RID: 233803
		string AudioId { get; set; }
	}
}
