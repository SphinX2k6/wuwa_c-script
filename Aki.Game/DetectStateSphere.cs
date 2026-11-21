using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000128 RID: 296
[NullableContext(1)]
[Nullable(0)]
public class DetectStateSphere
{
	// Token: 0x06001226 RID: 4646 RVA: 0x000686C3 File Offset: 0x000668C3
	public DetectStateSphere(UTraceSphereElement sphereElement)
	{
		this.SphereElement = sphereElement;
	}

	// Token: 0x04000D9D RID: 3485
	public readonly Vector Offset = Vector.Create();

	// Token: 0x04000D9E RID: 3486
	public readonly Vector CurrentPosition = Vector.Create();

	// Token: 0x04000D9F RID: 3487
	public readonly Vector LastFramePosition = Vector.Create();

	// Token: 0x04000DA0 RID: 3488
	public readonly UTraceSphereElement SphereElement;
}
