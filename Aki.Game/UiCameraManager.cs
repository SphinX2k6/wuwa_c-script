using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C4F RID: 11343
public class UiCameraManager : IStaticVariableResetter
{
	// Token: 0x06017A9A RID: 96922 RVA: 0x006052E0 File Offset: 0x006034E0
	static UiCameraManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiCameraManager.CreateStaticDefaultValue), new Action(UiCameraManager.ResetStaticDefaultValue));
	}

	// Token: 0x06017A9B RID: 96923 RVA: 0x006052FF File Offset: 0x006034FF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017A9C RID: 96924 RVA: 0x00605301 File Offset: 0x00603501
	public static void ResetStaticDefaultValue()
	{
		UiCameraManager.UiCamera = null;
	}

	// Token: 0x06017A9D RID: 96925 RVA: 0x00605309 File Offset: 0x00603509
	public static void Initialize()
	{
	}

	// Token: 0x06017A9E RID: 96926 RVA: 0x0060530B File Offset: 0x0060350B
	public static void Clear()
	{
		UiCamera uiCamera = UiCameraManager.UiCamera;
		if (uiCamera != null)
		{
			uiCamera.Destroy(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
		}
		UiCameraManager.UiCamera = null;
	}

	// Token: 0x06017A9F RID: 96927 RVA: 0x0060532E File Offset: 0x0060352E
	[NullableContext(1)]
	public static UiCamera Get()
	{
		if (UiCameraManager.UiCamera == null)
		{
			UiCameraManager.UiCamera = new UiCamera();
			UiCameraManager.UiCamera.Initialize();
		}
		return UiCameraManager.UiCamera;
	}

	// Token: 0x06017AA0 RID: 96928 RVA: 0x00605351 File Offset: 0x00603551
	public static void Destroy(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f)
	{
		UiCamera uiCamera = UiCameraManager.UiCamera;
		if (uiCamera != null)
		{
			uiCamera.Destroy(blendTime, blendFunction, blendExp);
		}
		UiCameraManager.UiCamera = null;
	}

	// Token: 0x0400B068 RID: 45160
	[Nullable(2)]
	private static UiCamera UiCamera;
}
