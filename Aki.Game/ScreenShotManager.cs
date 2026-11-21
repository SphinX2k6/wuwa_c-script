using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EDA RID: 7898
public class ScreenShotManager : IStaticVariableResetter
{
	// Token: 0x0601385F RID: 79967 RVA: 0x005B14FB File Offset: 0x005AF6FB
	static ScreenShotManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScreenShotManager.CreateStaticDefaultValue), new Action(ScreenShotManager.ResetStaticDefaultValue));
	}

	// Token: 0x06013860 RID: 79968 RVA: 0x005B151A File Offset: 0x005AF71A
	public static void CreateStaticDefaultValue()
	{
		ScreenShotManager.GameScreenshotTask = null;
	}

	// Token: 0x06013861 RID: 79969 RVA: 0x005B1522 File Offset: 0x005AF722
	public static void ResetStaticDefaultValue()
	{
		ScreenShotManager.ResetScreenShot();
		ScreenShotManager.GameScreenshotTask = null;
	}

	// Token: 0x06013862 RID: 79970 RVA: 0x005B152F File Offset: 0x005AF72F
	public static void Clear()
	{
		ScreenShotManager.ResetScreenShot();
	}

	// Token: 0x06013863 RID: 79971 RVA: 0x005B1538 File Offset: 0x005AF738
	[NullableContext(1)]
	[return: Nullable(2)]
	public static UGameScreenshotTask PrepareTakeScreenshot(string relativePath, float minX, float minY, float maxX, float maxY, bool saveFile, float screenshotResolutionX = 0f, float screenshotResolutionY = 0f, int resolutionMultiplier = 1)
	{
		ScreenShotManager.ResetScreenShot();
		Vector2D vector2D = Vector2D.Create((double)minX, (double)minY);
		Vector2D vector2D2 = Vector2D.Create((double)maxX, (double)maxY);
		ScreenShotManager.GameScreenshotTask = UKuroGameScreenshotBPLibrary.PrepareTakeScreenshot(GlobalData.World, relativePath, vector2D.ToUeVector2D(false), vector2D2.ToUeVector2D(false), screenshotResolutionX, screenshotResolutionY, saveFile, resolutionMultiplier);
		return ScreenShotManager.GameScreenshotTask;
	}

	// Token: 0x06013864 RID: 79972 RVA: 0x005B158A File Offset: 0x005AF78A
	public static void ResetScreenShot()
	{
		if (ScreenShotManager.GameScreenshotTask != null && ScreenShotManager.GameScreenshotTask.IsValid())
		{
			ScreenShotManager.GameScreenshotTask.Reset();
		}
		ScreenShotManager.GameScreenshotTask = null;
	}

	// Token: 0x06013865 RID: 79973 RVA: 0x005B15AF File Offset: 0x005AF7AF
	public static void RequestIOSPhotoLibraryAuthorization()
	{
		UGameScreenshotTask gameScreenshotTask = ScreenShotManager.GameScreenshotTask;
		if (gameScreenshotTask == null)
		{
			return;
		}
		gameScreenshotTask.RequestIOSPhotoLibraryAuthorization();
	}

	// Token: 0x06013866 RID: 79974 RVA: 0x005B15C0 File Offset: 0x005AF7C0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public static UniTask<UTexture2D> TakeFullScreenShotToTextureAsync(bool bContainUi = true)
	{
		ScreenShotManager.<TakeFullScreenShotToTextureAsync>d__8 <TakeFullScreenShotToTextureAsync>d__;
		<TakeFullScreenShotToTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture2D>.Create();
		<TakeFullScreenShotToTextureAsync>d__.bContainUi = bContainUi;
		<TakeFullScreenShotToTextureAsync>d__.<>1__state = -1;
		<TakeFullScreenShotToTextureAsync>d__.<>t__builder.Start<ScreenShotManager.<TakeFullScreenShotToTextureAsync>d__8>(ref <TakeFullScreenShotToTextureAsync>d__);
		return <TakeFullScreenShotToTextureAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013867 RID: 79975 RVA: 0x005B1603 File Offset: 0x005AF803
	[NullableContext(1)]
	public static UTexture2D CreateTextureFromBuffer(int minX, int minY, int maxX, int maxY)
	{
		return ULGUIBPLibrary.CreateTexture2DFromBuffer(minX, maxX, minY, maxY);
	}

	// Token: 0x0400A6E3 RID: 42723
	[Nullable(2)]
	private static UGameScreenshotTask GameScreenshotTask;
}
