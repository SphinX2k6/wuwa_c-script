using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200197C RID: 6524
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleTopData
{
	// Token: 0x04008EE2 RID: 36578
	public string Name = "";

	// Token: 0x04008EE3 RID: 36579
	public int Index;

	// Token: 0x04008EE4 RID: 36580
	public int Cost;

	// Token: 0x04008EE5 RID: 36581
	public List<VisionAssembleSuitItemData> SuitList = new List<VisionAssembleSuitItemData>();
}
