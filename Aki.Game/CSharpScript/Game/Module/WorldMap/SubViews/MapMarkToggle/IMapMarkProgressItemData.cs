using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004803 RID: 18435
	[NullableContext(1)]
	public interface IMapMarkProgressItemData
	{
		// Token: 0x170078CE RID: 30926
		// (get) Token: 0x0603045C RID: 197724
		// (set) Token: 0x0603045D RID: 197725
		string NameId { get; set; }

		// Token: 0x170078CF RID: 30927
		// (get) Token: 0x0603045E RID: 197726
		// (set) Token: 0x0603045F RID: 197727
		float Progress { get; set; }

		// Token: 0x170078D0 RID: 30928
		// (get) Token: 0x06030460 RID: 197728
		// (set) Token: 0x06030461 RID: 197729
		float ProgressMax { get; set; }

		// Token: 0x170078D1 RID: 30929
		// (get) Token: 0x06030462 RID: 197730
		// (set) Token: 0x06030463 RID: 197731
		float ProgressMin { get; set; }

		// Token: 0x170078D2 RID: 30930
		// (get) Token: 0x06030464 RID: 197732
		// (set) Token: 0x06030465 RID: 197733
		[Nullable(2)]
		Action<float> SetProgressCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
