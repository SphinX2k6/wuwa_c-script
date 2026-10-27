using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000128 RID: 296
[NullableContext(1)]
[Nullable(0)]
public class DetectStateSphere
{
	// Token: 0x06001220 RID: 4640 RVA: 0x00066EF3 File Offset: 0x000650F3
	public DetectStateSphere(UTraceSphereElement sphereElement)
	{
		this.SphereElement = sphereElement;
	}

	// Token: 0x04000D95 RID: 3477
	public readonly Vector Offset = Vector.Create();

	// Token: 0x04000D96 RID: 3478
	public readonly Vector CurrentPosition = Vector.Create();

	// Token: 0x04000D97 RID: 3479
	public readonly Vector LastFramePosition = Vector.Create();

	// Token: 0x04000D98 RID: 3480
	public readonly UTraceSphereElement SphereElement;
}
