using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D8F RID: 3471
[NullableContext(1)]
[Nullable(0)]
public class TipsAttributeItemData : ITipsAttributeItemData
{
	// Token: 0x17000F9F RID: 3999
	// (get) Token: 0x06008E74 RID: 36468 RVA: 0x002AE1E1 File Offset: 0x002AC3E1
	// (set) Token: 0x06008E75 RID: 36469 RVA: 0x002AE1E9 File Offset: 0x002AC3E9
	public int Id { get; set; }

	// Token: 0x17000FA0 RID: 4000
	// (get) Token: 0x06008E76 RID: 36470 RVA: 0x002AE1F2 File Offset: 0x002AC3F2
	// (set) Token: 0x06008E77 RID: 36471 RVA: 0x002AE1FA File Offset: 0x002AC3FA
	public bool IsMainAttribute { get; set; }

	// Token: 0x17000FA1 RID: 4001
	// (get) Token: 0x06008E78 RID: 36472 RVA: 0x002AE203 File Offset: 0x002AC403
	// (set) Token: 0x06008E79 RID: 36473 RVA: 0x002AE20B File Offset: 0x002AC40B
	public string Name { get; set; }

	// Token: 0x17000FA2 RID: 4002
	// (get) Token: 0x06008E7A RID: 36474 RVA: 0x002AE214 File Offset: 0x002AC414
	// (set) Token: 0x06008E7B RID: 36475 RVA: 0x002AE21C File Offset: 0x002AC41C
	public string IconPath { get; set; }

	// Token: 0x17000FA3 RID: 4003
	// (get) Token: 0x06008E7C RID: 36476 RVA: 0x002AE225 File Offset: 0x002AC425
	// (set) Token: 0x06008E7D RID: 36477 RVA: 0x002AE22D File Offset: 0x002AC42D
	public double Value { get; set; }

	// Token: 0x17000FA4 RID: 4004
	// (get) Token: 0x06008E7E RID: 36478 RVA: 0x002AE236 File Offset: 0x002AC436
	// (set) Token: 0x06008E7F RID: 36479 RVA: 0x002AE23E File Offset: 0x002AC43E
	public bool IsRatio { get; set; }
}
