using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x02004492 RID: 17554
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkItemData : IMarkItemData
	{
		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x0602C593 RID: 181651 RVA: 0x00C7786C File Offset: 0x00C75A6C
		// (set) Token: 0x0602C594 RID: 181652 RVA: 0x00C77874 File Offset: 0x00C75A74
		public int[] ShowRange { get; set; }

		// Token: 0x17005899 RID: 22681
		// (get) Token: 0x0602C595 RID: 181653 RVA: 0x00C7787D File Offset: 0x00C75A7D
		// (set) Token: 0x0602C596 RID: 181654 RVA: 0x00C77885 File Offset: 0x00C75A85
		public string MarkPic { get; set; }

		// Token: 0x1700589A RID: 22682
		// (get) Token: 0x0602C597 RID: 181655 RVA: 0x00C7788E File Offset: 0x00C75A8E
		// (set) Token: 0x0602C598 RID: 181656 RVA: 0x00C77896 File Offset: 0x00C75A96
		public int? ShowPriority { get; set; }

		// Token: 0x1700589B RID: 22683
		// (get) Token: 0x0602C599 RID: 181657 RVA: 0x00C7789F File Offset: 0x00C75A9F
		// (set) Token: 0x0602C59A RID: 181658 RVA: 0x00C778A7 File Offset: 0x00C75AA7
		public float? Scale { get; set; }

		// Token: 0x1700589C RID: 22684
		// (get) Token: 0x0602C59B RID: 181659 RVA: 0x00C778B0 File Offset: 0x00C75AB0
		// (set) Token: 0x0602C59C RID: 181660 RVA: 0x00C778B8 File Offset: 0x00C75AB8
		public float? CornerScale { get; set; }
	}
}
