using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021EF RID: 8687
[NullableContext(2)]
[Nullable(0)]
public class UiModelRotateComponent : UiModelComponentBase
{
	// Token: 0x0601562C RID: 87596 RVA: 0x00636E36 File Offset: 0x00635036
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.Rotator = Rotator.Create();
	}

	// Token: 0x0601562D RID: 87597 RVA: 0x00636E54 File Offset: 0x00635054
	public void SetRotateParam(float aroundTime, ERotateAxis axis = ERotateAxis.Yaw, bool isPlus = true)
	{
		this.DeltaSecondRotate = ((aroundTime != 0f) ? (360f / aroundTime) : 0f);
		this.RotateAxis = new ERotateAxis?(axis);
		this.IsRotatePlus = isPlus;
	}

	// Token: 0x0601562E RID: 87598 RVA: 0x00636E85 File Offset: 0x00635085
	public void StartRotate()
	{
		this.IsRotating = true;
		this.NeedTick = true;
	}

	// Token: 0x0601562F RID: 87599 RVA: 0x00636E95 File Offset: 0x00635095
	public void StopRotate()
	{
		this.IsRotating = false;
		this.NeedTick = false;
	}

	// Token: 0x06015630 RID: 87600 RVA: 0x00636EA8 File Offset: 0x006350A8
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

	// Token: 0x0400B549 RID: 46409
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B54A RID: 46410
	private float DeltaSecondRotate;

	// Token: 0x0400B54B RID: 46411
	private bool IsRotating;

	// Token: 0x0400B54C RID: 46412
	private Rotator Rotator;

	// Token: 0x0400B54D RID: 46413
	private ERotateAxis? RotateAxis;

	// Token: 0x0400B54E RID: 46414
	private bool IsRotatePlus;
}
