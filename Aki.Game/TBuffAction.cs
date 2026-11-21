using System;
using System.Runtime.CompilerServices;

// Token: 0x020023E4 RID: 9188
[NullableContext(2)]
[Nullable(0)]
public class TBuffAction
{
	// Token: 0x170023B4 RID: 9140
	// (get) Token: 0x06017094 RID: 94356 RVA: 0x006BA5DB File Offset: 0x006B87DB
	// (set) Token: 0x06017095 RID: 94357 RVA: 0x006BA5E3 File Offset: 0x006B87E3
	public EBuffActionType Type { get; set; }

	// Token: 0x170023B5 RID: 9141
	// (get) Token: 0x06017096 RID: 94358 RVA: 0x006BA5EC File Offset: 0x006B87EC
	// (set) Token: 0x06017097 RID: 94359 RVA: 0x006BA5F4 File Offset: 0x006B87F4
	public long[] Buffs { get; set; }

	// Token: 0x170023B6 RID: 9142
	// (get) Token: 0x06017098 RID: 94360 RVA: 0x006BA5FD File Offset: 0x006B87FD
	// (set) Token: 0x06017099 RID: 94361 RVA: 0x006BA605 File Offset: 0x006B8805
	public int[] Tags { get; set; }

	// Token: 0x170023B7 RID: 9143
	// (get) Token: 0x0601709A RID: 94362 RVA: 0x006BA60E File Offset: 0x006B880E
	// (set) Token: 0x0601709B RID: 94363 RVA: 0x006BA616 File Offset: 0x006B8816
	public int[] CustomParams { get; set; }
}
