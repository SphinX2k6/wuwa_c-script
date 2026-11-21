using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200358A RID: 13706
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewFloatContainer : UiViewContainer
	{
		// Token: 0x06022F16 RID: 143126 RVA: 0x009EA5C3 File Offset: 0x009E87C3
		public UiViewFloatContainer(Dictionary<string, FloatViewQueue> floatQueueMap, Dictionary<string, UiViewBase> showViewMap, Dictionary<string, UiViewBase> hideViewMap)
		{
			this.FloatQueueMap = floatQueueMap;
			this.ShowViewMap = showViewMap;
			this.HideViewMap = hideViewMap;
		}

		// Token: 0x06022F17 RID: 143127 RVA: 0x009EA604 File Offset: 0x009E8804
		[NullableContext(0)]
		public override UniTask<bool> OpenViewAsync([Nullable(1)] UiViewBase view)
		{
			UiViewFloatContainer.<OpenViewAsync>d__4 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.view = view;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiViewFloatContainer.<OpenViewAsync>d__4>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F18 RID: 143128 RVA: 0x009EA650 File Offset: 0x009E8850
		public override UniTask CloseViewAsync(UiViewBase view)
		{
			UiViewFloatContainer.<CloseViewAsync>d__5 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.view = view;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiViewFloatContainer.<CloseViewAsync>d__5>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F19 RID: 143129 RVA: 0x009EA69C File Offset: 0x009E889C
		[NullableContext(0)]
		private UniTask<bool> CheckInHandle([Nullable(1)] string area, bool onlyShowInMain, EUiViewName name, int? viewId)
		{
			UiViewFloatContainer.<CheckInHandle>d__6 <CheckInHandle>d__;
			<CheckInHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckInHandle>d__.<>4__this = this;
			<CheckInHandle>d__.area = area;
			<CheckInHandle>d__.onlyShowInMain = onlyShowInMain;
			<CheckInHandle>d__.name = name;
			<CheckInHandle>d__.viewId = viewId;
			<CheckInHandle>d__.<>1__state = -1;
			<CheckInHandle>d__.<>t__builder.Start<UiViewFloatContainer.<CheckInHandle>d__6>(ref <CheckInHandle>d__);
			return <CheckInHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06022F1A RID: 143130 RVA: 0x009EA700 File Offset: 0x009E8900
		private unsafe bool CheckInHide(string area, EUiViewName name, int? viewId)
		{
			UiViewBase uiViewBase;
			this.HideViewMap.TryGetValue(area, out uiViewBase);
			if (uiViewBase == null)
			{
				return false;
			}
			if (!this.CheckView(uiViewBase, name, viewId))
			{
				return false;
			}
			uiViewBase.Destroy(null);
			this.HideViewMap.Remove(area);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiFloatContainer;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "界面关闭成功,隐藏中关闭";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("区域", area);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前界面", name);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x06022F1B RID: 143131 RVA: 0x009EA7A0 File Offset: 0x009E89A0
		private unsafe bool CheckView(UiViewBase view, EUiViewName name, int? viewId)
		{
			if (view.ViewInfo.Name != name || (viewId != null && view.GetViewId() != viewId.Value))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiFloatContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "界面检查失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("view.Info.Name", view.ViewInfo.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("view.GetViewId()", view.GetViewId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("viewId", viewId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			return true;
		}

		// Token: 0x06022F1C RID: 143132 RVA: 0x009EA88C File Offset: 0x009E8A8C
		[return: Nullable(0)]
		private UniTask<bool> CloseView(string area, UiViewBase view)
		{
			UiViewFloatContainer.<CloseView>d__9 <CloseView>d__;
			<CloseView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseView>d__.<>4__this = this;
			<CloseView>d__.area = area;
			<CloseView>d__.view = view;
			<CloseView>d__.<>1__state = -1;
			<CloseView>d__.<>t__builder.Start<UiViewFloatContainer.<CloseView>d__9>(ref <CloseView>d__);
			return <CloseView>d__.<>t__builder.Task;
		}

		// Token: 0x06022F1D RID: 143133 RVA: 0x009EA8DF File Offset: 0x009E8ADF
		private bool InStaggeredState(bool onlyShowInMain)
		{
			return onlyShowInMain && !UiModel.Instance.IsInMainView;
		}

		// Token: 0x06022F1E RID: 143134 RVA: 0x009EA8F3 File Offset: 0x009E8AF3
		private bool NeedWaitNormalQueue(UiFloatConfig config)
		{
			return config.IsWaitNormal && UiModel.Instance.InNormalQueue;
		}

		// Token: 0x06022F1F RID: 143135 RVA: 0x009EA910 File Offset: 0x009E8B10
		private unsafe void HandleNextViewFromQueue(string areaType)
		{
			UiViewBase nextViewFromQueue = this.GetNextViewFromQueue(areaType);
			if (nextViewFromQueue != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiFloatContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "从队列中获取要显示的界面";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("区域", areaType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面", nextViewFromQueue.ViewInfo.Name);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.RefreshParentUiItem(nextViewFromQueue);
				base.OpenViewImplementAsync(nextViewFromQueue);
			}
		}

		// Token: 0x06022F20 RID: 143136 RVA: 0x009EA99C File Offset: 0x009E8B9C
		private UiViewBase GetNextViewFromQueue(string areaType)
		{
			FloatViewQueue floatViewQueue;
			if (!this.FloatQueueMap.TryGetValue(areaType, out floatViewQueue))
			{
				this.ShowViewMap.Remove(areaType);
				return null;
			}
			IUiViewBase uiViewBase = floatViewQueue.Pop(UiModel.Instance.IsInMainView);
			if (uiViewBase == null)
			{
				this.ShowViewMap.Remove(areaType);
				return null;
			}
			if (floatViewQueue.Size <= 0)
			{
				this.FloatQueueMap.Remove(areaType);
			}
			this.ShowViewMap[areaType] = uiViewBase.ViewBase;
			return uiViewBase.ViewBase;
		}

		// Token: 0x06022F21 RID: 143137 RVA: 0x009EAA1C File Offset: 0x009E8C1C
		private unsafe bool PushToFloatQueue(UiFloatConfig config, UiViewBase view)
		{
			string text = StringUtils.IsEmpty(config.Area) ? view.ViewInfo.Name.ToString() : config.Area;
			if (this.ShowViewMap.ContainsKey(text) || this.InStaggeredState(config.OnlyShowInMain) || this.NeedWaitNormalQueue(config))
			{
				FloatViewQueue floatViewQueue;
				if (!this.FloatQueueMap.TryGetValue(text, out floatViewQueue))
				{
					floatViewQueue = new FloatViewQueue();
					this.FloatQueueMap[text] = floatViewQueue;
				}
				floatViewQueue.Push(view, config.Priority, config.OnlyShowInMain);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiFloatContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "界面添加到区域队列中";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("区域", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("界面", view.ViewInfo.Name);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return true;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiFloatContainer;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "界面直接在区域中显示";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("区域", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("界面", view.ViewInfo.Name);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.ShowViewMap[text] = view;
			return false;
		}

		// Token: 0x06022F22 RID: 143138 RVA: 0x009EAB98 File Offset: 0x009E8D98
		public override void ClearContainer(bool clearPermanent = false)
		{
			List<UiViewBase> list = new List<UiViewBase>();
			foreach (FloatViewQueue floatViewQueue in this.FloatQueueMap.Values)
			{
				floatViewQueue.Clear(list);
			}
			List<string> list2 = new List<string>();
			foreach (KeyValuePair<string, UiViewBase> keyValuePair in this.ShowViewMap)
			{
				UiViewBase value = keyValuePair.Value;
				value.IsExistInLeaveLevel = true;
				if (!value.ViewInfo.IsPermanent)
				{
					base.TryCatchViewDestroyCompatible(value);
					list2.Add(keyValuePair.Key);
				}
			}
			foreach (string key in list2)
			{
				this.ShowViewMap.Remove(key);
			}
			list2.Clear();
			foreach (KeyValuePair<string, UiViewBase> keyValuePair2 in this.HideViewMap)
			{
				UiViewBase value2 = keyValuePair2.Value;
				value2.IsExistInLeaveLevel = true;
				if (!value2.ViewInfo.IsPermanent)
				{
					base.TryCatchViewDestroyCompatible(value2);
					list2.Add(keyValuePair2.Key);
				}
			}
			foreach (string key2 in list2)
			{
				this.HideViewMap.Remove(key2);
			}
			foreach (UiViewBase uiViewBase in list)
			{
				CustomPromise<bool> openPromise = uiViewBase.OpenPromise;
				if (openPromise != null)
				{
					openPromise.SetResult(false);
				}
			}
		}

		// Token: 0x06022F23 RID: 143139 RVA: 0x009EADB4 File Offset: 0x009E8FB4
		public void ShowFloatTips()
		{
			Log.Instance.Info(ELogModule.UiFloatContainer, ELogAuthor.XXJ, "主界面显示", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RevertHideToShow();
			this.RevertFloatQueueToShow();
		}

		// Token: 0x06022F24 RID: 143140 RVA: 0x009EADEC File Offset: 0x009E8FEC
		public void HideFloatTips()
		{
			Log.Instance.Info(ELogModule.UiFloatContainer, ELogAuthor.XXJ, "主界面隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RevertShowToHide();
		}

		// Token: 0x06022F25 RID: 143141 RVA: 0x009EAE20 File Offset: 0x009E9020
		public void StartWaitingNormalView()
		{
			foreach (string text in new List<string>(this.FloatQueueMap.Keys))
			{
				if (!this.ShowViewMap.ContainsKey(text))
				{
					this.HandleNextViewFromQueue(text);
				}
			}
		}

		// Token: 0x06022F26 RID: 143142 RVA: 0x009EAE8C File Offset: 0x009E908C
		private void RevertHideToShow()
		{
			foreach (string text in new List<string>(this.HideViewMap.Keys))
			{
				UiViewBase uiViewBase;
				this.HideViewMap.TryGetValue(text, out uiViewBase);
				this.HideViewMap.Remove(text);
				UiViewBase uiViewBase2;
				this.ShowViewMap.TryGetValue(text, out uiViewBase2);
				this.ShowViewMap[text] = uiViewBase;
				this.SetViewActive(uiViewBase, true);
				if (uiViewBase2 != null)
				{
					this.CloseView(text, uiViewBase2);
				}
			}
		}

		// Token: 0x06022F27 RID: 143143 RVA: 0x009EAF30 File Offset: 0x009E9130
		private void RevertFloatQueueToShow()
		{
			foreach (string text in new List<string>(this.FloatQueueMap.Keys))
			{
				UiViewBase uiViewBase;
				this.ShowViewMap.TryGetValue(text, out uiViewBase);
				if (uiViewBase == null)
				{
					this.HandleNextViewFromQueue(text);
				}
			}
		}

		// Token: 0x06022F28 RID: 143144 RVA: 0x009EAFA0 File Offset: 0x009E91A0
		private void RevertShowToHide()
		{
			foreach (string text in new List<string>(this.ShowViewMap.Keys))
			{
				UiViewBase uiViewBase;
				this.ShowViewMap.TryGetValue(text, out uiViewBase);
				if (this.InStaggeredState(UiViewConfig.Instance.GetUiFloatConfig(uiViewBase.ViewInfo.Name).Value.OnlyShowInMain))
				{
					this.HideViewMap[text] = uiViewBase;
					this.ShowViewMap.Remove(text);
					this.HandleNextViewFromQueue(text);
					this.SetViewActive(uiViewBase, false);
				}
			}
		}

		// Token: 0x06022F29 RID: 143145 RVA: 0x009EB05C File Offset: 0x009E925C
		private unsafe void SetViewActive(UiViewBase view, bool bActive)
		{
			if (view.OpenPromise != null && view.OpenPromise.IsPending)
			{
				view.SetLoadingFinishOperation(delegate
				{
					this.HandleAsyncViewSequence(view, bActive);
				});
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiFloatContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "界面在打开中";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("view", view.ViewInfo.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bActive", bActive);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.HandleAsyncViewSequence(view, bActive);
		}

		// Token: 0x06022F2A RID: 143146 RVA: 0x009EB148 File Offset: 0x009E9348
		private unsafe void HandleAsyncViewSequence(UiViewBase view, bool bActive)
		{
			if (bActive)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiFloatContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "界面唤醒界面动画";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("view", view.ViewInfo.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bActive", bActive);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				view.SetActive(true);
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiFloatContainer;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "界面暂停界面动画";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("view", view.ViewInfo.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("bActive", bActive);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			view.SetActive(false);
		}

		// Token: 0x06022F2B RID: 143147 RVA: 0x009EB23C File Offset: 0x009E943C
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewFloatContainer.<PreOpenViewAsync>d__24 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewFloatContainer.<PreOpenViewAsync>d__24>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F2C RID: 143148 RVA: 0x009EB280 File Offset: 0x009E9480
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewFloatContainer.<OpenViewAfterPreOpenedAsync>d__25 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewFloatContainer.<OpenViewAfterPreOpenedAsync>d__25>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F2D RID: 143149 RVA: 0x009EB2C4 File Offset: 0x009E94C4
		public void RefreshByPureModeChanged()
		{
			foreach (UiViewBase view in this.ShowViewMap.Values)
			{
				this.RefreshParentUiItem(view);
			}
			foreach (UiViewBase view2 in this.HideViewMap.Values)
			{
				this.RefreshParentUiItem(view2);
			}
		}

		// Token: 0x06022F2E RID: 143150 RVA: 0x009EB364 File Offset: 0x009E9564
		public void RefreshParentUiItem(UiViewBase view)
		{
			UiFloatConfig? uiFloatConfig = UiViewConfig.Instance.GetUiFloatConfig(view.ViewInfo.Name);
			if (uiFloatConfig == null)
			{
				return;
			}
			if (uiFloatConfig.Value.OnlyShowInMain)
			{
				UUIItem uuiitem;
				if (uiFloatConfig.Value.HideInPureMode && BattleUiModel.Instance.PureModeData != null && BattleUiModel.Instance.PureModeData.IsOpen)
				{
					uuiitem = UiLayer.Instance.GetPureModeFloatUnit(ELayerType.BattleFloat);
				}
				else
				{
					uuiitem = UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, uiFloatConfig.Value.RootItemIndex);
				}
				if (uuiitem != null)
				{
					view.SetParentUiItem(uuiitem);
				}
			}
		}

		// Token: 0x0401348C RID: 78988
		private readonly Dictionary<string, FloatViewQueue> FloatQueueMap = new Dictionary<string, FloatViewQueue>();

		// Token: 0x0401348D RID: 78989
		private readonly Dictionary<string, UiViewBase> ShowViewMap = new Dictionary<string, UiViewBase>();

		// Token: 0x0401348E RID: 78990
		private readonly Dictionary<string, UiViewBase> HideViewMap = new Dictionary<string, UiViewBase>();
	}
}
