using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000231 RID: 561
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class CapabilityConfig : ICapabilityConfig
{
	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06002341 RID: 9025 RVA: 0x000DF8C1 File Offset: 0x000DDAC1
	// (set) Token: 0x06002342 RID: 9026 RVA: 0x000DF8C9 File Offset: 0x000DDAC9
	[RequiredMember]
	public List<int> Tags { get; set; }

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06002343 RID: 9027 RVA: 0x000DF8D2 File Offset: 0x000DDAD2
	// (set) Token: 0x06002344 RID: 9028 RVA: 0x000DF8DA File Offset: 0x000DDADA
	public ETickingGroup? TickGroup { get; set; }

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06002345 RID: 9029 RVA: 0x000DF8E3 File Offset: 0x000DDAE3
	// (set) Token: 0x06002346 RID: 9030 RVA: 0x000DF8EB File Offset: 0x000DDAEB
	[RequiredMember]
	public int TickGroupOrder { get; set; }

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06002347 RID: 9031 RVA: 0x000DF8F4 File Offset: 0x000DDAF4
	// (set) Token: 0x06002348 RID: 9032 RVA: 0x000DF8FC File Offset: 0x000DDAFC
	public ETickingGroup? InactiveTickGroup { get; set; }

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06002349 RID: 9033 RVA: 0x000DF905 File Offset: 0x000DDB05
	// (set) Token: 0x0600234A RID: 9034 RVA: 0x000DF90D File Offset: 0x000DDB0D
	public int? InactiveTickGroupOrder { get; set; }

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x0600234B RID: 9035 RVA: 0x000DF916 File Offset: 0x000DDB16
	// (set) Token: 0x0600234C RID: 9036 RVA: 0x000DF91E File Offset: 0x000DDB1E
	[RequiredMember]
	public List<int> InterruptsTags { get; set; }

	// Token: 0x0600234D RID: 9037 RVA: 0x000DF927 File Offset: 0x000DDB27
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityConfig()
	{
	}
}
