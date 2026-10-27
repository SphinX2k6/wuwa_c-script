using System;
using System.Runtime.CompilerServices;

// Token: 0x0200307B RID: 12411
[NullableContext(1)]
[Nullable(0)]
public class ReadOnlyFastMoveSample : IClear
{
	// Token: 0x0601A813 RID: 108563 RVA: 0x00716A65 File Offset: 0x00714C65
	public bool ClearObject()
	{
		this.IsInit = false;
		this.Location = Vector.Create();
		this.Rotation = Rotator.Create();
		this.LinearVelocity = Vector.Create();
		return true;
	}

	// Token: 0x0400CB5E RID: 52062
	public Vector Location = Vector.Create();

	// Token: 0x0400CB5F RID: 52063
	public Rotator Rotation = Rotator.Create();

	// Token: 0x0400CB60 RID: 52064
	public Vector LinearVelocity = Vector.Create();

	// Token: 0x0400CB61 RID: 52065
	public int MovementMode;

	// Token: 0x0400CB62 RID: 52066
	public bool IsInit;
}
