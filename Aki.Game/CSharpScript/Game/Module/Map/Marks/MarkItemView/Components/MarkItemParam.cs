using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005547 RID: 21831
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemParam : IMarkItemParam
	{
		// Token: 0x170085C2 RID: 34242
		// (get) Token: 0x06037B5F RID: 228191 RVA: 0x00D382BB File Offset: 0x00D364BB
		// (set) Token: 0x06037B60 RID: 228192 RVA: 0x00D382C3 File Offset: 0x00D364C3
		public string Txt { get; set; }

		// Token: 0x170085C3 RID: 34243
		// (get) Token: 0x06037B61 RID: 228193 RVA: 0x00D382CC File Offset: 0x00D364CC
		// (set) Token: 0x06037B62 RID: 228194 RVA: 0x00D382D4 File Offset: 0x00D364D4
		public int? FontSize { get; set; }

		// Token: 0x170085C4 RID: 34244
		// (get) Token: 0x06037B63 RID: 228195 RVA: 0x00D382DD File Offset: 0x00D364DD
		// (set) Token: 0x06037B64 RID: 228196 RVA: 0x00D382E5 File Offset: 0x00D364E5
		public FVector2D? AnchorOffset { get; set; }

		// Token: 0x170085C5 RID: 34245
		// (get) Token: 0x06037B65 RID: 228197 RVA: 0x00D382EE File Offset: 0x00D364EE
		// (set) Token: 0x06037B66 RID: 228198 RVA: 0x00D382F6 File Offset: 0x00D364F6
		public float? OutlineSize { get; set; }

		// Token: 0x170085C6 RID: 34246
		// (get) Token: 0x06037B67 RID: 228199 RVA: 0x00D382FF File Offset: 0x00D364FF
		// (set) Token: 0x06037B68 RID: 228200 RVA: 0x00D38307 File Offset: 0x00D36507
		public FColor? OutlineColor { get; set; }
	}
}
