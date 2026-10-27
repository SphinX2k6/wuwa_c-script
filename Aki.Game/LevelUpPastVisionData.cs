using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002421 RID: 9249
public class LevelUpPastVisionData
{
	// Token: 0x04008BB0 RID: 35760
	public int Level;

	// Token: 0x04008BB1 RID: 35761
	public int UniqueId;

	// Token: 0x04008BB2 RID: 35762
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<AttrListScrollData> AttrListScrollData;

	// Token: 0x04008BB3 RID: 35763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionSlotData> SlotData;

	// Token: 0x04008BB4 RID: 35764
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Aki.Protocol.PhantomPropInfo> SubProp;
}
