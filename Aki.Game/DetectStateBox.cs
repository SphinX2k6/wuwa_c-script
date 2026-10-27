using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000126 RID: 294
[NullableContext(1)]
[Nullable(0)]
public class DetectStateBox
{
	// Token: 0x060011F8 RID: 4600 RVA: 0x0006642B File Offset: 0x0006462B
	public DetectStateBox(UTraceBoxElement boxElement)
	{
		this.BoxElement = boxElement;
	}

	// Token: 0x04000D82 RID: 3458
	public Vector Offset = Vector.Create();

	// Token: 0x04000D83 RID: 3459
	public Vector CurrentPosition = Vector.Create();

	// Token: 0x04000D84 RID: 3460
	public Vector LastFramePosition = Vector.Create();

	// Token: 0x04000D85 RID: 3461
	public readonly UTraceBoxElement BoxElement;
}
