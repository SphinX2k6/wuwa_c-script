using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002555 RID: 9557
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhotographQuickModel : ModelBase
{
	// Token: 0x06013425 RID: 78885 RVA: 0x004CA2C8 File Offset: 0x004C84C8
	[NullableContext(2)]
	public PhotoCameraHandler GetHandler()
	{
		return this.CaptureHandler;
	}

	// Token: 0x06013426 RID: 78886 RVA: 0x004CA2D0 File Offset: 0x004C84D0
	public void ClearHandler()
	{
		PhotoCameraHandler captureHandler = this.CaptureHandler;
		if (captureHandler != null)
		{
			captureHandler.Clear();
		}
		this.CaptureHandler = null;
	}

	// Token: 0x06013427 RID: 78887 RVA: 0x004CA2EC File Offset: 0x004C84EC
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

	// Token: 0x170018E0 RID: 6368
	// (get) Token: 0x06013428 RID: 78888 RVA: 0x004CA347 File Offset: 0x004C8547
	public static PhotographQuickModel Instance
	{
		get
		{
			return PhotographQuickModel._Instance;
		}
	}

	// Token: 0x06013429 RID: 78889 RVA: 0x004CA34E File Offset: 0x004C854E
	public static PhotographQuickModel GetOrCreateInstance()
	{
		if (PhotographQuickModel._Instance == null)
		{
			PhotographQuickModel.CreateInstance();
		}
		return PhotographQuickModel._Instance;
	}

	// Token: 0x0601342A RID: 78890 RVA: 0x004CA362 File Offset: 0x004C8562
	public static bool CreateInstance()
	{
		if (PhotographQuickModel._Instance != null)
		{
			return true;
		}
		PhotographQuickModel._Instance = new PhotographQuickModel();
		return true;
	}

	// Token: 0x0601342B RID: 78891 RVA: 0x004CA378 File Offset: 0x004C8578
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601342C RID: 78892 RVA: 0x004CA37A File Offset: 0x004C857A
	public static void ResetStaticDefaultValue()
	{
		PhotographQuickModel._Instance = null;
	}

	// Token: 0x0601342D RID: 78893 RVA: 0x004CA382 File Offset: 0x004C8582
	static PhotographQuickModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographQuickModel.CreateStaticDefaultValue), new Action(PhotographQuickModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400915A RID: 37210
	[Nullable(2)]
	private PhotoCameraHandler CaptureHandler;

	// Token: 0x0400915B RID: 37211
	[Nullable(2)]
	private static PhotographQuickModel _Instance;
}
