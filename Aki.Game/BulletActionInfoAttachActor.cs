using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002D8D RID: 11661
public class BulletActionInfoAttachActor : BulletActionInfoBase
{
	// Token: 0x060187F7 RID: 100343 RVA: 0x0063C937 File Offset: 0x0063AB37
	public BulletActionInfoAttachActor(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187F8 RID: 100344 RVA: 0x0063C940 File Offset: 0x0063AB40
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

	// Token: 0x0400B5B0 RID: 46512
	public bool IsParentActor;

	// Token: 0x0400B5B1 RID: 46513
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x0400B5B2 RID: 46514
	public FName? SocketName;

	// Token: 0x0400B5B3 RID: 46515
	public EAttachmentRule? LocationRule;

	// Token: 0x0400B5B4 RID: 46516
	public EAttachmentRule? RotationRule;

	// Token: 0x0400B5B5 RID: 46517
	public EAttachmentRule? ScaleRule;

	// Token: 0x0400B5B6 RID: 46518
	public bool WeldSimulatedBodies;

	// Token: 0x0400B5B7 RID: 46519
	public FVectorDouble? RelativeLocation;

	// Token: 0x0400B5B8 RID: 46520
	public FRotator? RelativeRotation;
}
