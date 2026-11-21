using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000126 RID: 294
[NullableContext(1)]
[Nullable(0)]
public class DetectStateBox
{
	// Token: 0x060011FE RID: 4606 RVA: 0x00067B9F File Offset: 0x00065D9F
	public DetectStateBox(UTraceBoxElement boxElement)
	{
		this.BoxElement = boxElement;
	}

	// Token: 0x04000D8A RID: 3466
	public Vector Offset = Vector.Create();

	// Token: 0x04000D8B RID: 3467
	public Vector CurrentPosition = Vector.Create();

	// Token: 0x04000D8C RID: 3468
	public Vector LastFramePosition = Vector.Create();

	// Token: 0x04000D8D RID: 3469
	public readonly UTraceBoxElement BoxElement;
}
