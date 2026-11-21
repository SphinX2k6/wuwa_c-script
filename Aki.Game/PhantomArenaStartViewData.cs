using System;
using System.Runtime.CompilerServices;

// Token: 0x020018D6 RID: 6358
[NullableContext(1)]
[Nullable(0)]
public class PhantomArenaStartViewData : IPhantomArenaStartViewData
{
	// Token: 0x1700180A RID: 6154
	// (get) Token: 0x0600FAE8 RID: 64232 RVA: 0x00495F0B File Offset: 0x0049410B
	// (set) Token: 0x0600FAE9 RID: 64233 RVA: 0x00495F13 File Offset: 0x00494113
	public string ContentTextId { get; set; }

	// Token: 0x1700180B RID: 6155
	// (get) Token: 0x0600FAEA RID: 64234 RVA: 0x00495F1C File Offset: 0x0049411C
	// (set) Token: 0x0600FAEB RID: 64235 RVA: 0x00495F24 File Offset: 0x00494124
	public bool IsOwn { get; set; }

	// Token: 0x1700180C RID: 6156
	// (get) Token: 0x0600FAEC RID: 64236 RVA: 0x00495F2D File Offset: 0x0049412D
	// (set) Token: 0x0600FAED RID: 64237 RVA: 0x00495F35 File Offset: 0x00494135
	[Nullable(2)]
	public Action Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
