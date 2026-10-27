using System;
using System.Runtime.CompilerServices;

// Token: 0x020019AA RID: 6570
[NullableContext(1)]
[Nullable(0)]
public class SpineAnimationQueueParam : ISpineAnimationQueueParam
{
	// Token: 0x1700100F RID: 4111
	// (get) Token: 0x0600BF9F RID: 49055 RVA: 0x002B4171 File Offset: 0x002B2371
	// (set) Token: 0x0600BFA0 RID: 49056 RVA: 0x002B4179 File Offset: 0x002B2379
	public int LayerIndex { get; set; }

	// Token: 0x17001010 RID: 4112
	// (get) Token: 0x0600BFA1 RID: 49057 RVA: 0x002B4182 File Offset: 0x002B2382
	// (set) Token: 0x0600BFA2 RID: 49058 RVA: 0x002B418A File Offset: 0x002B238A
	public string AnimationName { get; set; } = "";

	// Token: 0x17001011 RID: 4113
	// (get) Token: 0x0600BFA3 RID: 49059 RVA: 0x002B4193 File Offset: 0x002B2393
	// (set) Token: 0x0600BFA4 RID: 49060 RVA: 0x002B419B File Offset: 0x002B239B
	public bool Loop { get; set; }
}
