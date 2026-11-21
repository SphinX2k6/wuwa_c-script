using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02001A40 RID: 6720
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhotographQuickModel : ModelBase
{
	// Token: 0x06010905 RID: 67845 RVA: 0x004D8E48 File Offset: 0x004D7048
	[NullableContext(2)]
	public PhotoCameraHandler GetHandler()
	{
		return this.CaptureHandler;
	}

	// Token: 0x06010906 RID: 67846 RVA: 0x004D8E50 File Offset: 0x004D7050
	public void ClearHandler()
	{
		PhotoCameraHandler captureHandler = this.CaptureHandler;
		if (captureHandler != null)
		{
			captureHandler.Clear();
		}
		this.CaptureHandler = null;
	}

	// Token: 0x06010907 RID: 67847 RVA: 0x004D8E6C File Offset: 0x004D706C
	public void InitHandlerForCaptureCollect()
	{
		ACameraActor acameraActor = CameraController.Instance.GetMainPlayerCameraManager().ViewTarget.Target as ACameraActor;
		if (acameraActor == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "InitHandlerForCaptureCollect 缺少相机Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		FightCameraHandler fightCameraHandler = new FightCameraHandler();
		fightCameraHandler.Init(acameraActor);
		this.CaptureHandler = fightCameraHandler;
	}

	// Token: 0x17001919 RID: 6425
	// (get) Token: 0x06010908 RID: 67848 RVA: 0x004D8EC7 File Offset: 0x004D70C7
	public static PhotographQuickModel Instance
	{
		get
		{
			return PhotographQuickModel._Instance;
		}
	}

	// Token: 0x06010909 RID: 67849 RVA: 0x004D8ECE File Offset: 0x004D70CE
	public static PhotographQuickModel GetOrCreateInstance()
	{
		if (PhotographQuickModel._Instance == null)
		{
			PhotographQuickModel.CreateInstance();
		}
		return PhotographQuickModel._Instance;
	}

	// Token: 0x0601090A RID: 67850 RVA: 0x004D8EE2 File Offset: 0x004D70E2
	public static bool CreateInstance()
	{
		if (PhotographQuickModel._Instance != null)
		{
			return true;
		}
		PhotographQuickModel._Instance = new PhotographQuickModel();
		return true;
	}

	// Token: 0x0601090B RID: 67851 RVA: 0x004D8EF8 File Offset: 0x004D70F8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601090C RID: 67852 RVA: 0x004D8EFA File Offset: 0x004D70FA
	public static void ResetStaticDefaultValue()
	{
		PhotographQuickModel._Instance = null;
	}

	// Token: 0x0601090D RID: 67853 RVA: 0x004D8F02 File Offset: 0x004D7102
	static PhotographQuickModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographQuickModel.CreateStaticDefaultValue), new Action(PhotographQuickModel.ResetStaticDefaultValue));
	}

	// Token: 0x040092B3 RID: 37555
	[Nullable(2)]
	private PhotoCameraHandler CaptureHandler;

	// Token: 0x040092B4 RID: 37556
	[Nullable(2)]
	private static PhotographQuickModel _Instance;
}
