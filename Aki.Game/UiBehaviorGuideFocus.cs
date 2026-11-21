using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001290 RID: 4752
[NullableContext(1)]
[Nullable(0)]
public class UiBehaviorGuideFocus : IUiBehavior
{
	// Token: 0x0600BC5D RID: 48221 RVA: 0x0037A748 File Offset: 0x00378948
	public UiBehaviorGuideFocus(UiPanelBase owner)
	{
		this.Owner = owner;
		UiPanelBase owner2 = this.Owner;
		object obj;
		if (owner2 == null)
		{
			obj = null;
		}
		else
		{
			AActor rootActor = owner2.GetRootActor();
			obj = ((rootActor != null) ? rootActor.GetComponentByClass(UUIGuideMarkComponent.StaticClass()) : null);
		}
		this.UiGuideMark = (obj as UUIGuideMarkComponent);
	}

	// Token: 0x0600BC5E RID: 48222 RVA: 0x0037A795 File Offset: 0x00378995
	public void SetOwner(UiPanelBase owner)
	{
		this.Owner = owner;
		UiPanelBase owner2 = this.Owner;
		object obj;
		if (owner2 == null)
		{
			obj = null;
		}
		else
		{
			AActor rootActor = owner2.GetRootActor();
			obj = ((rootActor != null) ? rootActor.GetComponentByClass(UUIGuideMarkComponent.StaticClass()) : null);
		}
		this.UiGuideMark = (obj as UUIGuideMarkComponent);
	}

	// Token: 0x0600BC5F RID: 48223 RVA: 0x0037A7D4 File Offset: 0x003789D4
	public void SetParam(params object[] @params)
	{
		this.GuideStepInfo = (@params[0] as GuideStepInfo);
		this.FocusConfig = new GuideFocusNew?((GuideFocusNew)this.GuideStepInfo.ViewData.ViewConf);
		if (GuideTestUtil.CheckIsGmTest(this.FocusConfig.Value))
		{
			GuideTestParam guideTestParams = GuideTestUtil.GuideTestParams;
			this.FocusConfViewName = guideTestParams.ViewName;
		}
		else if (!string.IsNullOrEmpty(this.FocusConfig.Value.DynamicTabName))
		{
			this.FocusConfViewName = this.FocusConfig.Value.DynamicTabName;
		}
		else
		{
			this.FocusConfViewName = this.FocusConfig.Value.ViewName;
		}
		UiPanelBase owner = this.Owner;
		if (owner is UiViewBase)
		{
			UiViewInfo viewInfo = (owner as UiViewBase).ViewInfo;
			EUiViewName? euiViewName = (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null;
			this.RealViewName = ((euiViewName != null) ? euiViewName.GetValueOrDefault() : null);
			return;
		}
		if (owner is UiTabViewBase)
		{
			this.RealViewName = (owner as UiTabViewBase).GetViewName();
			return;
		}
		if (GuideDefine.isCustomTabViewForGuide(owner))
		{
			this.RealViewName = ((GuideDefine.ICustomTabViewForGuide)owner).GetViewName();
		}
	}

	// Token: 0x0600BC60 RID: 48224 RVA: 0x0037A90A File Offset: 0x00378B0A
	public UniTask OnUiCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600BC61 RID: 48225 RVA: 0x0037A911 File Offset: 0x00378B11
	public void OnUiStart()
	{
	}

	// Token: 0x0600BC62 RID: 48226 RVA: 0x0037A914 File Offset: 0x00378B14
	public void OnUiShow()
	{
		if (this.GuideStepInfo == null)
		{
			return;
		}
		if (this.GuideStepInfo.StateMachine.CurrentState.GetValueOrDefault() != EGuideStepState.Executing)
		{
			this.GuideStepInfo.TryEnterExecuting();
			return;
		}
		GuideBaseView guideView = this.GuideStepInfo.GuideView;
		if (guideView == null)
		{
			return;
		}
		guideView.Show(null);
	}

	// Token: 0x0600BC63 RID: 48227 RVA: 0x0037A967 File Offset: 0x00378B67
	public void OnUiHide()
	{
		if (this.GuideStepInfo == null)
		{
			return;
		}
		GuideBaseView guideView = this.GuideStepInfo.GuideView;
		if (guideView == null)
		{
			return;
		}
		guideView.Hide(null);
	}

	// Token: 0x0600BC64 RID: 48228 RVA: 0x0037A988 File Offset: 0x00378B88
	public void CleanGuideStep()
	{
		this.GuideStepInfo = null;
	}

	// Token: 0x0600BC65 RID: 48229 RVA: 0x0037A994 File Offset: 0x00378B94
	public void OnDestroy()
	{
		if (this.GuideStepInfo == null)
		{
			return;
		}
		this.RealViewName = null;
		this.FocusConfViewName = null;
		GuideStepInfo guideStepInfo = this.GuideStepInfo;
		int? num;
		if (guideStepInfo == null)
		{
			num = null;
		}
		else
		{
			StateMachine<GuideStepInfo, EGuideStepState> stateMachine = guideStepInfo.StateMachine;
			num = ((stateMachine != null) ? stateMachine.CurrentState : null);
		}
		if (!(num != 1))
		{
			this.GuideStepInfo.SwitchState(EGuideStepState.Break);
		}
		this.GuideStepInfo = null;
	}

	// Token: 0x0600BC66 RID: 48230 RVA: 0x0037AA10 File Offset: 0x00378C10
	public unsafe bool PrepareForOpenGuideFocus()
	{
		this.GuideStepInfo.ViewData.ResetAttachedUiItem();
		if (this.RealViewName != this.FocusConfViewName)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "聚焦引导配置依附的界面与实际打开的界面不一致";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前打开的界面名称", this.RealViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("引导应该依附的界面", this.FocusConfViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("引导组id", this.GuideStepInfo.OwnerGroup.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("聚焦引导Id", this.GuideStepInfo.Id);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		if (!this.TryAttachUiItem())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "聚焦引导步骤  因找不到挂点ui而挂起";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GuideStepInfo!.Id", this.GuideStepInfo.Id);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		UiPanelBase attachedView = this.GuideStepInfo.ViewData.GetAttachedView();
		if (((attachedView != null) ? attachedView.GetRootActor() : null) == null || (attachedView != null && !attachedView.GetActive()))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Guide;
			ELogAuthor author3 = ELogAuthor.TL;
			string message3 = "聚焦引导步骤  附着界面不可见而挂起";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("GuideStepInfo!.Id", this.GuideStepInfo.Id);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		return true;
	}

