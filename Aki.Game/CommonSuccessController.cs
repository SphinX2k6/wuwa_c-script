using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000E6A RID: 3690
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CommonSuccessController : UiControllerBase
{
	// Token: 0x060093B3 RID: 37811 RVA: 0x002BF274 File Offset: 0x002BD474
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

	// Token: 0x17001037 RID: 4151
	// (get) Token: 0x060093B4 RID: 37812 RVA: 0x002BF2B5 File Offset: 0x002BD4B5
	public static CommonSuccessController Instance
	{
		get
		{
			return CommonSuccessController._Instance;
		}
	}

	// Token: 0x060093B5 RID: 37813 RVA: 0x002BF2BC File Offset: 0x002BD4BC
	public static CommonSuccessController GetOrCreateInstance()
	{
		if (CommonSuccessController._Instance == null)
		{
			CommonSuccessController.CreateInstance();
		}
		return CommonSuccessController._Instance;
	}

	// Token: 0x060093B6 RID: 37814 RVA: 0x002BF2D0 File Offset: 0x002BD4D0
	public static bool CreateInstance()
	{
		if (CommonSuccessController._Instance != null)
		{
			return true;
		}
		CommonSuccessController._Instance = new CommonSuccessController();
		return true;
	}

	// Token: 0x060093B7 RID: 37815 RVA: 0x002BF2E6 File Offset: 0x002BD4E6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060093B8 RID: 37816 RVA: 0x002BF2E8 File Offset: 0x002BD4E8
	public static void ResetStaticDefaultValue()
	{
		CommonSuccessController._Instance = null;
	}

	// Token: 0x060093B9 RID: 37817 RVA: 0x002BF2F0 File Offset: 0x002BD4F0
	static CommonSuccessController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CommonSuccessController.CreateStaticDefaultValue), new Action(CommonSuccessController.ResetStaticDefaultValue));
	}

	// Token: 0x040056E7 RID: 22247
	[Nullable(2)]
	private static CommonSuccessController _Instance;
}
