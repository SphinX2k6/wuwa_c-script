using System;
using System.Runtime.CompilerServices;

// Token: 0x020031E4 RID: 12772
[NullableContext(2)]
[Nullable(0)]
public class NpcSitOnChairParams : INpcSitOnChairParams
{
	// Token: 0x17002612 RID: 9746
	// (get) Token: 0x0601B8BE RID: 112830 RVA: 0x0078E9B7 File Offset: 0x0078CBB7
	// (set) Token: 0x0601B8BF RID: 112831 RVA: 0x0078E9BF File Offset: 0x0078CBBF
	public int ChairEntityId { get; set; }

	// Token: 0x17002613 RID: 9747
	// (get) Token: 0x0601B8C0 RID: 112832 RVA: 0x0078E9C8 File Offset: 0x0078CBC8
	// (set) Token: 0x0601B8C1 RID: 112833 RVA: 0x0078E9D0 File Offset: 0x0078CBD0
	public string MontagePath { get; set; }

	// Token: 0x17002614 RID: 9748
	// (get) Token: 0x0601B8C2 RID: 112834 RVA: 0x0078E9D9 File Offset: 0x0078CBD9
	// (set) Token: 0x0601B8C3 RID: 112835 RVA: 0x0078E9E1 File Offset: 0x0078CBE1
	[Nullable(1)]
	public Func<bool> InterruptCondition { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17002615 RID: 9749
	// (get) Token: 0x0601B8C4 RID: 112836 RVA: 0x0078E9EA File Offset: 0x0078CBEA
	// (set) Token: 0x0601B8C5 RID: 112837 RVA: 0x0078E9F2 File Offset: 0x0078CBF2
	public Action Finish { get; set; }

	// Token: 0x17002616 RID: 9750
	// (get) Token: 0x0601B8C6 RID: 112838 RVA: 0x0078E9FB File Offset: 0x0078CBFB
	// (set) Token: 0x0601B8C7 RID: 112839 RVA: 0x0078EA03 File Offset: 0x0078CC03
	public Action Abort { get; set; }

	// Token: 0x17002617 RID: 9751
	// (get) Token: 0x0601B8C8 RID: 112840 RVA: 0x0078EA0C File Offset: 0x0078CC0C
	// (set) Token: 0x0601B8C9 RID: 112841 RVA: 0x0078EA14 File Offset: 0x0078CC14
	public int[] TeleportEffect { get; set; }
}
