using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DD2 RID: 3538
[NullableContext(2)]
[Nullable(0)]
public class MediumItemPrice : IMediumItemPrice
{
	// Token: 0x17000FD1 RID: 4049
	// (get) Token: 0x0600901A RID: 36890 RVA: 0x002B4A59 File Offset: 0x002B2C59
	// (set) Token: 0x0600901B RID: 36891 RVA: 0x002B4A61 File Offset: 0x002B2C61
	public int CurPrice { get; set; }

	// Token: 0x17000FD2 RID: 4050
	// (get) Token: 0x0600901C RID: 36892 RVA: 0x002B4A6A File Offset: 0x002B2C6A
	// (set) Token: 0x0600901D RID: 36893 RVA: 0x002B4A72 File Offset: 0x002B2C72
	public int? OriginalPrice { get; set; }

	// Token: 0x17000FD3 RID: 4051
	// (get) Token: 0x0600901E RID: 36894 RVA: 0x002B4A7B File Offset: 0x002B2C7B
	// (set) Token: 0x0600901F RID: 36895 RVA: 0x002B4A83 File Offset: 0x002B2C83
	public string TexPath { get; set; }

	// Token: 0x17000FD4 RID: 4052
	// (get) Token: 0x06009020 RID: 36896 RVA: 0x002B4A8C File Offset: 0x002B2C8C
	// (set) Token: 0x06009021 RID: 36897 RVA: 0x002B4A94 File Offset: 0x002B2C94
	public bool? CurrencyNotEnough { get; set; }
}
