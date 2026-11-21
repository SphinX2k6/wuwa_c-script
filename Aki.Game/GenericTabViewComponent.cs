using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000E80 RID: 3712
[NullableContext(1)]
[Nullable(0)]
public abstract class GenericTabViewComponent
{
	// Token: 0x0600949F RID: 38047 RVA: 0x002C134B File Offset: 0x002BF54B
	protected GenericTabViewComponent(UUIItem rootViewItem, EKeyMode keyMode = EKeyMode.Default)
	{
		this.RootViewItem = rootViewItem;
		this.KeyMode = keyMode;
		EventSystem.Instance.Add<GuideStepInfo, GuideFocusNew>(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
	}

	// Token: 0x060094A0 RID: 38048 RVA: 0x002C1388 File Offset: 0x002BF588
	private void RegisterViewModule(CommonTabItemBase tabItem, UiTabViewBase tabView)
	{
		ITabViewRegister tabViewRegister = tabItem as ITabViewRegister;
		if (tabViewRegister == null)
		{
			return;
		}
		tabViewRegister.RegisterViewModule(tabView);
	}

	// Token: 0x060094A1 RID: 38049 RVA: 0x002C139C File Offset: 0x002BF59C
	private void ClearUiTabView()
	{
		foreach (UiTabViewBase uiTabViewBase in this.UiTabViewMap.Values)
		{
			uiTabViewBase.Destroy(null);
		}
		this.UiTabViewMap.Clear();
	}

	// Token: 0x060094A2 RID: 38050 RVA: 0x002C1400 File Offset: 0x002BF600
	private void HideTabView(EUiTabViewName? selectKey)
	{
		if (selectKey == null)
		{
			return;
		}
		UiTabViewBase uiTabViewBase;
		this.UiTabViewMap.TryGetValue(selectKey.Value, out uiTabViewBase);
		if (uiTabViewBase == null)
		{
			return;
		}
		if (uiTabViewBase.IsCreateOrCreating || uiTabViewBase.IsStarting)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiTabModule;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "异步加载中,不执行页签隐藏";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TabViewName", this.SelectedKey);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		uiTabViewBase.HideUiTabView(true);
	}

	// Token: 0x060094A3 RID: 38051 RVA: 0x002C147C File Offset: 0x002BF67C
	public void HideCurrentTabView()
	{
		if (this.SelectedKey == null)
		{
			return;
		}
		UiTabViewBase uiTabViewBase;
		this.UiTabViewMap.TryGetValue(this.SelectedKey.Value, out uiTabViewBase);
		if (uiTabViewBase == null)
		{
			return;
		}
		if (uiTabViewBase.IsCreateOrCreating || uiTabViewBase.IsStarting)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiTabModule;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "异步加载中,不执行页签隐藏";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TabViewName", this.SelectedKey);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		uiTabViewBase.HideUiTabView(true);
		this.SelectedKey = null;
	}

	// Token: 0x060094A4 RID: 38052 RVA: 0x002C150C File Offset: 0x002BF70C
	[NullableContext(2)]
	public void ToggleCallBackNew([Nullable(1)] object data, EUiTabViewName viewName, CommonTabItemBase tabItem = null, object extraParams = null, int? index = null)
	{
		EUiTabViewName tabKey = this.GetTabKey(viewName, index);
		this.SelectedKey = new EUiTabViewName?(tabKey);
		UiTabViewBase uiTabView;
		this.UiTabViewMap.TryGetValue(tabKey, out uiTabView);
		if (uiTabView == null)
		{
			IUiTabViewTsInfo uiTabViewBase = UiTabViewStorage.Instance.GetUiTabViewBase(viewName);
			if (uiTabViewBase == null)
			{
				return;
			}
			uiTabView = uiTabViewBase.CreateUiTabView();
			uiTabView.SetTabViewName(viewName);
			uiTabView.SetParams(data);
			uiTabView.SetExtraParams(extraParams);
			if (tabItem != null)
			{
				this.RegisterViewModule(tabItem, uiTabView);
			}
			this.UiTabViewMap[tabKey] = uiTabView;
			uiTabView.CreateByResourceIdAsync(uiTabViewBase.ResourceId, this.RootViewItem, false).ContinueWith(delegate()
			{
				if (this.SelectedKey == tabKey)
				{
					if (this.HideTabViewKey != null)
					{
						this.HideTabView(this.HideTabViewKey);
					}
					this.HideTabViewKey = new EUiTabViewName?(tabKey);
					UiTabViewBase uiTabView = uiTabView;
					if (uiTabView == null)
					{
						return;
					}
					uiTabView.ShowUiTabViewFromToggle();
					return;
				}
				else
				{
					UiTabViewBase uiTabView;
					UiTabViewBase uiTabView2 = uiTabView;
					if (uiTabView2 == null)
					{
						return;
					}
					uiTabView2.HideUiTabView(true);
					return;
				}
			}).Forget();
		}
		else
		{
			uiTabView.SetParams(data);
			uiTabView.SetExtraParams(extraParams);
		}
		if (uiTabView.IsCreateOrCreating || uiTabView.IsStarting)
		{
			return;
		}
		if (this.HideTabViewKey != null)
		{
			this.HideTabView(this.HideTabViewKey);
		}
		this.HideTabViewKey = new EUiTabViewName?(tabKey);
		uiTabView.ShowUiTabViewFromToggle();
	}

	// Token: 0x060094A5 RID: 38053 RVA: 0x002C1670 File Offset: 0x002BF870
	[NullableContext(2)]
	public void ToggleCallBack([Nullable(1)] object data, EUiTabViewName viewName, CommonTabItemBase tabItem = null, object extraParams = null, int? index = null)
	{
		EUiTabViewName tabKey = this.GetTabKey(viewName, index);
		if (this.SelectedKey != null)
		{
			this.HideCurrentTabView();
		}
		this.SelectedKey = new EUiTabViewName?(tabKey);
		UiTabViewBase uiTabView;
		this.UiTabViewMap.TryGetValue(tabKey, out uiTabView);
		if (uiTabView == null)
		{
			IUiTabViewTsInfo uiTabViewBase = UiTabViewStorage.Instance.GetUiTabViewBase(viewName);
			if (uiTabViewBase == null)
			{
				return;
			}
			uiTabView = uiTabViewBase.CreateUiTabView();
			uiTabView.SetTabViewName(viewName);
			uiTabView.SetParams(data);
			uiTabView.SetExtraParams(extraParams);
			if (tabItem != null)
			{
				this.RegisterViewModule(tabItem, uiTabView);
			}
			this.UiTabViewMap[tabKey] = uiTabView;
			uiTabView.CreateByResourceIdAsync(uiTabViewBase.ResourceId, this.RootViewItem, false).ContinueWith(delegate()
			{
				if (this.SelectedKey == tabKey)
				{
					UiTabViewBase uiTabView = uiTabView;
					if (uiTabView == null)
					{
						return;
					}
					uiTabView.ShowUiTabViewFromToggle();
					return;
				}
				else
				{
					UiTabViewBase uiTabView;
					UiTabViewBase uiTabView2 = uiTabView;
					if (uiTabView2 == null)
					{
						return;
					}
					uiTabView2.HideUiTabView(true);
					return;
				}
			}).Forget();
		}
		else
		{
			uiTabView.SetParams(data);
			uiTabView.SetExtraParams(extraParams);
		}
		if (uiTabView.IsCreateOrCreating || uiTabView.IsStarting)
		{
			return;
		}
		uiTabView.ShowUiTabViewFromToggle();
	}

	// Token: 0x060094A6 RID: 38054 RVA: 0x002C17BC File Offset: 0x002BF9BC
	private EUiTabViewName GetTabKey(EUiTabViewName viewName, int? index = null)
	{
		if (this.KeyMode == EKeyMode.Index && index == null)
		{
			Log.Instance.Error(ELogModule.UiTabModule, ELogAuthor.YZY, "索引模式下必须传入索引", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new EUiTabViewName("");
		}
		if (this.KeyMode == EKeyMode.Default)
		{
			return viewName;
		}
		return new EUiTabViewName(StringUtils.Format("{0}_{1}", new string[]
		{
			viewName.ToString(),
			index.ToString()
		}));
	}

	// Token: 0x060094A7 RID: 38055 RVA: 0x002C1844 File Offset: 0x002BFA44
	public EUiTabViewName? GetCurrentTabViewName(int? index = null)
	{
		if (this.KeyMode == EKeyMode.Index && index == null)
		{
			Log.Instance.Error(ELogModule.UiTabModule, ELogAuthor.YZY, "索引模式下必须传入索引", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (this.KeyMode != EKeyMode.Index)
		{
			return this.SelectedKey;
		}
		string[] array = (this.SelectedKey != null) ? this.SelectedKey.GetValueOrDefault().ToString().Split('_', StringSplitOptions.None) : null;
		if (array == null || array.Length != 2)
		{
			Log.Instance.Error(ELogModule.UiTabModule, ELogAuthor.YZY, "索引模式下Key不符合规范", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (array[1] != ((index != null) ? index.GetValueOrDefault().ToString() : null))
		{
			Log.Instance.Error(ELogModule.UiTabModule, ELogAuthor.YZY, "索引模式下Key索引不一致", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return new EUiTabViewName?((EUiTabViewName)array[0]);
	}

	// Token: 0x060094A8 RID: 38056 RVA: 0x002C195C File Offset: 0x002BFB5C
	[NullableContext(2)]
	public UiTabViewBase GetCurrentTabView()
	{
		if (this.SelectedKey == null)
		{
			return null;
		}
		UiTabViewBase result;
		this.UiTabViewMap.TryGetValue(this.SelectedKey.Value, out result);
		return result;
	}

	// Token: 0x060094A9 RID: 38057 RVA: 0x002C1994 File Offset: 0x002BFB94
	[NullableContext(2)]
	public UiTabViewBase GetTabViewByTabKey(EUiTabViewName viewName, int? index = null)
	{
		UiTabViewBase result;
		this.UiTabViewMap.TryGetValue(this.GetTabKey(viewName, index), out result);
		return result;
	}

	// Token: 0x060094AA RID: 38058 RVA: 0x002C19B8 File Offset: 0x002BFBB8
	public void SetCurrentTabViewState(bool bShow)
	{
		if (this.SelectedKey == null)
		{
			return;
		}
		UiTabViewBase uiTabViewBase;
		this.UiTabViewMap.TryGetValue(this.SelectedKey.Value, out uiTabViewBase);
		if (uiTabViewBase == null)
		{
			return;
		}
		if (bShow && uiTabViewBase.IsHideOrHiding)
		{
			uiTabViewBase.ShowUiTabViewFromView();
			return;
		}
		if (!bShow && !uiTabViewBase.IsHideOrHiding)
		{
			uiTabViewBase.HideUiTabView(false);
		}
	}

	// Token: 0x060094AB RID: 38059 RVA: 0x002C1A14 File Offset: 0x002BFC14
	public void DestroyTabViewComponent()
	{
		this.ClearUiTabView();
		EventSystem.Instance.Remove(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
	}

	// Token: 0x060094AC RID: 38060 RVA: 0x002C1A38 File Offset: 0x002BFC38
	private void OnGuideFocusNeedUiTabView(GuideStepInfo stepInfo, GuideFocusNew focusConf)
	{
		EUiTabViewName? euiTabViewName = this.SelectedKey;
		EUiTabViewName? euiTabViewName2 = (euiTabViewName != null) ? euiTabViewName : this.Default;
		string dynamicTabName = focusConf.DynamicTabName;
		euiTabViewName = euiTabViewName2;
		if (dynamicTabName != ((euiTabViewName != null) ? euiTabViewName.GetValueOrDefault() : null))
		{
			return;
		}
		UiTabViewBase uiTabViewBase;
		this.UiTabViewMap.TryGetValue(euiTabViewName2.Value, out uiTabViewBase);
		if (uiTabViewBase != null)
		{
			GuideStepViewData viewData = stepInfo.ViewData;
			if (viewData == null)
			{
				return;
			}
			viewData.SetAttachedView(uiTabViewBase);
		}
	}

	// Token: 0x0400572B RID: 22315
	private readonly EKeyMode KeyMode;

	// Token: 0x0400572C RID: 22316
	private EUiTabViewName? SelectedKey;

	// Token: 0x0400572D RID: 22317
	private readonly EUiTabViewName? Default;

	// Token: 0x0400572E RID: 22318
	private readonly Dictionary<EUiTabViewName, UiTabViewBase> UiTabViewMap = new Dictionary<EUiTabViewName, UiTabViewBase>();

	// Token: 0x0400572F RID: 22319
	private EUiTabViewName? HideTabViewKey;

	// Token: 0x04005730 RID: 22320
	private readonly UUIItem RootViewItem;
}
