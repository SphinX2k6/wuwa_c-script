using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

// Token: 0x02000F90 RID: 3984
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FadeBackgroundController : ControllerBase
{
	// Token: 0x06009FBB RID: 40891 RVA: 0x002F3048 File Offset: 0x002F1248
	public void OpenFadeBackground(IFadeBackgroundType fadeBackground)
	{
		if (fadeBackground.Type != EFadeBackgroundType.UiPrefab)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[黑幕]不支持的FadeBackground类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", fadeBackground.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		IFadeBackgroundUiPrefab fadeBackgroundUiPrefab = (IFadeBackgroundUiPrefab)fadeBackground;
		if (fadeBackgroundUiPrefab.PrefabType.Type != EFadeBackgroundUiPrefabType.BlackScreenWhiteText)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.BlackScreen;
			ELogAuthor author2 = ELogAuthor.JYS;
			string message2 = "[黑幕]不支持的FadeBackground预制体类型";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("type", fadeBackgroundUiPrefab.PrefabType.Type);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.BlackScreenTextView))
		{
			UiManager.Instance.CloseView(EUiViewName.BlackScreenTextView, null);
		}
		UiManager.Instance.OpenView(EUiViewName.BlackScreenTextView, fadeBackgroundUiPrefab.PrefabType, null);
	}

	// Token: 0x06009FBC RID: 40892 RVA: 0x002F3118 File Offset: 0x002F1318
	public void CloseFadeBackground()
	{
		UiManager.Instance.CloseView(EUiViewName.BlackScreenTextView, null);
	}

	// Token: 0x06009FBD RID: 40893 RVA: 0x002F312A File Offset: 0x002F132A
	protected override bool OnClear()
	{
		this.CloseFadeBackground();
		return true;
	}

	// Token: 0x170010F7 RID: 4343
	// (get) Token: 0x06009FBE RID: 40894 RVA: 0x002F3133 File Offset: 0x002F1333
	public static FadeBackgroundController Instance
	{
		get
		{
			return FadeBackgroundController._Instance;
		}
	}

	// Token: 0x06009FBF RID: 40895 RVA: 0x002F313A File Offset: 0x002F133A
	public static FadeBackgroundController GetOrCreateInstance()
	{
		if (FadeBackgroundController._Instance == null)
		{
			FadeBackgroundController.CreateInstance();
		}
		return FadeBackgroundController._Instance;
	}

	// Token: 0x06009FC0 RID: 40896 RVA: 0x002F314E File Offset: 0x002F134E
	public static bool CreateInstance()
	{
		if (FadeBackgroundController._Instance != null)
		{
			return true;
		}
		FadeBackgroundController._Instance = new FadeBackgroundController();
		return true;
	}

	// Token: 0x06009FC1 RID: 40897 RVA: 0x002F3164 File Offset: 0x002F1364
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009FC2 RID: 40898 RVA: 0x002F3166 File Offset: 0x002F1366
	public static void ResetStaticDefaultValue()
	{
		FadeBackgroundController._Instance = null;
	}

	// Token: 0x06009FC3 RID: 40899 RVA: 0x002F316E File Offset: 0x002F136E
	static FadeBackgroundController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FadeBackgroundController.CreateStaticDefaultValue), new Action(FadeBackgroundController.ResetStaticDefaultValue));
	}

	// Token: 0x04005E7B RID: 24187
	[Nullable(2)]
	private static FadeBackgroundController _Instance;
}
