using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C37 RID: 11319
[NullableContext(2)]
[Nullable(0)]
public class UiCameraLoadingAnimation
{
	// Token: 0x060179D4 RID: 96724 RVA: 0x00602989 File Offset: 0x00600B89
	public void Initialize()
	{
	}

	// Token: 0x060179D5 RID: 96725 RVA: 0x0060298C File Offset: 0x00600B8C
	public void Play(float timeLength, float manualFocusDistance, float currentAperture)
	{
		this.UiCamera = UiCameraManager.Get();
		this.UiCameraPostEffectComponent = this.UiCamera.GetUiCameraComponent<UiCameraPostEffectComponent>();
		this.CurrentTime = 0f;
		this.TimeLength = timeLength;
		this.SourceFocusDistance = this.UiCameraPostEffectComponent.GetManualFocusDistance();
		this.SourceAperture = this.UiCameraPostEffectComponent.GetCurrentAperture();
		this.TargetFocusDistance = manualFocusDistance;
		this.TargetAperture = currentAperture;
		this.IsPlaying = true;
	}

	// Token: 0x060179D6 RID: 96726 RVA: 0x006029FE File Offset: 0x00600BFE
	public void Stop()
	{
		this.TimeLength = 0f;
		this.IsPlaying = false;
		this.PlayPromise = null;
	}

	// Token: 0x060179D7 RID: 96727 RVA: 0x00602A1C File Offset: 0x00600C1C
	public void Tick(float delta)
	{
		if (this.TimeLength == 0f || !this.IsPlaying)
		{
			return;
		}
		if (this.CurrentTime >= this.TimeLength)
		{
			CustomPromise<bool> playPromise = this.PlayPromise;
			if (playPromise != null)
			{
				playPromise.SetResult(true);
			}
			this.Stop();
			return;
		}
		float cameraFocalDistance = MathUtils.Instance.Lerp(this.SourceFocusDistance, this.TargetFocusDistance, this.CurrentTime / this.TimeLength);
		float cameraAperture = MathUtils.Instance.Lerp(this.SourceAperture, this.TargetAperture, this.CurrentTime / this.TimeLength);
		this.UiCameraPostEffectComponent.SetCameraFocalDistance(cameraFocalDistance);
		this.UiCameraPostEffectComponent.SetCameraAperture(cameraAperture);
		this.CurrentTime += 10f;
	}

	// Token: 0x0400B00F RID: 45071
	private float CurrentTime;

	// Token: 0x0400B010 RID: 45072
	private float TimeLength;

	// Token: 0x0400B011 RID: 45073
	private float TargetFocusDistance;

	// Token: 0x0400B012 RID: 45074
	private float TargetAperture;

	// Token: 0x0400B013 RID: 45075
	private float SourceFocusDistance;

	// Token: 0x0400B014 RID: 45076
	private float SourceAperture;

	// Token: 0x0400B015 RID: 45077
	public bool IsPlaying;

	// Token: 0x0400B016 RID: 45078
	private CustomPromise<bool> PlayPromise;

	// Token: 0x0400B017 RID: 45079
	private UiCamera UiCamera;

	// Token: 0x0400B018 RID: 45080
	private UiCameraPostEffectComponent UiCameraPostEffectComponent;
}
