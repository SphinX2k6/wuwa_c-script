using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021EC RID: 8684
[NullableContext(2)]
[Nullable(0)]
public class MaterialHandle : IMaterialHandle
{
	// Token: 0x1700207B RID: 8315
	// (get) Token: 0x0601560C RID: 87564 RVA: 0x0063672C File Offset: 0x0063492C
	// (set) Token: 0x0601560D RID: 87565 RVA: 0x00636734 File Offset: 0x00634934
	public string EffectId { get; set; }

	// Token: 0x1700207C RID: 8316
	// (get) Token: 0x0601560E RID: 87566 RVA: 0x0063673D File Offset: 0x0063493D
	// (set) Token: 0x0601560F RID: 87567 RVA: 0x00636745 File Offset: 0x00634945
	public string EffectPath { get; set; }

	// Token: 0x1700207D RID: 8317
	// (get) Token: 0x06015610 RID: 87568 RVA: 0x0063674E File Offset: 0x0063494E
	// (set) Token: 0x06015611 RID: 87569 RVA: 0x00636756 File Offset: 0x00634956
	public int HandleId { get; set; }

	// Token: 0x1700207E RID: 8318
	// (get) Token: 0x06015612 RID: 87570 RVA: 0x0063675F File Offset: 0x0063495F
	// (set) Token: 0x06015613 RID: 87571 RVA: 0x00636767 File Offset: 0x00634967
	public int RenderingId { get; set; }

	// Token: 0x1700207F RID: 8319
	// (get) Token: 0x06015614 RID: 87572 RVA: 0x00636770 File Offset: 0x00634970
	// (set) Token: 0x06015615 RID: 87573 RVA: 0x00636778 File Offset: 0x00634978
	public UObject MaterialAssetData { get; set; }

	// Token: 0x17002080 RID: 8320
	// (get) Token: 0x06015616 RID: 87574 RVA: 0x00636781 File Offset: 0x00634981
	// (set) Token: 0x06015617 RID: 87575 RVA: 0x00636789 File Offset: 0x00634989
	public bool? WithAnimObject { get; set; }

	// Token: 0x17002081 RID: 8321
	// (get) Token: 0x06015618 RID: 87576 RVA: 0x00636792 File Offset: 0x00634992
	// (set) Token: 0x06015619 RID: 87577 RVA: 0x0063679A File Offset: 0x0063499A
	public USkeletalMeshComponent AnimMeshComp { get; set; }

	// Token: 0x17002082 RID: 8322
	// (get) Token: 0x0601561A RID: 87578 RVA: 0x006367A3 File Offset: 0x006349A3
	// (set) Token: 0x0601561B RID: 87579 RVA: 0x006367AB File Offset: 0x006349AB
	public bool? IsGroup { get; set; }
}
