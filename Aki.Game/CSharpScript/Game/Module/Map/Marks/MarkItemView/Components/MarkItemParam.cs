using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02004519 RID: 17689
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemParam : IMarkItemParam
	{
		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x0602CA2E RID: 182830 RVA: 0x00C85D8F File Offset: 0x00C83F8F
		// (set) Token: 0x0602CA2F RID: 182831 RVA: 0x00C85D97 File Offset: 0x00C83F97
		public string Txt { get; set; }

		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x0602CA30 RID: 182832 RVA: 0x00C85DA0 File Offset: 0x00C83FA0
		// (set) Token: 0x0602CA31 RID: 182833 RVA: 0x00C85DA8 File Offset: 0x00C83FA8
		public int? FontSize { get; set; }

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x0602CA32 RID: 182834 RVA: 0x00C85DB1 File Offset: 0x00C83FB1
		// (set) Token: 0x0602CA33 RID: 182835 RVA: 0x00C85DB9 File Offset: 0x00C83FB9
		public FVector2D? AnchorOffset { get; set; }

		// Token: 0x17005965 RID: 22885
		// (get) Token: 0x0602CA34 RID: 182836 RVA: 0x00C85DC2 File Offset: 0x00C83FC2
		// (set) Token: 0x0602CA35 RID: 182837 RVA: 0x00C85DCA File Offset: 0x00C83FCA
		public float? OutlineSize { get; set; }

		// Token: 0x17005966 RID: 22886
		// (get) Token: 0x0602CA36 RID: 182838 RVA: 0x00C85DD3 File Offset: 0x00C83FD3
		// (set) Token: 0x0602CA37 RID: 182839 RVA: 0x00C85DDB File Offset: 0x00C83FDB
		public FColor? OutlineColor { get; set; }
	}
}
