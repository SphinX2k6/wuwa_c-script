using System;
using System.Runtime.CompilerServices;

// Token: 0x020023F1 RID: 9201
[NullableContext(1)]
[Nullable(0)]
public class PhantomArenaStartViewData : IPhantomArenaStartViewData
{
	// Token: 0x170017D0 RID: 6096
	// (get) Token: 0x06012636 RID: 75318 RVA: 0x00488A03 File Offset: 0x00486C03
	// (set) Token: 0x06012637 RID: 75319 RVA: 0x00488A0B File Offset: 0x00486C0B
	public string ContentTextId { get; set; }

	// Token: 0x170017D1 RID: 6097
	// (get) Token: 0x06012638 RID: 75320 RVA: 0x00488A14 File Offset: 0x00486C14
	// (set) Token: 0x06012639 RID: 75321 RVA: 0x00488A1C File Offset: 0x00486C1C
	public bool IsOwn { get; set; }

	// Token: 0x170017D2 RID: 6098
	// (get) Token: 0x0601263A RID: 75322 RVA: 0x00488A25 File Offset: 0x00486C25
	// (set) Token: 0x0601263B RID: 75323 RVA: 0x00488A2D File Offset: 0x00486C2D
	[Nullable(2)]
	public Action Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
