using System;
using System.Runtime.CompilerServices;

// Token: 0x020025D2 RID: 9682
[NullableContext(1)]
[Nullable(0)]
public class ReadOnlyFastMoveSample : IClear
{
	// Token: 0x060181E4 RID: 98788 RVA: 0x0073D1B5 File Offset: 0x0073B3B5
	public bool ClearObject()
	{
		this.IsInit = false;
		this.Location = Vector.Create();
		this.Rotation = Rotator.Create();
		this.LinearVelocity = Vector.Create();
		return true;
	}

	// Token: 0x0400CF41 RID: 53057
	public Vector Location = Vector.Create();

	// Token: 0x0400CF42 RID: 53058
	public Rotator Rotation = Rotator.Create();

	// Token: 0x0400CF43 RID: 53059
	public Vector LinearVelocity = Vector.Create();

	// Token: 0x0400CF44 RID: 53060
	public int MovementMode;

	// Token: 0x0400CF45 RID: 53061
	public bool IsInit;
}
