using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005989 RID: 22921
	[NullableContext(1)]
	public interface IGiantQuestGuideData
	{
		// Token: 0x17008B59 RID: 35673
		// (get) Token: 0x0603A286 RID: 238214
		// (set) Token: 0x0603A287 RID: 238215
		int AccessId { get; set; }

		// Token: 0x17008B5A RID: 35674
		// (get) Token: 0x0603A288 RID: 238216
		// (set) Token: 0x0603A289 RID: 238217
		List<int> GroupAccessIds { get; set; }

		// Token: 0x17008B5B RID: 35675
		// (get) Token: 0x0603A28A RID: 238218
		// (set) Token: 0x0603A28B RID: 238219
		int SkipConfigId { get; set; }

		// Token: 0x17008B5C RID: 35676
		// (get) Token: 0x0603A28C RID: 238220
		// (set) Token: 0x0603A28D RID: 238221
		int AnchorItemId { get; set; }

		// Token: 0x17008B5D RID: 35677
		// (get) Token: 0x0603A28E RID: 238222
		// (set) Token: 0x0603A28F RID: 238223
		string DescText { get; set; }

		// Token: 0x17008B5E RID: 35678
		// (get) Token: 0x0603A290 RID: 238224
		// (set) Token: 0x0603A291 RID: 238225
		string LockedText { get; set; }

		// Token: 0x17008B5F RID: 35679
		// (get) Token: 0x0603A292 RID: 238226
		// (set) Token: 0x0603A293 RID: 238227
		EGiantQuestGuideState State { get; set; }

		// Token: 0x17008B60 RID: 35680
		// (get) Token: 0x0603A294 RID: 238228
		// (set) Token: 0x0603A295 RID: 238229
		List<IGiantQuestGuideItemInfo> Items { get; set; }

		// Token: 0x17008B61 RID: 35681
		// (get) Token: 0x0603A296 RID: 238230
		// (set) Token: 0x0603A297 RID: 238231
		bool HasNew { get; set; }

		// Token: 0x17008B62 RID: 35682
		// (get) Token: 0x0603A298 RID: 238232
		// (set) Token: 0x0603A299 RID: 238233
		bool HasSkip { get; set; }

		// Token: 0x17008B63 RID: 35683
		// (get) Token: 0x0603A29A RID: 238234
		// (set) Token: 0x0603A29B RID: 238235
		Action<IGiantQuestGuideData> OnGoto { get; set; }
	}
}
