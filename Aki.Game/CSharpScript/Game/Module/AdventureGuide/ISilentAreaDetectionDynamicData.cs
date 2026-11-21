using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA8 RID: 20136
	[NullableContext(1)]
	public interface ISilentAreaDetectionDynamicData
	{
		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x06032AAE RID: 207534
		// (set) Token: 0x06032AAF RID: 207535
		bool IsShow { get; set; }

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x06032AB0 RID: 207536
		// (set) Token: 0x06032AB1 RID: 207537
		int DangerType { get; set; }

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x06032AB2 RID: 207538
		// (set) Token: 0x06032AB3 RID: 207539
		SilentAreaDetectionRecord SilentAreaDetectionData { get; set; }

		// Token: 0x170062A5 RID: 25253
		// (get) Token: 0x06032AB4 RID: 207540
		// (set) Token: 0x06032AB5 RID: 207541
		[Nullable(2)]
		ISilentAreaTitleData SilentAreaTitleData { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
