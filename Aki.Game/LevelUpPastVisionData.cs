using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001906 RID: 6406
public class LevelUpPastVisionData
{
	// Token: 0x04008CF7 RID: 36087
	public int Level;

	// Token: 0x04008CF8 RID: 36088
	public int UniqueId;

	// Token: 0x04008CF9 RID: 36089
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<AttrListScrollData> AttrListScrollData;

	// Token: 0x04008CFA RID: 36090
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionSlotData> SlotData;

	// Token: 0x04008CFB RID: 36091
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Aki.Protocol.PhantomPropInfo> SubProp;
}
