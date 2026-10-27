using System;
using System.Runtime.CompilerServices;

// Token: 0x02000222 RID: 546
[NullableContext(1)]
[Nullable(0)]
internal struct ZoneSnapshot
{
	// Token: 0x06002171 RID: 8561 RVA: 0x000C11BC File Offset: 0x000BF3BC
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

	// Token: 0x0400160B RID: 5643
	public readonly Vector CenterPosition;

	// Token: 0x0400160C RID: 5644
	public readonly Vector CameraOffset;

	// Token: 0x0400160D RID: 5645
	public readonly Vector CameraOffsetAlpha;

	// Token: 0x0400160E RID: 5646
	public readonly Rotator CameraRotation;

	// Token: 0x0400160F RID: 5647
	public readonly Transform BoxTransform;

	// Token: 0x04001610 RID: 5648
	public readonly Vector BoxExtend;

	// Token: 0x04001611 RID: 5649
	public bool HasBox;
}
