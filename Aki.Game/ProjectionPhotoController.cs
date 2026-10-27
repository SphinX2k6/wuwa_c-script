using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

// Token: 0x02000EE6 RID: 3814
[NullableContext(1)]
[Nullable(0)]
public class ProjectionPhotoController : ControllerBase
{
	// Token: 0x06005F8E RID: 24462 RVA: 0x0011E234 File Offset: 0x0011C434
	public void StartProjectionPhotoGameplay(long entityId, int pbDataId, IProjectionMachine config, Action<bool> finishCallback)
	{
		UiManager.Instance.OpenView(EUiViewName.ProjectionPhotoView, new ProjectionPhotoViewParams
		{
			EntityId = entityId,
			PbDataId = pbDataId,
			Config = config,
			FinishCallback = finishCallback
		}, null);
	}

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x06005F8F RID: 24463 RVA: 0x0011E268 File Offset: 0x0011C468
	public static ProjectionPhotoController Instance
	{
		get
		{
			return ProjectionPhotoController._Instance;
		}
	}

	// Token: 0x06005F90 RID: 24464 RVA: 0x0011E26F File Offset: 0x0011C46F
	public static ProjectionPhotoController GetOrCreateInstance()
	{
		if (ProjectionPhotoController._Instance == null)
		{
			ProjectionPhotoController.CreateInstance();
		}
		return ProjectionPhotoController._Instance;
	}

	// Token: 0x06005F91 RID: 24465 RVA: 0x0011E283 File Offset: 0x0011C483
	public static bool CreateInstance()
	{
		if (ProjectionPhotoController._Instance != null)
		{
			return true;
		}
		ProjectionPhotoController._Instance = new ProjectionPhotoController();
		return true;
	}

	// Token: 0x06005F92 RID: 24466 RVA: 0x0011E299 File Offset: 0x0011C499
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x0011E29B File Offset: 0x0011C49B
	public static void ResetStaticDefaultValue()
	{
		ProjectionPhotoController._Instance = null;
	}

	// Token: 0x06005F94 RID: 24468 RVA: 0x0011E2A3 File Offset: 0x0011C4A3
	static ProjectionPhotoController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ProjectionPhotoController.CreateStaticDefaultValue), new Action(ProjectionPhotoController.ResetStaticDefaultValue));
	}

	// Token: 0x04002B4B RID: 11083
	[Nullable(2)]
	private static ProjectionPhotoController _Instance;
}
