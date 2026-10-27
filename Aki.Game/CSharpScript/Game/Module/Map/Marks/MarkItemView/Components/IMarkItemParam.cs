using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005546 RID: 21830
	[NullableContext(1)]
	public interface IMarkItemParam
	{
		// Token: 0x170085BD RID: 34237
		// (get) Token: 0x06037B55 RID: 228181
		// (set) Token: 0x06037B56 RID: 228182
		string Txt { get; set; }

		// Token: 0x170085BE RID: 34238
		// (get) Token: 0x06037B57 RID: 228183
		// (set) Token: 0x06037B58 RID: 228184
		int? FontSize { get; set; }

		// Token: 0x170085BF RID: 34239
		// (get) Token: 0x06037B59 RID: 228185
		// (set) Token: 0x06037B5A RID: 228186
		FVector2D? AnchorOffset { get; set; }

		// Token: 0x170085C0 RID: 34240
		// (get) Token: 0x06037B5B RID: 228187
		// (set) Token: 0x06037B5C RID: 228188
		float? OutlineSize { get; set; }

		// Token: 0x170085C1 RID: 34241
		// (get) Token: 0x06037B5D RID: 228189
		// (set) Token: 0x06037B5E RID: 228190
		FColor? OutlineColor { get; set; }
	}
}
