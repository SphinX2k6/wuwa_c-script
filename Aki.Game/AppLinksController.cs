using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;

// Token: 0x020016EB RID: 5867
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AppLinksController : ControllerBase
{
	// Token: 0x0600A843 RID: 43075 RVA: 0x0025D537 File Offset: 0x0025B737
	protected override bool OnInit()
	{
		this.RegisterDeepValueHandle();
		return base.OnInit();
	}

	// Token: 0x0600A844 RID: 43076 RVA: 0x0025D545 File Offset: 0x0025B745
	protected override bool OnClear()
	{
		this.UnregisterDeepValueHandle();
		return base.OnClear();
	}

	// Token: 0x0600A845 RID: 43077 RVA: 0x0025D554 File Offset: 0x0025B754
	private void RegisterDeepValueHandle()
	{
		AppLinks instance = AppLinks.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(10009);
		instance.SetDeepValueHandle(defaultInterpolatedStringHandler.ToStringAndClear(), new Action<string, string>(this.OpenGachaView));
		AppLinks instance2 = AppLinks.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(10053);
		instance2.SetDeepValueHandle(defaultInterpolatedStringHandler.ToStringAndClear(), new Action<string, string>(this.OpenActivityView));
	}

	// Token: 0x0600A846 RID: 43078 RVA: 0x0025D5C8 File Offset: 0x0025B7C8
	private void UnregisterDeepValueHandle()
	{
		AppLinks instance = AppLinks.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(10009);
		instance.RemoveDeepValueHandle(defaultInterpolatedStringHandler.ToStringAndClear());
		AppLinks instance2 = AppLinks.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(10053);
		instance2.RemoveDeepValueHandle(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x0600A847 RID: 43079 RVA: 0x0025D621 File Offset: 0x0025B821
	private bool CanOpenView()
	{
		return GameModeModel.Instance.WorldDone && !GameModeModel.Instance.Loading && UiManager.Instance.IsViewShow(EUiViewName.BattleView);
	}

	// Token: 0x0600A848 RID: 43080 RVA: 0x0025D64F File Offset: 0x0025B84F
	private void OpenGachaView(string deepValue, string source)
	{
		if (!this.CanOpenView())
		{
			return;
		}
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Gacha);
	}

	// Token: 0x0600A849 RID: 43081 RVA: 0x0025D669 File Offset: 0x0025B869
	private void OpenActivityView(string deepValue, string source)
	{
		if (!this.CanOpenView())
		{
			return;
		}
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Activity);
	}

	// Token: 0x17000DF1 RID: 3569
	// (get) Token: 0x0600A84A RID: 43082 RVA: 0x0025D683 File Offset: 0x0025B883
	public static AppLinksController Instance
	{
		get
		{
			return AppLinksController._Instance;
		}
	}

	// Token: 0x0600A84B RID: 43083 RVA: 0x0025D68A File Offset: 0x0025B88A
	public static AppLinksController GetOrCreateInstance()
	{
		if (AppLinksController._Instance == null)
		{
			AppLinksController.CreateInstance();
		}
		return AppLinksController._Instance;
	}

	// Token: 0x0600A84C RID: 43084 RVA: 0x0025D69E File Offset: 0x0025B89E
	public static bool CreateInstance()
	{
		if (AppLinksController._Instance != null)
		{
			return true;
		}
		AppLinksController._Instance = new AppLinksController();
		return true;
	}

	// Token: 0x0600A84D RID: 43085 RVA: 0x0025D6B4 File Offset: 0x0025B8B4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A84E RID: 43086 RVA: 0x0025D6B6 File Offset: 0x0025B8B6
	public static void ResetStaticDefaultValue()
	{
		AppLinksController._Instance = null;
	}

	// Token: 0x0600A84F RID: 43087 RVA: 0x0025D6BE File Offset: 0x0025B8BE
	static AppLinksController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AppLinksController.CreateStaticDefaultValue), new Action(AppLinksController.ResetStaticDefaultValue));
	}

	// Token: 0x04004BC9 RID: 19401
	[Nullable(2)]
	private static AppLinksController _Instance;
}
