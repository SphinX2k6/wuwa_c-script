using System;
using System.Runtime.CompilerServices;

// Token: 0x02000226 RID: 550
[NullableContext(1)]
[Nullable(0)]
internal struct ZoneSnapshot
{
	// Token: 0x0600221F RID: 8735 RVA: 0x000C84DC File Offset: 0x000C66DC
	public ZoneSnapshot()
	{
		this.CenterPosition = Vector.Create();
		this.CameraOffset = Vector.Create();
		this.CameraOffsetAlpha = Vector.Create();
		this.CameraRotation = Rotator.Create();
		this.BoxTransform = Transform.Create();
		this.BoxExtend = Vector.Create();
		this.HasBox = false;
		this.HasBox = false;
	}

	// Token: 0x0400164D RID: 5709
	public readonly Vector CenterPosition;

	// Token: 0x0400164E RID: 5710
	public readonly Vector CameraOffset;

	// Token: 0x0400164F RID: 5711
	public readonly Vector CameraOffsetAlpha;

	// Token: 0x04001650 RID: 5712
	public readonly Rotator CameraRotation;

	// Token: 0x04001651 RID: 5713
	public readonly Transform BoxTransform;

	// Token: 0x04001652 RID: 5714
	public readonly Vector BoxExtend;

	// Token: 0x04001653 RID: 5715
	public bool HasBox;
}
