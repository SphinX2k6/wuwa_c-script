using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005385 RID: 21381
	[NullableContext(1)]
	public interface IUiItemAspectOffsetConfig
	{
		// Token: 0x17008389 RID: 33673
		// (get) Token: 0x06036A08 RID: 223752
		// (set) Token: 0x06036A09 RID: 223753
		UUIItem UiItem { get; set; }

		// Token: 0x1700838A RID: 33674
		// (get) Token: 0x06036A0A RID: 223754
		// (set) Token: 0x06036A0B RID: 223755
		Vector2D OriginalOffset { get; set; }

		// Token: 0x1700838B RID: 33675
		// (get) Token: 0x06036A0C RID: 223756
		// (set) Token: 0x06036A0D RID: 223757
		float OffsetWidthDirection { get; set; }

		// Token: 0x1700838C RID: 33676
		// (get) Token: 0x06036A0E RID: 223758
		// (set) Token: 0x06036A0F RID: 223759
		float OffsetHeightDirection { get; set; }
	}
}
