using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004368 RID: 17256
	[NullableContext(1)]
	public interface IUiItemAspectOffsetConfig
	{
		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x0602B94E RID: 178510
		// (set) Token: 0x0602B94F RID: 178511
		UUIItem UiItem { get; set; }

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x0602B950 RID: 178512
		// (set) Token: 0x0602B951 RID: 178513
		Vector2D OriginalOffset { get; set; }

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x0602B952 RID: 178514
		// (set) Token: 0x0602B953 RID: 178515
		float OffsetWidthDirection { get; set; }

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x0602B954 RID: 178516
		// (set) Token: 0x0602B955 RID: 178517
		float OffsetHeightDirection { get; set; }
	}
}
