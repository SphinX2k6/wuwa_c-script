using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021EB RID: 8683
[NullableContext(2)]
public interface IMaterialHandle
{
	// Token: 0x17002073 RID: 8307
	// (get) Token: 0x060155FC RID: 87548
	// (set) Token: 0x060155FD RID: 87549
	string EffectId { get; set; }

	// Token: 0x17002074 RID: 8308
	// (get) Token: 0x060155FE RID: 87550
	// (set) Token: 0x060155FF RID: 87551
	string EffectPath { get; set; }

	// Token: 0x17002075 RID: 8309
	// (get) Token: 0x06015600 RID: 87552
	// (set) Token: 0x06015601 RID: 87553
	int HandleId { get; set; }

	// Token: 0x17002076 RID: 8310
	// (get) Token: 0x06015602 RID: 87554
	// (set) Token: 0x06015603 RID: 87555
	int RenderingId { get; set; }

	// Token: 0x17002077 RID: 8311
	// (get) Token: 0x06015604 RID: 87556
	// (set) Token: 0x06015605 RID: 87557
	UObject MaterialAssetData { get; set; }

	// Token: 0x17002078 RID: 8312
	// (get) Token: 0x06015606 RID: 87558
	// (set) Token: 0x06015607 RID: 87559
	bool? WithAnimObject { get; set; }

	// Token: 0x17002079 RID: 8313
	// (get) Token: 0x06015608 RID: 87560
	// (set) Token: 0x06015609 RID: 87561
	USkeletalMeshComponent AnimMeshComp { get; set; }

	// Token: 0x1700207A RID: 8314
	// (get) Token: 0x0601560A RID: 87562
	// (set) Token: 0x0601560B RID: 87563
	bool? IsGroup { get; set; }
}
