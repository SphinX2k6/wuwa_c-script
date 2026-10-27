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
	// Token: 0x02004659 RID: 18009
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewFloatContainer : UiViewContainer
	{
		// Token: 0x0602E7CC RID: 190412 RVA: 0x00ABCF94 File Offset: 0x00ABB194
		public UiViewFloatContainer(Dictionary<string, FloatViewQueue> floatQueueMap, Dictionary<string, UiViewBase> showViewMap, Dictionary<string, UiViewBase> hideViewMap)
		{
			this.FloatQueueMap = floatQueueMap;
			this.ShowViewMap = showViewMap;
			this.HideViewMap = hideViewMap;
		}

		// Token: 0x0602E7CD RID: 190413 RVA: 0x00ABCFD4 File Offset: 0x00ABB1D4
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

		// Token: 0x0602E7CE RID: 190414 RVA: 0x00ABD020 File Offset: 0x00ABB220
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

		// Token: 0x0602E7CF RID: 190415 RVA: 0x00ABD06C File Offset: 0x00ABB26C
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

		// Token: 0x0602E7D0 RID: 190416 RVA: 0x00ABD0D0 File Offset: 0x00ABB2D0
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

		// Token: 0x0602E7D1 RID: 190417 RVA: 0x00ABD170 File Offset: 0x00ABB370
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

		// Token: 0x0602E7D2 RID: 190418 RVA: 0x00ABD25C File Offset: 0x00ABB45C
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

		// Token: 0x0602E7D3 RID: 190419 RVA: 0x00ABD2AF File Offset: 0x00ABB4AF
		private bool InStaggeredState(bool onlyShowInMain)
		{
			return onlyShowInMain && !UiModel.Instance.IsInMainView;
		}

		// Token: 0x0602E7D4 RID: 190420 RVA: 0x00ABD2C3 File Offset: 0x00ABB4C3
		private bool NeedWaitNormalQueue(UiFloatConfig config)
		{
			return config.IsWaitNormal && UiModel.Instance.InNormalQueue;
		}

		// Token: 0x0602E7D5 RID: 190421 RVA: 0x00ABD2E0 File Offset: 0x00ABB4E0
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

		// Token: 0x0602E7D6 RID: 190422 RVA: 0x00ABD36C File Offset: 0x00ABB56C
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

		// Token: 0x0602E7D7 RID: 190423 RVA: 0x00ABD3EC File Offset: 0x00ABB5EC
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

		// Token: 0x0602E7D8 RID: 190424 RVA: 0x00ABD568 File Offset: 0x00ABB768
		public override void ClearContainer(bool clearPermanent = false)
		{
			foreach (FloatViewQueue floatViewQueue in this.FloatQueueMap.Values)
			{
				floatViewQueue.Clear();
			}
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, UiViewBase> keyValuePair in this.ShowViewMap)
			{
				UiViewBase value = keyValuePair.Value;
				value.IsExistInLeaveLevel = true;
				if (!value.ViewInfo.IsPermanent)
				{
					base.TryCatchViewDestroyCompatible(value);
					list.Add(keyValuePair.Key);
				}
			}
			foreach (string key in list)
			{
				this.ShowViewMap.Remove(key);
			}
			list.Clear();
			foreach (KeyValuePair<string, UiViewBase> keyValuePair2 in this.HideViewMap)
			{
				UiViewBase value2 = keyValuePair2.Value;
				value2.IsExistInLeaveLevel = true;
				if (!value2.ViewInfo.IsPermanent)
				{
					base.TryCatchViewDestroyCompatible(value2);
					list.Add(keyValuePair2.Key);
				}
			}
			foreach (string key2 in list)
			{
				this.HideViewMap.Remove(key2);
			}
		}

		// Token: 0x0602E7D9 RID: 190425 RVA: 0x00ABD734 File Offset: 0x00ABB934
		public void ShowFloatTips()
		{
			Log.Instance.Info(ELogModule.UiFloatContainer, ELogAuthor.XXJ, "主界面显示", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RevertHideToShow();
			this.RevertFloatQueueToShow();
		}

		// Token: 0x0602E7DA RID: 190426 RVA: 0x00ABD76C File Offset: 0x00ABB96C
		public void HideFloatTips()
		{
			Log.Instance.Info(ELogModule.UiFloatContainer, ELogAuthor.XXJ, "主界面隐藏", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RevertShowToHide();
		}

		// Token: 0x0602E7DB RID: 190427 RVA: 0x00ABD7A0 File Offset: 0x00ABB9A0
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

		// Token: 0x0602E7DC RID: 190428 RVA: 0x00ABD80C File Offset: 0x00ABBA0C
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

		// Token: 0x0602E7DD RID: 190429 RVA: 0x00ABD8B0 File Offset: 0x00ABBAB0
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

		// Token: 0x0602E7DE RID: 190430 RVA: 0x00ABD920 File Offset: 0x00ABBB20
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

		// Token: 0x0602E7DF RID: 190431 RVA: 0x00ABD9DC File Offset: 0x00ABBBDC
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

		// Token: 0x0602E7E0 RID: 190432 RVA: 0x00ABDAC8 File Offset: 0x00ABBCC8
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

		// Token: 0x0602E7E1 RID: 190433 RVA: 0x00ABDBBC File Offset: 0x00ABBDBC
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewFloatContainer.<PreOpenViewAsync>d__24 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewFloatContainer.<PreOpenViewAsync>d__24>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7E2 RID: 190434 RVA: 0x00ABDC00 File Offset: 0x00ABBE00
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewFloatContainer.<OpenViewAfterPreOpenedAsync>d__25 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewFloatContainer.<OpenViewAfterPreOpenedAsync>d__25>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7E3 RID: 190435 RVA: 0x00ABDC44 File Offset: 0x00ABBE44
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

		// Token: 0x0602E7E4 RID: 190436 RVA: 0x00ABDCE4 File Offset: 0x00ABBEE4
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

		// Token: 0x04018E33 RID: 101939
		private readonly Dictionary<string, FloatViewQueue> FloatQueueMap = new Dictionary<string, FloatViewQueue>();

		// Token: 0x04018E34 RID: 101940
		private readonly Dictionary<string, UiViewBase> ShowViewMap = new Dictionary<string, UiViewBase>();

		// Token: 0x04018E35 RID: 101941
		private readonly Dictionary<string, UiViewBase> HideViewMap = new Dictionary<string, UiViewBase>();
	}
}
