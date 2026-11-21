using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02003734 RID: 14132
	[NullableContext(1)]
	public interface IMapMarkProgressItemData
	{
		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x06024C2C RID: 150572
		// (set) Token: 0x06024C2D RID: 150573
		string NameId { get; set; }

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x06024C2E RID: 150574
		// (set) Token: 0x06024C2F RID: 150575
		float Progress { get; set; }

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x06024C30 RID: 150576
		// (set) Token: 0x06024C31 RID: 150577
		float ProgressMax { get; set; }

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x06024C32 RID: 150578
		// (set) Token: 0x06024C33 RID: 150579
		float ProgressMin { get; set; }

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x06024C34 RID: 150580
		// (set) Token: 0x06024C35 RID: 150581
		[Nullable(2)]
		Action<float> SetProgressCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
