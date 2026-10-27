using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020019C2 RID: 6594
[NullableContext(1)]
[Nullable(0)]
public class TabViewComponent<[Nullable(2)] TData>
{
	// Token: 0x0600C095 RID: 49301 RVA: 0x002B63BB File Offset: 0x002B45BB
	public TabViewComponent(UUIItem rootViewItem, EKeyMode keyMode = EKeyMode.Default)
	{
		this.RootViewItem = rootViewItem;
		this.KeyMode = keyMode;
		EventSystem.Instance.Add<GuideStepInfo, GuideFocusNew>(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
	}

	// Token: 0x0600C096 RID: 49302 RVA: 0x002B63F8 File Offset: 0x002B45F8
	private void RegisterViewModule(CommonTabItemBase tabItem, UiTabViewBase tabView)
	{
		ITabViewRegister tabViewRegister = tabItem as ITabViewRegister;
		if (tabViewRegister == null)
		{
			return;
		}
		tabViewRegister.RegisterViewModule(tabView);
	}

	// Token: 0x0600C097 RID: 49303 RVA: 0x002B640C File Offset: 0x002B460C
	private void ClearUiTabView()
	{
		foreach (UiTabViewBase uiTabViewBase in this.UiTabViewMap.Values)
		{
			uiTabViewBase.Destroy(null);
		}
		this.UiTabViewMap.Clear();
	}

	// Token: 0x0600C098 RID: 49304 RVA: 0x002B6470 File Offset: 0x002B4670
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

	// Token: 0x0600C099 RID: 49305 RVA: 0x002B64EC File Offset: 0x002B46EC
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

	// Token: 0x0600C09A RID: 49306 RVA: 0x002B657C File Offset: 0x002B477C
	[NullableContext(2)]
	public void ToggleCallBackNew([Nullable(1)] TData data, EUiTabViewName viewName, CommonTabItemBase tabItem = null, object extraParams = null, int? index = null)
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

	// Token: 0x0600C09B RID: 49307 RVA: 0x002B66EC File Offset: 0x002B48EC
	[NullableContext(2)]
	public void ToggleCallBack([Nullable(1)] TData data, EUiTabViewName viewName, CommonTabItemBase tabItem = null, object extraParams = null, int? index = null)
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

	// Token: 0x0600C09C RID: 49308 RVA: 0x002B6844 File Offset: 0x002B4A44
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

	// Token: 0x0600C09D RID: 49309 RVA: 0x002B68CC File Offset: 0x002B4ACC
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

	// Token: 0x0600C09E RID: 49310 RVA: 0x002B69E4 File Offset: 0x002B4BE4
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

	// Token: 0x0600C09F RID: 49311 RVA: 0x002B6A1C File Offset: 0x002B4C1C
	[NullableContext(2)]
	public UiTabViewBase GetTabViewByTabKey(EUiTabViewName viewName, int? index = null)
	{
		UiTabViewBase result;
		this.UiTabViewMap.TryGetValue(this.GetTabKey(viewName, index), out result);
		return result;
	}

	// Token: 0x0600C0A0 RID: 49312 RVA: 0x002B6A40 File Offset: 0x002B4C40
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

	// Token: 0x0600C0A1 RID: 49313 RVA: 0x002B6A9C File Offset: 0x002B4C9C
	public void DestroyTabViewComponent()
	{
		this.ClearUiTabView();
		EventSystem.Instance.Remove(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
	}

	// Token: 0x0600C0A2 RID: 49314 RVA: 0x002B6AC0 File Offset: 0x002B4CC0
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

	// Token: 0x04005679 RID: 22137
	private readonly EKeyMode KeyMode;

	// Token: 0x0400567A RID: 22138
	private EUiTabViewName? SelectedKey;

	// Token: 0x0400567B RID: 22139
	private readonly EUiTabViewName? Default;

	// Token: 0x0400567C RID: 22140
	private readonly Dictionary<EUiTabViewName, UiTabViewBase> UiTabViewMap = new Dictionary<EUiTabViewName, UiTabViewBase>();

	// Token: 0x0400567D RID: 22141
	private EUiTabViewName? HideTabViewKey;

	// Token: 0x0400567E RID: 22142
	private readonly UUIItem RootViewItem;
}
