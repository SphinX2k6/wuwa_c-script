using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005339 RID: 21305
	[NullableContext(1)]
	public interface IMowingBuffGridGroupData
	{
		// Token: 0x1700670D RID: 26381
		// (get) Token: 0x06035074 RID: 217204
		// (set) Token: 0x06035075 RID: 217205
		string GroupNameTextId { get; set; }

		// Token: 0x1700670E RID: 26382
		// (get) Token: 0x06035076 RID: 217206
		// (set) Token: 0x06035077 RID: 217207
		bool ShowUnlockText { get; set; }

		// Token: 0x1700670F RID: 26383
		// (get) Token: 0x06035078 RID: 217208
		// (set) Token: 0x06035079 RID: 217209
		IMowingBuffGridItemData[] BuffItemList { get; set; }
	}
}
