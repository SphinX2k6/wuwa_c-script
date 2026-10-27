using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

// Token: 0x02001AD1 RID: 6865
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FadeBackgroundController : ControllerBase
{
	// Token: 0x0600CBAA RID: 52138 RVA: 0x002E7EF4 File Offset: 0x002E60F4
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

	// Token: 0x0600CBAB RID: 52139 RVA: 0x002E7FC4 File Offset: 0x002E61C4
	public void CloseFadeBackground()
	{
		UiManager.Instance.CloseView(EUiViewName.BlackScreenTextView, null);
	}

	// Token: 0x0600CBAC RID: 52140 RVA: 0x002E7FD6 File Offset: 0x002E61D6
	protected override bool OnClear()
	{
		this.CloseFadeBackground();
		return true;
	}

	// Token: 0x170010D2 RID: 4306
	// (get) Token: 0x0600CBAD RID: 52141 RVA: 0x002E7FDF File Offset: 0x002E61DF
	public static FadeBackgroundController Instance
	{
		get
		{
			return FadeBackgroundController._Instance;
		}
	}

	// Token: 0x0600CBAE RID: 52142 RVA: 0x002E7FE6 File Offset: 0x002E61E6
	public static FadeBackgroundController GetOrCreateInstance()
	{
		if (FadeBackgroundController._Instance == null)
		{
			FadeBackgroundController.CreateInstance();
		}
		return FadeBackgroundController._Instance;
	}

	// Token: 0x0600CBAF RID: 52143 RVA: 0x002E7FFA File Offset: 0x002E61FA
	public static bool CreateInstance()
	{
		if (FadeBackgroundController._Instance != null)
		{
			return true;
		}
		FadeBackgroundController._Instance = new FadeBackgroundController();
		return true;
	}

	// Token: 0x0600CBB0 RID: 52144 RVA: 0x002E8010 File Offset: 0x002E6210
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CBB1 RID: 52145 RVA: 0x002E8012 File Offset: 0x002E6212
	public static void ResetStaticDefaultValue()
	{
		FadeBackgroundController._Instance = null;
	}

	// Token: 0x0600CBB2 RID: 52146 RVA: 0x002E801A File Offset: 0x002E621A
	static FadeBackgroundController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FadeBackgroundController.CreateStaticDefaultValue), new Action(FadeBackgroundController.ResetStaticDefaultValue));
	}

	// Token: 0x04005DAC RID: 23980
	[Nullable(2)]
	private static FadeBackgroundController _Instance;
}
