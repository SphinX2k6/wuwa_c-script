using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02004518 RID: 17688
	[NullableContext(1)]
	public interface IMarkItemParam
	{
		// Token: 0x1700595D RID: 22877
		// (get) Token: 0x0602CA24 RID: 182820
		// (set) Token: 0x0602CA25 RID: 182821
		string Txt { get; set; }

		// Token: 0x1700595E RID: 22878
		// (get) Token: 0x0602CA26 RID: 182822
		// (set) Token: 0x0602CA27 RID: 182823
		int? FontSize { get; set; }

		// Token: 0x1700595F RID: 22879
		// (get) Token: 0x0602CA28 RID: 182824
		// (set) Token: 0x0602CA29 RID: 182825
		FVector2D? AnchorOffset { get; set; }

		// Token: 0x17005960 RID: 22880
		// (get) Token: 0x0602CA2A RID: 182826
		// (set) Token: 0x0602CA2B RID: 182827
		float? OutlineSize { get; set; }

		// Token: 0x17005961 RID: 22881
		// (get) Token: 0x0602CA2C RID: 182828
		// (set) Token: 0x0602CA2D RID: 182829
		FColor? OutlineColor { get; set; }
	}
}
