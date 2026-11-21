using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005585 RID: 21893
	[NullableContext(1)]
	public interface IFishingDockQuestChildItemData
	{
		// Token: 0x1700695C RID: 26972
		// (get) Token: 0x06036421 RID: 222241
		// (set) Token: 0x06036422 RID: 222242
		string DesText { get; set; }

		// Token: 0x1700695D RID: 26973
		// (get) Token: 0x06036423 RID: 222243
		// (set) Token: 0x06036424 RID: 222244
		int MaxCount { get; set; }

		// Token: 0x1700695E RID: 26974
		// (get) Token: 0x06036425 RID: 222245
		// (set) Token: 0x06036426 RID: 222246
		int CurrentCount { get; set; }
	}
}
