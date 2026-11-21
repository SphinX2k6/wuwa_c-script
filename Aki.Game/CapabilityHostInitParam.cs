using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200023D RID: 573
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class CapabilityHostInitParam : ICapabilityHostInitParam
{
	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000DFA81 File Offset: 0x000DDC81
	// (set) Token: 0x060023B3 RID: 9139 RVA: 0x000DFA89 File Offset: 0x000DDC89
	[Nullable(1)]
	[RequiredMember]
	public object Id { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000DFA92 File Offset: 0x000DDC92
	// (set) Token: 0x060023B5 RID: 9141 RVA: 0x000DFA9A File Offset: 0x000DDC9A
	public Func<bool> IsValid { get; set; }

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000DFAA3 File Offset: 0x000DDCA3
	// (set) Token: 0x060023B7 RID: 9143 RVA: 0x000DFAAB File Offset: 0x000DDCAB
	public Func<AActor> GetBoundActor { get; set; }

	// Token: 0x060023B8 RID: 9144 RVA: 0x000DFAB4 File Offset: 0x000DDCB4
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityHostInitParam()
	{
	}
}
