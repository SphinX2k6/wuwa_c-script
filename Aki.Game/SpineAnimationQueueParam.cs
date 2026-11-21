using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E68 RID: 3688
[NullableContext(1)]
[Nullable(0)]
public class SpineAnimationQueueParam : ISpineAnimationQueueParam
{
	// Token: 0x17001034 RID: 4148
	// (get) Token: 0x060093A9 RID: 37801 RVA: 0x002BF101 File Offset: 0x002BD301
	// (set) Token: 0x060093AA RID: 37802 RVA: 0x002BF109 File Offset: 0x002BD309
	public int LayerIndex { get; set; }

	// Token: 0x17001035 RID: 4149
	// (get) Token: 0x060093AB RID: 37803 RVA: 0x002BF112 File Offset: 0x002BD312
	// (set) Token: 0x060093AC RID: 37804 RVA: 0x002BF11A File Offset: 0x002BD31A
	public string AnimationName { get; set; } = "";

	// Token: 0x17001036 RID: 4150
	// (get) Token: 0x060093AD RID: 37805 RVA: 0x002BF123 File Offset: 0x002BD323
	// (set) Token: 0x060093AE RID: 37806 RVA: 0x002BF12B File Offset: 0x002BD32B
	public bool Loop { get; set; }
}
