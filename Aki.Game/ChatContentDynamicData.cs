using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C4E RID: 3150
[NullableContext(1)]
[Nullable(0)]
public class ChatContentDynamicData : IChatContentDynamicData
{
	// Token: 0x17000ECC RID: 3788
	// (get) Token: 0x060083A7 RID: 33703 RVA: 0x00284EB6 File Offset: 0x002830B6
	// (set) Token: 0x060083A8 RID: 33704 RVA: 0x00284EBE File Offset: 0x002830BE
	public ChatContentData ChatContentData { get; set; }

	// Token: 0x17000ECD RID: 3789
	// (get) Token: 0x060083A9 RID: 33705 RVA: 0x00284EC7 File Offset: 0x002830C7
	// (set) Token: 0x060083AA RID: 33706 RVA: 0x00284ECF File Offset: 0x002830CF
	public EChatContentType Type { get; set; }
}
