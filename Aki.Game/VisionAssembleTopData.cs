using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002495 RID: 9365
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleTopData
{
	// Token: 0x04008D99 RID: 36249
	public string Name = "";

	// Token: 0x04008D9A RID: 36250
	public int Index;

	// Token: 0x04008D9B RID: 36251
	public int Cost;

	// Token: 0x04008D9C RID: 36252
	public List<VisionAssembleSuitItemData> SuitList = new List<VisionAssembleSuitItemData>();
}
