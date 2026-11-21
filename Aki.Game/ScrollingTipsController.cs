using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

// Token: 0x02001EDB RID: 7899
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ScrollingTipsController : UiControllerBase
{
	// Token: 0x06013869 RID: 79977 RVA: 0x005B1618 File Offset: 0x005AF818
	public void ShowTipsById(string id, params object[] parameters)
	{
		TableTextArgNew mainTextObj = new TableTextArgNew(TextConfig.Instance.GetTextContentIdById(id), Array.Empty<object>());
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, mainTextObj, null, parameters, null, null, null, null, null, false, null);
	}

	// Token: 0x0601386A RID: 79978 RVA: 0x005B1664 File Offset: 0x005AF864
	public void ShowTipsByText(string text)
	{
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
		{
			text
		}, null, null, null, null, null, false, null);
	}

	// Token: 0x0601386B RID: 79979 RVA: 0x005B16A0 File Offset: 0x005AF8A0
	public void ShowTipsByTextId(string textId, params object[] parameters)
	{
		TableTextArgNew mainTextObj = new TableTextArgNew(textId, Array.Empty<object>());
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, mainTextObj, null, parameters, null, null, null, null, null, false, null);
	}

	// Token: 0x17001DDC RID: 7644
	// (get) Token: 0x0601386C RID: 79980 RVA: 0x005B16DF File Offset: 0x005AF8DF
	public static ScrollingTipsController Instance
	{
		get
		{
			return ScrollingTipsController._Instance;
		}
	}

	// Token: 0x0601386D RID: 79981 RVA: 0x005B16E6 File Offset: 0x005AF8E6
	public static ScrollingTipsController GetOrCreateInstance()
	{
		if (ScrollingTipsController._Instance == null)
		{
			ScrollingTipsController.CreateInstance();
		}
		return ScrollingTipsController._Instance;
	}

	// Token: 0x0601386E RID: 79982 RVA: 0x005B16FA File Offset: 0x005AF8FA
	public static bool CreateInstance()
	{
		if (ScrollingTipsController._Instance != null)
		{
			return true;
		}
		ScrollingTipsController._Instance = new ScrollingTipsController();
		return true;
	}

	// Token: 0x0601386F RID: 79983 RVA: 0x005B1710 File Offset: 0x005AF910
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013870 RID: 79984 RVA: 0x005B1712 File Offset: 0x005AF912
	public static void ResetStaticDefaultValue()
	{
		ScrollingTipsController._Instance = null;
	}

	// Token: 0x06013871 RID: 79985 RVA: 0x005B171A File Offset: 0x005AF91A
	static ScrollingTipsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScrollingTipsController.CreateStaticDefaultValue), new Action(ScrollingTipsController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A6E4 RID: 42724
	[Nullable(2)]
	private static ScrollingTipsController _Instance;
}
