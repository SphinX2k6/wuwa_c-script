using System;
using System.Runtime.CompilerServices;

// Token: 0x020031E7 RID: 12775
[NullableContext(1)]
[Nullable(0)]
public class SplineStateInfo
{
	// Token: 0x0601B908 RID: 112904 RVA: 0x00790944 File Offset: 0x0078EB44
	public SplineStateInfo(int id, Vector loc)
	{
		this.PbDataId = id;
		this.Location = loc;
	}

	// Token: 0x0400D8A6 RID: 55462
	public int PbDataId;

	// Token: 0x0400D8A7 RID: 55463
	public Vector Location = Vector.Create();

	// Token: 0x0400D8A8 RID: 55464
	public bool InRange;
}
