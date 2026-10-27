using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C93 RID: 11411
[NullableContext(2)]
[Nullable(0)]
public class MaterialHandle : IMaterialHandle
{
	// Token: 0x1700202A RID: 8234
	// (get) Token: 0x06017D98 RID: 97688 RVA: 0x00610B8C File Offset: 0x0060ED8C
	// (set) Token: 0x06017D99 RID: 97689 RVA: 0x00610B94 File Offset: 0x0060ED94
	public string EffectId { get; set; }

	// Token: 0x1700202B RID: 8235
	// (get) Token: 0x06017D9A RID: 97690 RVA: 0x00610B9D File Offset: 0x0060ED9D
	// (set) Token: 0x06017D9B RID: 97691 RVA: 0x00610BA5 File Offset: 0x0060EDA5
	public string EffectPath { get; set; }

	// Token: 0x1700202C RID: 8236
	// (get) Token: 0x06017D9C RID: 97692 RVA: 0x00610BAE File Offset: 0x0060EDAE
	// (set) Token: 0x06017D9D RID: 97693 RVA: 0x00610BB6 File Offset: 0x0060EDB6
	public int HandleId { get; set; }

	// Token: 0x1700202D RID: 8237
	// (get) Token: 0x06017D9E RID: 97694 RVA: 0x00610BBF File Offset: 0x0060EDBF
	// (set) Token: 0x06017D9F RID: 97695 RVA: 0x00610BC7 File Offset: 0x0060EDC7
	public int RenderingId { get; set; }

	// Token: 0x1700202E RID: 8238
	// (get) Token: 0x06017DA0 RID: 97696 RVA: 0x00610BD0 File Offset: 0x0060EDD0
	// (set) Token: 0x06017DA1 RID: 97697 RVA: 0x00610BD8 File Offset: 0x0060EDD8
	public UObject MaterialAssetData { get; set; }

	// Token: 0x1700202F RID: 8239
	// (get) Token: 0x06017DA2 RID: 97698 RVA: 0x00610BE1 File Offset: 0x0060EDE1
	// (set) Token: 0x06017DA3 RID: 97699 RVA: 0x00610BE9 File Offset: 0x0060EDE9
	public bool? WithAnimObject { get; set; }

	// Token: 0x17002030 RID: 8240
	// (get) Token: 0x06017DA4 RID: 97700 RVA: 0x00610BF2 File Offset: 0x0060EDF2
	// (set) Token: 0x06017DA5 RID: 97701 RVA: 0x00610BFA File Offset: 0x0060EDFA
	public USkeletalMeshComponent AnimMeshComp { get; set; }

	// Token: 0x17002031 RID: 8241
	// (get) Token: 0x06017DA6 RID: 97702 RVA: 0x00610C03 File Offset: 0x0060EE03
	// (set) Token: 0x06017DA7 RID: 97703 RVA: 0x00610C0B File Offset: 0x0060EE0B
	public bool? IsGroup { get; set; }
}
