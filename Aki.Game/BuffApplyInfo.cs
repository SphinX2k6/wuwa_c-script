using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023C3 RID: 9155
[NullableContext(1)]
[Nullable(0)]
public class BuffApplyInfo
{
	// Token: 0x1700236F RID: 9071
	// (get) Token: 0x06016F4A RID: 94026 RVA: 0x006B31C7 File Offset: 0x006B13C7
	// (set) Token: 0x06016F4B RID: 94027 RVA: 0x006B31CF File Offset: 0x006B13CF
	public long InstigatorId { get; set; }

	// Token: 0x17002370 RID: 9072
	// (get) Token: 0x06016F4C RID: 94028 RVA: 0x006B31D8 File Offset: 0x006B13D8
	// (set) Token: 0x06016F4D RID: 94029 RVA: 0x006B31E0 File Offset: 0x006B13E0
	public ApplyGEType ApplyType { get; set; }

	// Token: 0x17002371 RID: 9073
	// (get) Token: 0x06016F4E RID: 94030 RVA: 0x006B31E9 File Offset: 0x006B13E9
	// (set) Token: 0x06016F4F RID: 94031 RVA: 0x006B31F1 File Offset: 0x006B13F1
	public string Reason { get; set; } = string.Empty;
}
