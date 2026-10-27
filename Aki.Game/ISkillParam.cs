using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003137 RID: 12599
[NullableContext(2)]
public interface ISkillParam
{
	// Token: 0x17002572 RID: 9586
	// (get) Token: 0x0601B11F RID: 110879
	// (set) Token: 0x0601B120 RID: 110880
	Entity Target { get; set; }

	// Token: 0x17002573 RID: 9587
	// (get) Token: 0x0601B121 RID: 110881
	// (set) Token: 0x0601B122 RID: 110882
	AActor TargetActor { get; set; }

	// Token: 0x17002574 RID: 9588
	// (get) Token: 0x0601B123 RID: 110883
	// (set) Token: 0x0601B124 RID: 110884
	string SocketName { get; set; }

	// Token: 0x17002575 RID: 9589
	// (get) Token: 0x0601B125 RID: 110885
	// (set) Token: 0x0601B126 RID: 110886
	long? ContextId { get; set; }

	// Token: 0x17002576 RID: 9590
	// (get) Token: 0x0601B127 RID: 110887
	// (set) Token: 0x0601B128 RID: 110888
	string Reason { get; set; }

	// Token: 0x17002577 RID: 9591
	// (get) Token: 0x0601B129 RID: 110889
	// (set) Token: 0x0601B12A RID: 110890
	int? MontageIndex { get; set; }

	// Token: 0x17002578 RID: 9592
	// (get) Token: 0x0601B12B RID: 110891
	// (set) Token: 0x0601B12C RID: 110892
	bool? CheckMultiSkill { get; set; }

	// Token: 0x17002579 RID: 9593
	// (get) Token: 0x0601B12D RID: 110893
	// (set) Token: 0x0601B12E RID: 110894
	int? NextSkillId { get; set; }

	// Token: 0x1700257A RID: 9594
	// (get) Token: 0x0601B12F RID: 110895
	// (set) Token: 0x0601B130 RID: 110896
	bool? IsAsync { get; set; }

	// Token: 0x1700257B RID: 9595
	// (get) Token: 0x0601B131 RID: 110897
	// (set) Token: 0x0601B132 RID: 110898
	FVectorDouble? ExtraTargetLocation { get; set; }
}
