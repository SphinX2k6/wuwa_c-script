using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C3 RID: 21187
	[NullableContext(1)]
	public interface IPinballItemSyncMonsterGridViewData
	{
		// Token: 0x17006671 RID: 26225
		// (get) Token: 0x06034BF3 RID: 216051
		// (set) Token: 0x06034BF4 RID: 216052
		IPinballItemDataMonster ItemData { get; set; }

		// Token: 0x17006672 RID: 26226
		// (get) Token: 0x06034BF5 RID: 216053
		// (set) Token: 0x06034BF6 RID: 216054
		bool IsSelected { get; set; }

		// Token: 0x17006673 RID: 26227
		// (get) Token: 0x06034BF7 RID: 216055
		// (set) Token: 0x06034BF8 RID: 216056
		Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }
	}
}
