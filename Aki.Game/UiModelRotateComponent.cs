using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C96 RID: 11414
[NullableContext(2)]
[Nullable(0)]
public class UiModelRotateComponent : UiModelComponentBase
{
	// Token: 0x06017DB8 RID: 97720 RVA: 0x00611296 File Offset: 0x0060F496
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.Rotator = Rotator.Create();
	}

	// Token: 0x06017DB9 RID: 97721 RVA: 0x006112B4 File Offset: 0x0060F4B4
	public void SetRotateParam(float aroundTime, ERotateAxis axis = ERotateAxis.Yaw, bool isPlus = true)
	{
		this.DeltaSecondRotate = ((aroundTime != 0f) ? (360f / aroundTime) : 0f);
		this.RotateAxis = new ERotateAxis?(axis);
		this.IsRotatePlus = isPlus;
	}

	// Token: 0x06017DBA RID: 97722 RVA: 0x006112E5 File Offset: 0x0060F4E5
	public void StartRotate()
	{
		this.IsRotating = true;
		this.NeedTick = true;
	}

	// Token: 0x06017DBB RID: 97723 RVA: 0x006112F5 File Offset: 0x0060F4F5
	public void StopRotate()
	{
		this.IsRotating = false;
		this.NeedTick = false;
	}

	// Token: 0x06017DBC RID: 97724 RVA: 0x00611308 File Offset: 0x0060F508
	protected override void OnTick(float deltaTime)
	{
		if (!this.IsRotating || this.DeltaSecondRotate <= 0f)
		{
			return;
		}
		int num = this.IsRotatePlus ? 1 : -1;
		float num2 = this.DeltaSecondRotate * deltaTime * 1000f * (float)num;
		ERotateAxis? rotateAxis = this.RotateAxis;
		ERotateAxis erotateAxis = ERotateAxis.Pitch;
		if (rotateAxis.GetValueOrDefault() == erotateAxis & rotateAxis != null)
		{
			this.Rotator.Pitch = num2;
		}
		else if (this.RotateAxis.GetValueOrDefault() == ERotateAxis.Yaw)
		{
			this.Rotator.Yaw = num2;
		}
		else if (this.RotateAxis.GetValueOrDefault() == ERotateAxis.Roll)
		{
			this.Rotator.Roll = num2;
		}
		FHitResult fhitResult = new FHitResult();
		this.ActorComponent.Actor.K2_AddActorLocalRotation(this.Rotator.ToUeRotator(), false, ref fhitResult, false);
	}

	// Token: 0x0400B1DE RID: 45534
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B1DF RID: 45535
	private float DeltaSecondRotate;

	// Token: 0x0400B1E0 RID: 45536
	private bool IsRotating;

	// Token: 0x0400B1E1 RID: 45537
	private Rotator Rotator;

	// Token: 0x0400B1E2 RID: 45538
	private ERotateAxis? RotateAxis;

	// Token: 0x0400B1E3 RID: 45539
	private bool IsRotatePlus;
}
