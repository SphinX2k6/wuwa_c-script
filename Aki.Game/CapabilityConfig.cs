using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200022D RID: 557
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class CapabilityConfig : ICapabilityConfig
{
	// Token: 0x17000513 RID: 1299
	// (get) Token: 0x06002289 RID: 8841 RVA: 0x000D9401 File Offset: 0x000D7601
	// (set) Token: 0x0600228A RID: 8842 RVA: 0x000D9409 File Offset: 0x000D7609
	[RequiredMember]
	public List<int> Tags { get; set; }

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x0600228B RID: 8843 RVA: 0x000D9412 File Offset: 0x000D7612
	// (set) Token: 0x0600228C RID: 8844 RVA: 0x000D941A File Offset: 0x000D761A
	public ETickingGroup? TickGroup { get; set; }

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x0600228D RID: 8845 RVA: 0x000D9423 File Offset: 0x000D7623
	// (set) Token: 0x0600228E RID: 8846 RVA: 0x000D942B File Offset: 0x000D762B
	[RequiredMember]
	public int TickGroupOrder { get; set; }

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x0600228F RID: 8847 RVA: 0x000D9434 File Offset: 0x000D7634
	// (set) Token: 0x06002290 RID: 8848 RVA: 0x000D943C File Offset: 0x000D763C
	public ETickingGroup? InactiveTickGroup { get; set; }

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06002291 RID: 8849 RVA: 0x000D9445 File Offset: 0x000D7645
	// (set) Token: 0x06002292 RID: 8850 RVA: 0x000D944D File Offset: 0x000D764D
	public int? InactiveTickGroupOrder { get; set; }

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06002293 RID: 8851 RVA: 0x000D9456 File Offset: 0x000D7656
	// (set) Token: 0x06002294 RID: 8852 RVA: 0x000D945E File Offset: 0x000D765E
	[RequiredMember]
	public List<int> InterruptsTags { get; set; }

	// Token: 0x06002295 RID: 8853 RVA: 0x000D9467 File Offset: 0x000D7667
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityConfig()
	{
	}
}
