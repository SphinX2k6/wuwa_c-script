using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02004962 RID: 18786
	[NullableContext(1)]
	public interface IGiantQuestGuideData
	{
		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x0602F1AC RID: 192940
		// (set) Token: 0x0602F1AD RID: 192941
		int AccessId { get; set; }

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x0602F1AE RID: 192942
		// (set) Token: 0x0602F1AF RID: 192943
		List<int> GroupAccessIds { get; set; }

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x0602F1B0 RID: 192944
		// (set) Token: 0x0602F1B1 RID: 192945
		int SkipConfigId { get; set; }

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x0602F1B2 RID: 192946
		// (set) Token: 0x0602F1B3 RID: 192947
		int AnchorItemId { get; set; }

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x0602F1B4 RID: 192948
		// (set) Token: 0x0602F1B5 RID: 192949
		string DescText { get; set; }

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x0602F1B6 RID: 192950
		// (set) Token: 0x0602F1B7 RID: 192951
		string LockedText { get; set; }

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x0602F1B8 RID: 192952
		// (set) Token: 0x0602F1B9 RID: 192953
		EGiantQuestGuideState State { get; set; }

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x0602F1BA RID: 192954
		// (set) Token: 0x0602F1BB RID: 192955
		List<IGiantQuestGuideItemInfo> Items { get; set; }

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x0602F1BC RID: 192956
		// (set) Token: 0x0602F1BD RID: 192957
		bool HasNew { get; set; }

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x0602F1BE RID: 192958
		// (set) Token: 0x0602F1BF RID: 192959
		bool HasSkip { get; set; }

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x0602F1C0 RID: 192960
		// (set) Token: 0x0602F1C1 RID: 192961
		Action<IGiantQuestGuideData> OnGoto { get; set; }
	}
}
