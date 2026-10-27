using System;
using UnrealEngine;

// Token: 0x02002C49 RID: 11337
public class UiCameraPostEffectComponent : UiCameraComponent
{
	// Token: 0x06017A60 RID: 96864 RVA: 0x00604A96 File Offset: 0x00602C96
	public void SetCameraFocusMethod(ECameraFocusMethod focusMethod)
	{
		this.CineCameraComponent.FocusSettings.FocusMethod = focusMethod;
	}

	// Token: 0x06017A61 RID: 96865 RVA: 0x00604AA9 File Offset: 0x00602CA9
	public void SetCameraFieldOfView(float fieldOfView)
	{
		this.CineCameraComponent.SetFieldOfView(fieldOfView);
	}

	// Token: 0x06017A62 RID: 96866 RVA: 0x00604AB7 File Offset: 0x00602CB7
	public void SetCameraFocalDistance(float focalDistance)
	{
		this.CineCameraComponent.FocusSettings.ManualFocusDistance = focalDistance;
	}

	// Token: 0x06017A63 RID: 96867 RVA: 0x00604ACA File Offset: 0x00602CCA
	public void SetCameraCurrentFocalLength(float currentFocalLength)
	{
		this.CineCameraComponent.CurrentFocalLength = currentFocalLength;
	}

	// Token: 0x06017A64 RID: 96868 RVA: 0x00604AD8 File Offset: 0x00602CD8
	public void SetCameraAperture(float aperture)
	{
		this.CineCameraComponent.CurrentAperture = aperture;
	}

	// Token: 0x06017A65 RID: 96869 RVA: 0x00604AE6 File Offset: 0x00602CE6
	public void SetCameraFocalRegion(float focalRegion)
	{
		this.CineCameraComponent.CurrentFocalRegion = focalRegion;
	}

	// Token: 0x06017A66 RID: 96870 RVA: 0x00604AF4 File Offset: 0x00602CF4
	public void SetCameraPostProcessBlendWeight(float postProcessBlendWeight)
	{
		this.CineCameraComponent.SetPostProcessBlendWeight(postProcessBlendWeight);
	}

	// Token: 0x06017A67 RID: 96871 RVA: 0x00604B02 File Offset: 0x00602D02
	public float GetFieldOfView()
	{
		return this.CineCameraComponent.FieldOfView;
	}

	// Token: 0x06017A68 RID: 96872 RVA: 0x00604B0F File Offset: 0x00602D0F
	public float GetManualFocusDistance()
	{
		return this.CineCameraComponent.FocusSettings.ManualFocusDistance;
	}

	// Token: 0x06017A69 RID: 96873 RVA: 0x00604B21 File Offset: 0x00602D21
	public float GetCurrentAperture()
	{
		return this.CineCameraComponent.CurrentAperture;
	}

	// Token: 0x06017A6A RID: 96874 RVA: 0x00604B2E File Offset: 0x00602D2E
	public float GetPostProcessBlendWeight()
	{
		return this.CineCameraComponent.PostProcessBlendWeight;
	}
}
