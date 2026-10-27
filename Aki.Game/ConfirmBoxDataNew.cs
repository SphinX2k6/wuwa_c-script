using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x020019D9 RID: 6617
[NullableContext(1)]
[Nullable(0)]
public class ConfirmBoxDataNew : UiPopViewData, IViewOpenParamMultipleView
{
	// Token: 0x1700102C RID: 4140
	// (get) Token: 0x0600C127 RID: 49447 RVA: 0x002B96B7 File Offset: 0x002B78B7
	// (set) Token: 0x0600C128 RID: 49448 RVA: 0x002B96BF File Offset: 0x002B78BF
	public bool IsMultipleView { get; set; }

	// Token: 0x0600C129 RID: 49449 RVA: 0x002B96C8 File Offset: 0x002B78C8
	public ConfirmBoxDataNew(EConfirmBoxConfigId configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600C12A RID: 49450 RVA: 0x002B974C File Offset: 0x002B794C
	public void SetTitle(string title)
	{
		this.Title = title;
	}

	// Token: 0x0600C12B RID: 49451 RVA: 0x002B9755 File Offset: 0x002B7955
	public string GetTitle()
	{
		return this.Title;
	}

	// Token: 0x0600C12C RID: 49452 RVA: 0x002B975D File Offset: 0x002B795D
	public void SetBtnText(int index, string text)
	{
		this.BtnTextMap[index] = text;
	}

	// Token: 0x0600C12D RID: 49453 RVA: 0x002B976C File Offset: 0x002B796C
	public string GetBtnText(int index)
	{
		if (this.BtnTextMap.ContainsKey(index))
		{
			return this.BtnTextMap[index];
		}
		return "";
	}

	// Token: 0x0600C12E RID: 49454 RVA: 0x002B978E File Offset: 0x002B798E
	public void SetTableTextArgNew(string id, params object[] args)
	{
		this.TableTxtArgNew = new TableTextArgNew(id, args);
	}

	// Token: 0x0600C12F RID: 49455 RVA: 0x002B979D File Offset: 0x002B799D
	public void SetTextArgs(params string[] args)
	{
		this.TextArgs = args;
	}

	// Token: 0x0600C130 RID: 49456 RVA: 0x002B97A6 File Offset: 0x002B79A6
	public void SetCloseFunction(Action closeFunction)
	{
		this.CloseFunction = closeFunction;
	}

	// Token: 0x0600C131 RID: 49457 RVA: 0x002B97AF File Offset: 0x002B79AF
	[NullableContext(2)]
	public Action GetCloseFunction()
	{
		return this.CloseFunction;
	}

	// Token: 0x0600C132 RID: 49458 RVA: 0x002B97B7 File Offset: 0x002B79B7
	public void SetToggleFunction(Action<bool> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600C133 RID: 49459 RVA: 0x002B97C0 File Offset: 0x002B79C0
	[NullableContext(2)]
	public Action<bool> GetToggleFunction()
	{
		return this.ToggleFunction;
	}

	// Token: 0x0600C134 RID: 49460 RVA: 0x002B97C8 File Offset: 0x002B79C8
	public void SetAfterShowFunction(Action afterShowFunction)
	{
		this.AfterShowFunction = afterShowFunction;
	}

	// Token: 0x0600C135 RID: 49461 RVA: 0x002B97D1 File Offset: 0x002B79D1
	[NullableContext(2)]
	public Action GetAfterShowFunction()
	{
		return this.AfterShowFunction;
	}

	// Token: 0x0600C136 RID: 49462 RVA: 0x002B97DC File Offset: 0x002B79DC
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

	// Token: 0x040058F9 RID: 22777
	public EConfirmBoxConfigId ConfigId = EConfirmBoxConfigId.Default;

	// Token: 0x040058FA RID: 22778
	[Nullable(2)]
	public string CustomResourceId;

	// Token: 0x040058FB RID: 22779
	public EUiBehaviourPopType? CustomPopType;

	// Token: 0x040058FC RID: 22780
	public Dictionary<int, int> ItemIdMap = new Dictionary<int, int>();

	// Token: 0x040058FD RID: 22781
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Dictionary<int, Action> FunctionMap = new Dictionary<int, Action>();

	// Token: 0x040058FE RID: 22782
	public Dictionary<int, bool> InteractionMap = new Dictionary<int, bool>();

	// Token: 0x040058FF RID: 22783
	public ELayerType CanvasLayer = ELayerType.Pop;

	// Token: 0x04005900 RID: 22784
	[Nullable(2)]
	public Func<int, bool> CanExecuteCloseFunc;

	// Token: 0x04005901 RID: 22785
	protected string Title = "";

	// Token: 0x04005902 RID: 22786
	protected Dictionary<int, string> BtnTextMap = new Dictionary<int, string>();

	// Token: 0x04005903 RID: 22787
	public bool HasToggle;

	// Token: 0x04005904 RID: 22788
	public string ToggleText = "";

	// Token: 0x04005905 RID: 22789
	public string ToggleTextKey = "";

	// Token: 0x04005906 RID: 22790
	[Nullable(2)]
	public string Tip;

	// Token: 0x04005907 RID: 22791
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] TextArgs;

	// Token: 0x04005908 RID: 22792
	[Nullable(2)]
	public TableTextArgNew TableTxtArgNew;

	// Token: 0x04005909 RID: 22793
	public int? ErrorCode;

	// Token: 0x0400590A RID: 22794
	public bool SetTipsBgRed;

	// Token: 0x0400590B RID: 22795
	public bool CanClickDuringTimer = true;

	// Token: 0x0400590C RID: 22796
	public bool IsEscViewTriggerCallBack = true;

	// Token: 0x0400590D RID: 22797
	public bool ShowPowerItem;

	// Token: 0x0400590E RID: 22798
	[Nullable(2)]
	public UiViewBase AttachView;

	// Token: 0x0400590F RID: 22799
	[Nullable(2)]
	private Action CloseFunction;

	// Token: 0x04005910 RID: 22800
	[Nullable(2)]
	private Action AfterShowFunction;

	// Token: 0x04005911 RID: 22801
	[Nullable(2)]
	private Action<bool> ToggleFunction;

	// Token: 0x04005912 RID: 22802
	[Nullable(2)]
	public TOpenViewCallBack FinishOpenFunction;

	// Token: 0x04005913 RID: 22803
	[Nullable(2)]
	public Action DestroyFunction;

	// Token: 0x04005914 RID: 22804
	[Nullable(2)]
	public Action BeforePlayCloseFunction;
}
