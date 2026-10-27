using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

// Token: 0x02002960 RID: 10592
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ScrollingTipsController : UiControllerBase
{
	// Token: 0x06015E65 RID: 89701 RVA: 0x00586614 File Offset: 0x00584814
	public void ShowTipsById(string id, params object[] parameters)
	{
		TableTextArgNew mainTextObj = new TableTextArgNew(TextConfig.Instance.GetTextContentIdById(id), Array.Empty<object>());
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, mainTextObj, null, parameters, null, null, null, null, null, false, null);
	}

	// Token: 0x06015E66 RID: 89702 RVA: 0x00586660 File Offset: 0x00584860
	public void ShowTipsByText(string text)
	{
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
		{
			text
		}, null, null, null, null, null, false, null);
	}

	// Token: 0x06015E67 RID: 89703 RVA: 0x0058669C File Offset: 0x0058489C
	public void ShowTipsByTextId(string textId, params object[] parameters)
	{
		TableTextArgNew mainTextObj = new TableTextArgNew(textId, Array.Empty<object>());
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, mainTextObj, null, parameters, null, null, null, null, null, false, null);
	}

	// Token: 0x17001D83 RID: 7555
	// (get) Token: 0x06015E68 RID: 89704 RVA: 0x005866DB File Offset: 0x005848DB
	public static ScrollingTipsController Instance
	{
		get
		{
			return ScrollingTipsController._Instance;
		}
	}

	// Token: 0x06015E69 RID: 89705 RVA: 0x005866E2 File Offset: 0x005848E2
	public static ScrollingTipsController GetOrCreateInstance()
	{
		if (ScrollingTipsController._Instance == null)
		{
			ScrollingTipsController.CreateInstance();
		}
		return ScrollingTipsController._Instance;
	}

	// Token: 0x06015E6A RID: 89706 RVA: 0x005866F6 File Offset: 0x005848F6
	public static bool CreateInstance()
	{
		if (ScrollingTipsController._Instance != null)
		{
			return true;
		}
		ScrollingTipsController._Instance = new ScrollingTipsController();
		return true;
	}

	// Token: 0x06015E6B RID: 89707 RVA: 0x0058670C File Offset: 0x0058490C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015E6C RID: 89708 RVA: 0x0058670E File Offset: 0x0058490E
	public static void ResetStaticDefaultValue()
	{
		ScrollingTipsController._Instance = null;
	}

	// Token: 0x06015E6D RID: 89709 RVA: 0x00586716 File Offset: 0x00584916
	static ScrollingTipsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScrollingTipsController.CreateStaticDefaultValue), new Action(ScrollingTipsController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A2FA RID: 41722
	[Nullable(2)]
	private static ScrollingTipsController _Instance;
}
