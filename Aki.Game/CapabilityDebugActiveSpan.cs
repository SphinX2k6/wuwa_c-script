using System;
using System.Runtime.CompilerServices;

// Token: 0x02000239 RID: 569
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class CapabilityDebugActiveSpan : ICapabilityDebugActiveSpan
{
	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06002394 RID: 9108 RVA: 0x000DF9E9 File Offset: 0x000DDBE9
	// (set) Token: 0x06002395 RID: 9109 RVA: 0x000DF9F1 File Offset: 0x000DDBF1
	[RequiredMember]
	public string CapabilityId { get; set; }

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x06002396 RID: 9110 RVA: 0x000DF9FA File Offset: 0x000DDBFA
	// (set) Token: 0x06002397 RID: 9111 RVA: 0x000DFA02 File Offset: 0x000DDC02
	[RequiredMember]
	public string GameObjectId { get; set; }

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x06002398 RID: 9112 RVA: 0x000DFA0B File Offset: 0x000DDC0B
	// (set) Token: 0x06002399 RID: 9113 RVA: 0x000DFA13 File Offset: 0x000DDC13
	[RequiredMember]
	public string ClassName { get; set; }

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x0600239A RID: 9114 RVA: 0x000DFA1C File Offset: 0x000DDC1C
	// (set) Token: 0x0600239B RID: 9115 RVA: 0x000DFA24 File Offset: 0x000DDC24
	[RequiredMember]
	public double StartTime { get; set; }

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x0600239C RID: 9116 RVA: 0x000DFA2D File Offset: 0x000DDC2D
	// (set) Token: 0x0600239D RID: 9117 RVA: 0x000DFA35 File Offset: 0x000DDC35
	[RequiredMember]
	public double EndTime { get; set; }

	// Token: 0x0600239E RID: 9118 RVA: 0x000DFA3E File Offset: 0x000DDC3E
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityDebugActiveSpan()
	{
	}
}
