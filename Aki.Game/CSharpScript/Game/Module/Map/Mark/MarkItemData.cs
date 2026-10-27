using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054AF RID: 21679
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkItemData : IMarkItemData
	{
		// Token: 0x170084CC RID: 33996
		// (get) Token: 0x0603763D RID: 226877 RVA: 0x00D27AF0 File Offset: 0x00D25CF0
		// (set) Token: 0x0603763E RID: 226878 RVA: 0x00D27AF8 File Offset: 0x00D25CF8
		public int[] ShowRange { get; set; }

		// Token: 0x170084CD RID: 33997
		// (get) Token: 0x0603763F RID: 226879 RVA: 0x00D27B01 File Offset: 0x00D25D01
		// (set) Token: 0x06037640 RID: 226880 RVA: 0x00D27B09 File Offset: 0x00D25D09
		public string MarkPic { get; set; }

		// Token: 0x170084CE RID: 33998
		// (get) Token: 0x06037641 RID: 226881 RVA: 0x00D27B12 File Offset: 0x00D25D12
		// (set) Token: 0x06037642 RID: 226882 RVA: 0x00D27B1A File Offset: 0x00D25D1A
		public int? ShowPriority { get; set; }

		// Token: 0x170084CF RID: 33999
		// (get) Token: 0x06037643 RID: 226883 RVA: 0x00D27B23 File Offset: 0x00D25D23
		// (set) Token: 0x06037644 RID: 226884 RVA: 0x00D27B2B File Offset: 0x00D25D2B
		public float? Scale { get; set; }

		// Token: 0x170084D0 RID: 34000
		// (get) Token: 0x06037645 RID: 226885 RVA: 0x00D27B34 File Offset: 0x00D25D34
		// (set) Token: 0x06037646 RID: 226886 RVA: 0x00D27B3C File Offset: 0x00D25D3C
		public float? CornerScale { get; set; }
	}
}
