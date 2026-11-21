using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

// Token: 0x0200039B RID: 923
[NullableContext(1)]
[Nullable(0)]
public class ProjectionPhotoController : ControllerBase
{
	// Token: 0x06003324 RID: 13092 RVA: 0x0012608C File Offset: 0x0012428C
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

	// Token: 0x1700077A RID: 1914
	// (get) Token: 0x06003325 RID: 13093 RVA: 0x001260C0 File Offset: 0x001242C0
	public static ProjectionPhotoController Instance
	{
		get
		{
			return ProjectionPhotoController._Instance;
		}
	}

	// Token: 0x06003326 RID: 13094 RVA: 0x001260C7 File Offset: 0x001242C7
	public static ProjectionPhotoController GetOrCreateInstance()
	{
		if (ProjectionPhotoController._Instance == null)
		{
			ProjectionPhotoController.CreateInstance();
		}
		return ProjectionPhotoController._Instance;
	}

	// Token: 0x06003327 RID: 13095 RVA: 0x001260DB File Offset: 0x001242DB
	public static bool CreateInstance()
	{
		if (ProjectionPhotoController._Instance != null)
		{
			return true;
		}
		ProjectionPhotoController._Instance = new ProjectionPhotoController();
		return true;
	}

	// Token: 0x06003328 RID: 13096 RVA: 0x001260F1 File Offset: 0x001242F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003329 RID: 13097 RVA: 0x001260F3 File Offset: 0x001242F3
	public static void ResetStaticDefaultValue()
	{
		ProjectionPhotoController._Instance = null;
	}

	// Token: 0x0600332A RID: 13098 RVA: 0x001260FB File Offset: 0x001242FB
	static ProjectionPhotoController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ProjectionPhotoController.CreateStaticDefaultValue), new Action(ProjectionPhotoController.ResetStaticDefaultValue));
	}

	// Token: 0x04002BE4 RID: 11236
	[Nullable(2)]
	private static ProjectionPhotoController _Instance;
}
