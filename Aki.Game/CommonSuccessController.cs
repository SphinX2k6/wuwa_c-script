using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020019AC RID: 6572
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CommonSuccessController : UiControllerBase
{
	// Token: 0x0600BFA9 RID: 49065 RVA: 0x002B42E4 File Offset: 0x002B24E4
	[NullableContext(2)]
	public static void OpenCommonSuccessView(CommonSuccessData data = null, Action finishCallback = null)
	{
		CommonSuccessData param = data ?? new CommonSuccessData();
		UiManager.Instance.OpenView(EUiViewName.CommonSuccessView, param, delegate(bool success, int viewId)
		{
			Action finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2();
		});
	}

	// Token: 0x17001012 RID: 4114
	// (get) Token: 0x0600BFAA RID: 49066 RVA: 0x002B4325 File Offset: 0x002B2525
	public static CommonSuccessController Instance
	{
		get
		{
			return CommonSuccessController._Instance;
		}
	}

	// Token: 0x0600BFAB RID: 49067 RVA: 0x002B432C File Offset: 0x002B252C
	public static CommonSuccessController GetOrCreateInstance()
	{
		if (CommonSuccessController._Instance == null)
		{
			CommonSuccessController.CreateInstance();
		}
		return CommonSuccessController._Instance;
	}

	// Token: 0x0600BFAC RID: 49068 RVA: 0x002B4340 File Offset: 0x002B2540
	public static bool CreateInstance()
	{
		if (CommonSuccessController._Instance != null)
		{
			return true;
		}
		CommonSuccessController._Instance = new CommonSuccessController();
		return true;
	}

	// Token: 0x0600BFAD RID: 49069 RVA: 0x002B4356 File Offset: 0x002B2556
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BFAE RID: 49070 RVA: 0x002B4358 File Offset: 0x002B2558
	public static void ResetStaticDefaultValue()
	{
		CommonSuccessController._Instance = null;
	}

	// Token: 0x0600BFAF RID: 49071 RVA: 0x002B4360 File Offset: 0x002B2560
	static CommonSuccessController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CommonSuccessController.CreateStaticDefaultValue), new Action(CommonSuccessController.ResetStaticDefaultValue));
	}

	// Token: 0x04005635 RID: 22069
	[Nullable(2)]
	private static CommonSuccessController _Instance;
}
