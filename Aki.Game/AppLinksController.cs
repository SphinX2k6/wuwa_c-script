using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;

// Token: 0x02000BA3 RID: 2979
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AppLinksController : ControllerBase
{
	// Token: 0x06007C23 RID: 31779 RVA: 0x00267957 File Offset: 0x00265B57
	protected override bool OnInit()
	{
		this.RegisterDeepValueHandle();
		return base.OnInit();
	}

	// Token: 0x06007C24 RID: 31780 RVA: 0x00267965 File Offset: 0x00265B65
	protected override bool OnClear()
	{
		this.UnregisterDeepValueHandle();
		return base.OnClear();
	}

	// Token: 0x06007C25 RID: 31781 RVA: 0x00267974 File Offset: 0x00265B74
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

	// Token: 0x06007C26 RID: 31782 RVA: 0x002679E8 File Offset: 0x00265BE8
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

	// Token: 0x06007C27 RID: 31783 RVA: 0x00267A41 File Offset: 0x00265C41
	private bool CanOpenView()
	{
		return GameModeModel.Instance.WorldDone && !GameModeModel.Instance.Loading && UiManager.Instance.IsViewShow(EUiViewName.BattleView);
	}

	// Token: 0x06007C28 RID: 31784 RVA: 0x00267A6F File Offset: 0x00265C6F
	private void OpenGachaView(string deepValue, string source)
	{
		if (!this.CanOpenView())
		{
			return;
		}
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Gacha);
	}

	// Token: 0x06007C29 RID: 31785 RVA: 0x00267A89 File Offset: 0x00265C89
	private void OpenActivityView(string deepValue, string source)
	{
		if (!this.CanOpenView())
		{
			return;
		}
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Activity);
	}

	// Token: 0x17000E12 RID: 3602
	// (get) Token: 0x06007C2A RID: 31786 RVA: 0x00267AA3 File Offset: 0x00265CA3
	public static AppLinksController Instance
	{
		get
		{
			return AppLinksController._Instance;
		}
	}

	// Token: 0x06007C2B RID: 31787 RVA: 0x00267AAA File Offset: 0x00265CAA
	public static AppLinksController GetOrCreateInstance()
	{
		if (AppLinksController._Instance == null)
		{
			AppLinksController.CreateInstance();
		}
		return AppLinksController._Instance;
	}

	// Token: 0x06007C2C RID: 31788 RVA: 0x00267ABE File Offset: 0x00265CBE
	public static bool CreateInstance()
	{
		if (AppLinksController._Instance != null)
		{
			return true;
		}
		AppLinksController._Instance = new AppLinksController();
		return true;
	}

	// Token: 0x06007C2D RID: 31789 RVA: 0x00267AD4 File Offset: 0x00265CD4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C2E RID: 31790 RVA: 0x00267AD6 File Offset: 0x00265CD6
	public static void ResetStaticDefaultValue()
	{
		AppLinksController._Instance = null;
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x00267ADE File Offset: 0x00265CDE
	static AppLinksController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AppLinksController.CreateStaticDefaultValue), new Action(AppLinksController.ResetStaticDefaultValue));
	}

	// Token: 0x04004C70 RID: 19568
	[Nullable(2)]
	private static AppLinksController _Instance;
}
