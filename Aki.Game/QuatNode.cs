using System;
using System.Runtime.CompilerServices;

// Token: 0x0200005C RID: 92
[NullableContext(1)]
[Nullable(0)]
public class QuatNode
{
	// Token: 0x060003A0 RID: 928 RVA: 0x00010CE1 File Offset: 0x0000EEE1
	public QuatNode(Quat quat, double cost)
	{
		this.Quaternion = Quat.Create(quat);
		this.CostBase = cost;
		this.Cost = 0.0;
		this.VectorCache = Vector.Create();
	}

	// Token: 0x04000265 RID: 613
	public Quat Quaternion;

	// Token: 0x04000266 RID: 614
	public double CostBase;

	// Token: 0x04000267 RID: 615
	public double Cost;

	// Token: 0x04000268 RID: 616
	public Vector VectorCache;
}
