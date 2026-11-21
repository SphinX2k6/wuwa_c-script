using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02000E98 RID: 3736
[NullableContext(1)]
[Nullable(0)]
public class ConfirmBoxDataNew : UiPopViewData, IViewOpenParamMultipleView
{
	// Token: 0x17001051 RID: 4177
	// (get) Token: 0x06009534 RID: 38196 RVA: 0x002C468F File Offset: 0x002C288F
	// (set) Token: 0x06009535 RID: 38197 RVA: 0x002C4697 File Offset: 0x002C2897
	public bool IsMultipleView { get; set; }

	// Token: 0x06009536 RID: 38198 RVA: 0x002C46A0 File Offset: 0x002C28A0
	public ConfirmBoxDataNew(EConfirmBoxConfigId configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x06009537 RID: 38199 RVA: 0x002C4724 File Offset: 0x002C2924
	public void SetTitle(string title)
	{
		this.Title = title;
	}

	// Token: 0x06009538 RID: 38200 RVA: 0x002C472D File Offset: 0x002C292D
	public string GetTitle()
	{
		return this.Title;
	}

	// Token: 0x06009539 RID: 38201 RVA: 0x002C4735 File Offset: 0x002C2935
	public void SetBtnText(int index, string text)
	{
		this.BtnTextMap[index] = text;
	}

	// Token: 0x0600953A RID: 38202 RVA: 0x002C4744 File Offset: 0x002C2944
	public string GetBtnText(int index)
	{
		if (this.BtnTextMap.ContainsKey(index))
		{
			return this.BtnTextMap[index];
		}
		return "";
	}

	// Token: 0x0600953B RID: 38203 RVA: 0x002C4766 File Offset: 0x002C2966
	public void SetTableTextArgNew(string id, params object[] args)
	{
		this.TableTxtArgNew = new TableTextArgNew(id, args);
	}

	// Token: 0x0600953C RID: 38204 RVA: 0x002C4775 File Offset: 0x002C2975
	public void SetTextArgs(params string[] args)
	{
		this.TextArgs = args;
	}

	// Token: 0x0600953D RID: 38205 RVA: 0x002C477E File Offset: 0x002C297E
	public void SetCloseFunction(Action closeFunction)
	{
		this.CloseFunction = closeFunction;
	}

	// Token: 0x0600953E RID: 38206 RVA: 0x002C4787 File Offset: 0x002C2987
	[NullableContext(2)]
	public Action GetCloseFunction()
	{
		return this.CloseFunction;
	}

	// Token: 0x0600953F RID: 38207 RVA: 0x002C478F File Offset: 0x002C298F
	public void SetToggleFunction(Action<bool> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06009540 RID: 38208 RVA: 0x002C4798 File Offset: 0x002C2998
	[NullableContext(2)]
	public Action<bool> GetToggleFunction()
	{
		return this.ToggleFunction;
	}

	// Token: 0x06009541 RID: 38209 RVA: 0x002C47A0 File Offset: 0x002C29A0
	public void SetAfterShowFunction(Action afterShowFunction)
	{
		this.AfterShowFunction = afterShowFunction;
	}

	// Token: 0x06009542 RID: 38210 RVA: 0x002C47A9 File Offset: 0x002C29A9
	[NullableContext(2)]
	public Action GetAfterShowFunction()
	{
		return this.AfterShowFunction;
	}

	// Token: 0x06009543 RID: 38211 RVA: 0x002C47B4 File Offset: 0x002C29B4
	[NullableContext(2)]
	public string GetContentText()
	{
		ConfirmBox? confirmBoxConfig = ConfirmBoxConfig.Instance.GetConfirmBoxConfig((int)this.ConfigId);
		if (confirmBoxConfig == null)
		{
			return null;
		}
		string text = ConfirmBoxConfig.Instance.GetContent(confirmBoxConfig.Value.Content);
		if (this.TextArgs != null)
		{
			text = StringUtils.Format(text, this.TextArgs);
		}
		return text;
	}

	// Token: 0x040059C8 RID: 22984
	public EConfirmBoxConfigId ConfigId = EConfirmBoxConfigId.Default;

	// Token: 0x040059C9 RID: 22985
	[Nullable(2)]
	public string CustomResourceId;

	// Token: 0x040059CA RID: 22986
	public EUiBehaviourPopType? CustomPopType;

	// Token: 0x040059CB RID: 22987
	public Dictionary<int, int> ItemIdMap = new Dictionary<int, int>();

	// Token: 0x040059CC RID: 22988
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Dictionary<int, Action> FunctionMap = new Dictionary<int, Action>();

	// Token: 0x040059CD RID: 22989
	public Dictionary<int, bool> InteractionMap = new Dictionary<int, bool>();

	// Token: 0x040059CE RID: 22990
	public ELayerType CanvasLayer = ELayerType.Pop;

	// Token: 0x040059CF RID: 22991
	[Nullable(2)]
	public Func<int, bool> CanExecuteCloseFunc;

	// Token: 0x040059D0 RID: 22992
	protected string Title = "";

	// Token: 0x040059D1 RID: 22993
	protected Dictionary<int, string> BtnTextMap = new Dictionary<int, string>();

	// Token: 0x040059D2 RID: 22994
	public bool HasToggle;

	// Token: 0x040059D3 RID: 22995
	public string ToggleText = "";

	// Token: 0x040059D4 RID: 22996
	public string ToggleTextKey = "";

	// Token: 0x040059D5 RID: 22997
	[Nullable(2)]
	public string Tip;

	// Token: 0x040059D6 RID: 22998
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] TextArgs;

	// Token: 0x040059D7 RID: 22999
	[Nullable(2)]
	public TableTextArgNew TableTxtArgNew;

	// Token: 0x040059D8 RID: 23000
	public int? ErrorCode;

	// Token: 0x040059D9 RID: 23001
	public bool SetTipsBgRed;

	// Token: 0x040059DA RID: 23002
	public bool CanClickDuringTimer = true;

	// Token: 0x040059DB RID: 23003
	public bool IsEscViewTriggerCallBack = true;

	// Token: 0x040059DC RID: 23004
	public bool ShowPowerItem;

	// Token: 0x040059DD RID: 23005
	[Nullable(2)]
	public UiViewBase AttachView;

	// Token: 0x040059DE RID: 23006
	[Nullable(2)]
	private Action CloseFunction;

	// Token: 0x040059DF RID: 23007
	[Nullable(2)]
	private Action AfterShowFunction;

	// Token: 0x040059E0 RID: 23008
	[Nullable(2)]
	private Action<bool> ToggleFunction;

	// Token: 0x040059E1 RID: 23009
	[Nullable(2)]
	public TOpenViewCallBack FinishOpenFunction;

	// Token: 0x040059E2 RID: 23010
	[Nullable(2)]
	public Action DestroyFunction;

	// Token: 0x040059E3 RID: 23011
	[Nullable(2)]
	public Action BeforePlayCloseFunction;
}
