using System;
using System.Runtime.CompilerServices;

// Token: 0x02002426 RID: 9254
[NullableContext(1)]
[Nullable(0)]
public class FettersObtainData : IFettersObtainData
{
	// Token: 0x1700181F RID: 6175
	// (get) Token: 0x06012903 RID: 76035 RVA: 0x00493323 File Offset: 0x00491523
	// (set) Token: 0x06012904 RID: 76036 RVA: 0x0049332B File Offset: 0x0049152B
	public int Id { get; set; }

	// Token: 0x17001820 RID: 6176
	// (get) Token: 0x06012905 RID: 76037 RVA: 0x00493334 File Offset: 0x00491534
	// (set) Token: 0x06012906 RID: 76038 RVA: 0x0049333C File Offset: 0x0049153C
	public string Name { get; set; }

	// Token: 0x17001821 RID: 6177
	// (get) Token: 0x06012907 RID: 76039 RVA: 0x00493345 File Offset: 0x00491545
	// (set) Token: 0x06012908 RID: 76040 RVA: 0x0049334D File Offset: 0x0049154D
	public string Icon { get; set; }

	// Token: 0x17001822 RID: 6178
	// (get) Token: 0x06012909 RID: 76041 RVA: 0x00493356 File Offset: 0x00491556
	// (set) Token: 0x0601290A RID: 76042 RVA: 0x0049335E File Offset: 0x0049155E
	public bool IsGet { get; set; }
}
