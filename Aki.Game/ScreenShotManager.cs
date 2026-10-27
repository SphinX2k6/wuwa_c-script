using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200295F RID: 10591
public class ScreenShotManager : IStaticVariableResetter
{
	// Token: 0x06015E5B RID: 89691 RVA: 0x005864FB File Offset: 0x005846FB
	static ScreenShotManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScreenShotManager.CreateStaticDefaultValue), new Action(ScreenShotManager.ResetStaticDefaultValue));
	}

	// Token: 0x06015E5C RID: 89692 RVA: 0x0058651A File Offset: 0x0058471A
	public static void CreateStaticDefaultValue()
	{
		ScreenShotManager.GameScreenshotTask = null;
	}

	// Token: 0x06015E5D RID: 89693 RVA: 0x00586522 File Offset: 0x00584722
	public static void ResetStaticDefaultValue()
	{
		ScreenShotManager.GameScreenshotTask = null;
	}

	// Token: 0x06015E5E RID: 89694 RVA: 0x0058652A File Offset: 0x0058472A
	public static void Clear()
	{
		ScreenShotManager.ResetScreenShot();
	}

	// Token: 0x06015E5F RID: 89695 RVA: 0x00586534 File Offset: 0x00584734
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

	// Token: 0x06015E60 RID: 89696 RVA: 0x00586586 File Offset: 0x00584786
	public static void ResetScreenShot()
	{
		if (ScreenShotManager.GameScreenshotTask != null && ScreenShotManager.GameScreenshotTask.IsValid())
		{
			ScreenShotManager.GameScreenshotTask.Reset();
		}
		ScreenShotManager.GameScreenshotTask = null;
	}

	// Token: 0x06015E61 RID: 89697 RVA: 0x005865AB File Offset: 0x005847AB
	public static void RequestIOSPhotoLibraryAuthorization()
	{
		UGameScreenshotTask gameScreenshotTask = ScreenShotManager.GameScreenshotTask;
		if (gameScreenshotTask == null)
		{
			return;
		}
		gameScreenshotTask.RequestIOSPhotoLibraryAuthorization();
	}

	// Token: 0x06015E62 RID: 89698 RVA: 0x005865BC File Offset: 0x005847BC
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

	// Token: 0x06015E63 RID: 89699 RVA: 0x005865FF File Offset: 0x005847FF
	[NullableContext(1)]
	public static UTexture2D CreateTextureFromBuffer(int minX, int minY, int maxX, int maxY)
	{
		return ULGUIBPLibrary.CreateTexture2DFromBuffer(minX, maxX, minY, maxY);
	}

	// Token: 0x0400A2F9 RID: 41721
	[Nullable(2)]
	private static UGameScreenshotTask GameScreenshotTask;
}
