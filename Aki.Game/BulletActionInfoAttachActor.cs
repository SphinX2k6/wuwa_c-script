using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020022E7 RID: 8935
public class BulletActionInfoAttachActor : BulletActionInfoBase
{
	// Token: 0x06016099 RID: 90265 RVA: 0x0066266F File Offset: 0x0066086F
	public BulletActionInfoAttachActor(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601609A RID: 90266 RVA: 0x00662678 File Offset: 0x00660878
	public override void Clear()
	{
		this.IsParentActor = false;
		this.Actor = null;
		this.SocketName = null;
		this.LocationRule = null;
		this.RotationRule = null;
		this.ScaleRule = null;
		this.WeldSimulatedBodies = false;
		this.RelativeLocation = null;
		this.RelativeRotation = null;
	}

	// Token: 0x0400B925 RID: 47397
	public bool IsParentActor;

	// Token: 0x0400B926 RID: 47398
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x0400B927 RID: 47399
	public FName? SocketName;

	// Token: 0x0400B928 RID: 47400
	public EAttachmentRule? LocationRule;

	// Token: 0x0400B929 RID: 47401
	public EAttachmentRule? RotationRule;

	// Token: 0x0400B92A RID: 47402
	public EAttachmentRule? ScaleRule;

	// Token: 0x0400B92B RID: 47403
	public bool WeldSimulatedBodies;

	// Token: 0x0400B92C RID: 47404
	public FVectorDouble? RelativeLocation;

	// Token: 0x0400B92D RID: 47405
	public FRotator? RelativeRotation;
}
