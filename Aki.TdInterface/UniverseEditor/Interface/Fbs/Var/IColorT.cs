using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E63 RID: 15971
	public class IColorT
	{
		// Token: 0x17006BCF RID: 27599
		// (get) Token: 0x06015837 RID: 88119 RVA: 0x0031A332 File Offset: 0x00318532
		// (set) Token: 0x06015838 RID: 88120 RVA: 0x0031A33A File Offset: 0x0031853A
		public float R { get; set; }

		// Token: 0x17006BD0 RID: 27600
		// (get) Token: 0x06015839 RID: 88121 RVA: 0x0031A343 File Offset: 0x00318543
		// (set) Token: 0x0601583A RID: 88122 RVA: 0x0031A34B File Offset: 0x0031854B
		public float G { get; set; }

		// Token: 0x17006BD1 RID: 27601
		// (get) Token: 0x0601583B RID: 88123 RVA: 0x0031A354 File Offset: 0x00318554
		// (set) Token: 0x0601583C RID: 88124 RVA: 0x0031A35C File Offset: 0x0031855C
		public float B { get; set; }

		// Token: 0x17006BD2 RID: 27602
		// (get) Token: 0x0601583D RID: 88125 RVA: 0x0031A365 File Offset: 0x00318565
		// (set) Token: 0x0601583E RID: 88126 RVA: 0x0031A36D File Offset: 0x0031856D
		public float A { get; set; }

		// Token: 0x17006BD3 RID: 27603
		// (get) Token: 0x0601583F RID: 88127 RVA: 0x0031A376 File Offset: 0x00318576
		// (set) Token: 0x06015840 RID: 88128 RVA: 0x0031A37E File Offset: 0x0031857E
		public byte NullMask { get; set; }

		// Token: 0x06015841 RID: 88129 RVA: 0x0031A387 File Offset: 0x00318587
		public IColorT()
		{
			this.R = 0f;
			this.G = 0f;
			this.B = 0f;
			this.A = 0f;
			this.NullMask = 0;
		}
	}
}