	// Token: 0x0600BC67 RID: 48231 RVA: 0x0037AB98 File Offset: 0x00378D98
	private bool TryAttachUiItem()
	{
		if (this.Owner == null)
		{
			return false;
		}
		if (this.Owner.GetRootItem() == null || !this.Owner.GetActive())
		{
			return false;
		}
		GuideFocusNew value = this.FocusConfig.Value;
		return this.TryAttachGmTest() || this.TryMultiAttach() || this.TryAttachUiItemByGuideMark(value.GuideMarkName, value.GuideMarkNameForShow) || this.TryAttachUiItemByExtraParam(value.ExtraParam()) || this.TryAttachUiItemByHook(value.HookName, value.HookNameForShow);
	}

	// Token: 0x0600BC68 RID: 48232 RVA: 0x0037AC30 File Offset: 0x00378E30
	private unsafe bool TryMultiAttach()
	{
		GuideStepInfo guideStepInfo = this.GuideStepInfo;
		string[] array = this.FocusConfig.Value.MultiGuideBox();
		if (array == null || array.Length == 0)
		{
			return false;
		}
		if (this.UiGuideMark == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "未挂载UiGuideMark组件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.UiGuideMark.Type != EUIGuideMarkType.Parent)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.HYF;
			string message2 = "UiGuideMark组件类型错误, 应为Parent, 请检查预制体";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (this.UiGuideMark.Children.Num() == 0)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Guide;
			ELogAuthor author3 = ELogAuthor.HYF;
			string message3 = "UiGuideMark组件下节点列表为空@2,这可能是对应节点还未生成";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		List<UUIItem> list = new List<UUIItem>();
		foreach (string text in array)
		{
			TWeakObjectPtr<AActor>? tweakObjectPtr;
			AActor aactor = (this.UiGuideMark.Children.GetValueOrNull(text) != null) ? tweakObjectPtr.GetValueOrDefault().Get() : null;
			if (aactor == null || !aactor.IsValid())
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Guide;
				ELogAuthor author4 = ELogAuthor.HYF;
				string message4 = "UiGuideMark组件下未找到指定名称的节点";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("节点名称", text);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			UUIItem uiitem = ((AUIBaseActor)aactor).GetUIItem();
			if (uiitem == null)
			{
				return false;
			}
			list.Add(uiitem);
		}
		guideStepInfo.ViewData.SetMultiAttachItems(list);
		guideStepInfo.ViewData.SetAttachedUiItem(list[0]);
		guideStepInfo.ViewData.SetAttachedUiItemForShow(list[0]);
		return true;
	}

	// Token: 0x0600BC69 RID: 48233 RVA: 0x0037AE38 File Offset: 0x00379038
	private unsafe bool TryAttachUiItemByGuideMark(string configName, string configNameForShow)
	{
		GuideStepInfo guideStepInfo = this.GuideStepInfo;
		string text = configNameForShow;
		if (string.IsNullOrEmpty(configName))
		{
			return false;
		}
		if (string.IsNullOrEmpty(text))
		{
			text = configName;
		}
		if (this.UiGuideMark == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "未挂载UiGuideMark组件, 尝试其他方式获取聚焦控件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.UiGuideMark.Type != EUIGuideMarkType.Parent)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.HYF;
			string message2 = "UiGuideMark组件类型错误, 应为Parent, 请检查预制体";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (this.UiGuideMark.Children.Num() == 0)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Guide;
			ELogAuthor author3 = ELogAuthor.HYF;
			string message3 = "UiGuideMark组件下节点列表为空@1,这可能是对应节点还未生成";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		TWeakObjectPtr<AActor>? valueOrNull = this.UiGuideMark.Children.GetValueOrNull(configName);
		AActor aactor = (valueOrNull != null) ? valueOrNull.GetValueOrDefault().Get() : null;
		if (aactor == null || !aactor.IsValid())
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Guide;
			ELogAuthor author4 = ELogAuthor.TZJ;
			string message4 = "UiGuideMark索引-没找到对应目标或目标无效,这可能是对应节点还未生成";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("要寻找的Mark名字", configName);
			instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		UUIItem uiitem = ((AUIBaseActor)aactor).GetUIItem();
		if (uiitem == null)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Guide;
			ELogAuthor author5 = ELogAuthor.TZJ;
			string message5 = "UiGuideMark索引-目标无效@2";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return false;
		}
		guideStepInfo.ViewData.SetAttachedUiItem(uiitem);
		valueOrNull = this.UiGuideMark.Children.GetValueOrNull(text);
		AActor aactor2 = (valueOrNull != null) ? valueOrNull.GetValueOrDefault().Get() : null;
		if (aactor2 == null || !aactor2.IsValid())
		{
			Log instance6 = Log.Instance;
			ELogModule module6 = ELogModule.Guide;
			ELogAuthor author6 = ELogAuthor.TZJ;
			string message6 = "UiGuideMark索引-目标无效@3";
			ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
			return false;
		}
		UUIItem uiitem2 = ((AUIBaseActor)aactor2).GetUIItem();
		if (uiitem2 == null)
		{
			Log instance7 = Log.Instance;
			ELogModule module7 = ELogModule.Guide;
			ELogAuthor author7 = ELogAuthor.TZJ;
			string message7 = "UiGuideMark索引-目标无效@4";
			ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("步骤Id", guideStepInfo.Id);
			instance7.Error(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
			return false;
		}
		guideStepInfo.ViewData.SetAttachedUiItemForShow(uiitem2);
		return true;
	}

	// Token: 0x0600BC6A RID: 48234 RVA: 0x0037B0D4 File Offset: 0x003792D4
	private bool TryAttachUiItemByExtraParam(string[] configExtraParams)
	{
		GuideStepInfo guideStepInfo = this.GuideStepInfo;
		if (configExtraParams.Length == 0)
		{
			return false;
		}
		UUIItem[] guideUiItemAndUiItemForShowEx = this.Owner.GetGuideUiItemAndUiItemForShowEx(configExtraParams);
		if (guideUiItemAndUiItemForShowEx == null || guideUiItemAndUiItemForShowEx.Length != 2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "聚焦引导  额外参数解析失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stepInfo!.Id", guideStepInfo.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		GuideStepViewData viewData = guideStepInfo.ViewData;
		viewData.SetAttachedUiItem(guideUiItemAndUiItemForShowEx[0]);
		viewData.SetAttachedUiItemForShow(guideUiItemAndUiItemForShowEx[1]);
		UUIScrollViewComponent guideScrollViewToLock = this.Owner.GetGuideScrollViewToLock();
		if (guideScrollViewToLock != null)
		{
			viewData.TryLockScrollView(guideScrollViewToLock);
		}
		return true;
	}

	// Token: 0x0600BC6B RID: 48235 RVA: 0x0037B174 File Offset: 0x00379374
	private unsafe bool TryAttachUiItemByHook(string configHookName, string configHookNameForShow)
	{
		GuideStepInfo guideStepInfo = this.GuideStepInfo;
		UUIItem guideUiItem = this.Owner.GetGuideUiItem(configHookName);
		string text = configHookNameForShow;
		if (StringUtils.IsEmpty(text))
		{
			text = configHookName;
		}
		text = ((text != null) ? text.Replace("New:", "") : null);
		if (guideUiItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "挂接组件(GuideHookRegistry)未找到该挂接点名称，可能是等待出现或配置错误";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前打开的界面名称", this.RealViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("引导应该依附的界面", this.FocusConfViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("引导组id", guideStepInfo.OwnerGroup.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("聚焦引导Id", guideStepInfo.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("出错的挂点名称", configHookName);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return false;
		}
		UUIItem guideUiItem2 = this.Owner.GetGuideUiItem(text);
		if (guideUiItem2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "挂接组件(GuideHookRegistry)未找到该挂接点（展示用）名称，可能是等待出现或配置错误";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("当前打开的界面名称", this.RealViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("引导应该依附的界面", this.FocusConfViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("引导组id", guideStepInfo.OwnerGroup.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("聚焦引导Id", guideStepInfo.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("出错的挂点名称", text);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
			return false;
		}
		guideStepInfo.ViewData.SetAttachedUiItem(guideUiItem);
		guideStepInfo.ViewData.SetAttachedUiItemForShow(guideUiItem2);
		return true;
	}

	// Token: 0x0600BC6C RID: 48236 RVA: 0x0037B370 File Offset: 0x00379570
	private bool TryAttachGmTest()
	{
		if (!GuideTestUtil.CheckIsGmTest(this.FocusConfig.Value))
		{
			return false;
		}
		GuideTestParam guideTestParams = GuideTestUtil.GuideTestParams;
		if (!string.IsNullOrEmpty(guideTestParams.HookName))
		{
			GuideTestUtil.Debug("聚焦引导GM测试模式, 通过HookName挂点:" + guideTestParams.HookName, default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.TryAttachUiItemByHook(guideTestParams.HookName, guideTestParams.HookNameForShow);
		}
		if (!string.IsNullOrEmpty(guideTestParams.MarkName))
		{
			GuideTestUtil.Debug("聚焦引导GM测试模式, 通过GuideMarkName挂点:" + guideTestParams.MarkName, default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.TryAttachUiItemByGuideMark(guideTestParams.MarkName, guideTestParams.MarkNameForShow);
		}
		if (guideTestParams.ExtraParams != null && guideTestParams.ExtraParams.Length != 0)
		{
			GuideTestUtil.Debug("聚焦引导GM测试模式, 通过ExtraParam挂点:" + string.Join(",", guideTestParams.ExtraParams), default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.TryAttachUiItemByExtraParam(guideTestParams.ExtraParams);
		}
		return false;
	}

	// Token: 0x04006C50 RID: 27728
	[Nullable(2)]
	private GuideStepInfo GuideStepInfo;

	// Token: 0x04006C51 RID: 27729
	[Nullable(2)]
	private string FocusConfViewName;

	// Token: 0x04006C52 RID: 27730
	[Nullable(2)]
	private string RealViewName;

	// Token: 0x04006C53 RID: 27731
	private GuideFocusNew? FocusConfig;

	// Token: 0x04006C54 RID: 27732
	[Nullable(2)]
	private UiPanelBase Owner;

	// Token: 0x04006C55 RID: 27733
	[Nullable(2)]
	private UUIGuideMarkComponent UiGuideMark;
}
