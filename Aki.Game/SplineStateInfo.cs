using System;
using System.Runtime.CompilerServices;

// Token: 0x02002756 RID: 10070
[NullableContext(1)]
[Nullable(0)]
public class SplineStateInfo
{
	// Token: 0x0601948B RID: 103563 RVA: 0x007B9087 File Offset: 0x007B7287
	public SplineStateInfo(int id, Vector loc)
	{
		this.PbDataId = id;
		this.Location = loc;
	}

	// Token: 0x0400DD44 RID: 56644
	public int PbDataId;

	// Token: 0x0400DD45 RID: 56645
	public Vector Location = Vector.Create();

	// Token: 0x0400DD46 RID: 56646
	public bool InRange;
}
