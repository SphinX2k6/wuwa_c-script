using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003603 RID: 13827
	[NullableContext(1)]
	[Nullable(0)]
	public class UiManager : Singleton, ITickable
	{
		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x06023375 RID: 144245 RVA: 0x00A0130A File Offset: 0x009FF50A
		internal UiCommandSwitcherManager CommandSwitcherManager { get; } = new UiCommandSwitcherManager();

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x06023376 RID: 144246 RVA: 0x00A01312 File Offset: 0x009FF512
		public bool IsInited
		{
			get
			{
				return this.InitState == EInitState.Inited;
			}
		}

		// Token: 0x06023377 RID: 144247 RVA: 0x00A0131D File Offset: 0x009FF51D
		public IReadOnlyDictionary<EUiViewName, HashSet<UiViewBase>> GetNameToViewSetMap()
		{
			return this.NameToViewSetMap;
		}

		// Token: 0x06023378 RID: 144248 RVA: 0x00A01328 File Offset: 0x009FF528
		[NullableContext(2)]
		private unsafe void OpenViewPrivate(EUiViewName name, object param = null, ELayerType? layerType = null, TOpenViewCallBack finishCallback = null)
		{
			EventSystem.Instance.Emit<EUiViewName>(EEventName.OpenViewBegined, name);
			this.OpenViewAsync(name, param, layerType).ContinueWith(delegate(int? viewId)
			{
				if (viewId != null)
				{
					TOpenViewCallBack finishCallback2 = finishCallback;
					if (finishCallback2 != null)
					{
						finishCallback2(true, viewId.Value);
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiManager;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[OpenView]流程执行成功";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewId", viewId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				TOpenViewCallBack finishCallback3 = finishCallback;
				if (finishCallback3 != null)
				{
					finishCallback3(false, 0);
				}
				EventSystem.Instance.Emit<EUiViewName>(EEventName.OpenViewFail, name);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiManager;
				ELogAuthor author2 = ELogAuthor.TL;
				string message2 = "[OpenView]流程执行失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", name);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}).Forget(delegate(Exception exception)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[OpenView]流程执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", name);
				instance.ErrorWithStack(module, author, message, exception, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				TOpenViewCallBack finishCallback2 = finishCallback;
				if (finishCallback2 != null)
				{
					finishCallback2(false, 0);
				}
				EventSystem.Instance.Emit<EUiViewName>(EEventName.OpenViewFail, name);
			}, true);
		}

		// Token: 0x06023379 RID: 144249 RVA: 0x00A01390 File Offset: 0x009FF590
		[NullableContext(2)]
		public void OpenView(EUiViewName name, object param = null, TOpenViewCallBack finishCallback = null)
		{
			this.OpenViewPrivate(name, param, null, finishCallback);
		}

		// Token: 0x0602337A RID: 144250 RVA: 0x00A013AF File Offset: 0x009FF5AF
		[NullableContext(2)]
		public void OpenViewWithLayer(EUiViewName name, ELayerType layerType, object param = null, TOpenViewCallBack finishCallback = null)
		{
			this.OpenViewPrivate(name, param, new ELayerType?(layerType), finishCallback);
		}

		// Token: 0x0602337B RID: 144251 RVA: 0x00A013C1 File Offset: 0x009FF5C1
		[NullableContext(2)]
		public void OpenViewByPlot(EUiViewName name, object param = null, TOpenViewCallBack finishCallback = null)
		{
			if ((UiConfig.Instance.TryGetViewInfo(name).Type & (ELayerType.Normal | ELayerType.Plot | ELayerType.CG)) > (ELayerType)0)
			{
				this.OpenViewWithLayer(name, ELayerType.Plot, param, finishCallback);
				return;
			}
			this.OpenView(name, param, finishCallback);
		}

		// Token: 0x0602337C RID: 144252 RVA: 0x00A013F0 File Offset: 0x009FF5F0
		[NullableContext(0)]
		public UniTask<int?> OpenViewAsync(EUiViewName name, [Nullable(2)] object param = null, ELayerType? layerType = null)
		{
			UiManager.<OpenViewAsync>d__24 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.name = name;
			<OpenViewAsync>d__.param = param;
			<OpenViewAsync>d__.layerType = layerType;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiManager.<OpenViewAsync>d__24>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602337D RID: 144253 RVA: 0x00A0144C File Offset: 0x009FF64C
		[NullableContext(2)]
		public void CloseView(EUiViewName name, Action<bool> callback = null)
		{
			this.CloseViewAsync(name).ContinueWith(delegate(bool result)
			{
				if (result)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiManager;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[CloseView]流程执行成功";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", name);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiManager;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "[CloseView]流程执行异常";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ViewName", name);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(result);
			}).Forget(delegate(Exception exception)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CloseView]流程执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", name);
				instance.ErrorWithStack(module, author, message, exception, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
			}, true);
		}

		// Token: 0x0602337E RID: 144254 RVA: 0x00A0149C File Offset: 0x009FF69C
		[NullableContext(0)]
		public UniTask<bool> CloseViewAsync(EUiViewName name)
		{
			UiManager.<CloseViewAsync>d__26 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.name = name;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiManager.<CloseViewAsync>d__26>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602337F RID: 144255 RVA: 0x00A014E8 File Offset: 0x009FF6E8
		[NullableContext(2)]
		public void CloseViewById(int viewId, Action<bool> callback = null)
		{
			this.CloseViewByIdAsync(viewId).ContinueWith(delegate(bool task)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CloseViewById]流程执行成功";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewId", viewId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(true);
			}).Forget(delegate(Exception exception)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CloseViewById]流程执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewId", viewId);
				instance.ErrorWithStack(module, author, message, exception, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
			}, true);
		}

		// Token: 0x06023380 RID: 144256 RVA: 0x00A01538 File Offset: 0x009FF738
		[NullableContext(0)]
		public UniTask<bool> CloseViewByIdAsync(int viewId)
		{
			UiManager.<CloseViewByIdAsync>d__28 <CloseViewByIdAsync>d__;
			<CloseViewByIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewByIdAsync>d__.<>4__this = this;
			<CloseViewByIdAsync>d__.viewId = viewId;
			<CloseViewByIdAsync>d__.<>1__state = -1;
			<CloseViewByIdAsync>d__.<>t__builder.Start<UiManager.<CloseViewByIdAsync>d__28>(ref <CloseViewByIdAsync>d__);
			return <CloseViewByIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023381 RID: 144257 RVA: 0x00A01584 File Offset: 0x009FF784
		[NullableContext(0)]
		public UniTask<bool> CloseViewImplementAsync([Nullable(1)] UiViewBase view, bool fromCloseMe = false)
		{
			UiManager.<CloseViewImplementAsync>d__29 <CloseViewImplementAsync>d__;
			<CloseViewImplementAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewImplementAsync>d__.<>4__this = this;
			<CloseViewImplementAsync>d__.view = view;
			<CloseViewImplementAsync>d__.<>1__state = -1;
			<CloseViewImplementAsync>d__.<>t__builder.Start<UiManager.<CloseViewImplementAsync>d__29>(ref <CloseViewImplementAsync>d__);
			return <CloseViewImplementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023382 RID: 144258 RVA: 0x00A015D0 File Offset: 0x009FF7D0
		[NullableContext(2)]
		public unsafe void CloseAndOpenView(EUiViewName closeViewName, EUiViewName openViewName, object param = null, Action<bool> finishCallback = null, bool callJs = true)
		{
			this.CloseAndOpenViewAsync(closeViewName, openViewName, param, callJs).ContinueWith(delegate(bool task)
			{
				Action<bool> finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2(true);
			}).Forget(delegate(Exception exception)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CloseAndOpenView]流程执行异常";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("closeViewName", closeViewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("openViewName", openViewName);
				instance.ErrorWithStack(module, author, message, exception, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				Action<bool> finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2(false);
			}, true);
		}

		// Token: 0x06023383 RID: 144259 RVA: 0x00A01634 File Offset: 0x009FF834
		[NullableContext(0)]
		public UniTask<bool> CloseAndOpenViewAsync(EUiViewName closeViewName, EUiViewName openViewName, [Nullable(2)] object param, bool callJs = true)
		{
			UiManager.<CloseAndOpenViewAsync>d__31 <CloseAndOpenViewAsync>d__;
			<CloseAndOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseAndOpenViewAsync>d__.<>4__this = this;
			<CloseAndOpenViewAsync>d__.closeViewName = closeViewName;
			<CloseAndOpenViewAsync>d__.openViewName = openViewName;
			<CloseAndOpenViewAsync>d__.param = param;
			<CloseAndOpenViewAsync>d__.callJs = callJs;
			<CloseAndOpenViewAsync>d__.<>1__state = -1;
			<CloseAndOpenViewAsync>d__.<>t__builder.Start<UiManager.<CloseAndOpenViewAsync>d__31>(ref <CloseAndOpenViewAsync>d__);
			return <CloseAndOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023384 RID: 144260 RVA: 0x00A01698 File Offset: 0x009FF898
		[NullableContext(0)]
		public UniTask<int?> PreOpenViewAsync(EUiViewName name, bool callJs = false)
		{
			UiManager.<PreOpenViewAsync>d__32 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<PreOpenViewAsync>d__.<>4__this = this;
			<PreOpenViewAsync>d__.name = name;
			<PreOpenViewAsync>d__.callJs = callJs;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiManager.<PreOpenViewAsync>d__32>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023385 RID: 144261 RVA: 0x00A016EC File Offset: 0x009FF8EC
		[NullableContext(0)]
		public UniTask<bool> OpenViewAfterPreOpenedAsync(int viewId, [Nullable(2)] object param = null, bool callJs = true)
		{
			UiManager.<OpenViewAfterPreOpenedAsync>d__33 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAfterPreOpenedAsync>d__.<>4__this = this;
			<OpenViewAfterPreOpenedAsync>d__.viewId = viewId;
			<OpenViewAfterPreOpenedAsync>d__.param = param;
			<OpenViewAfterPreOpenedAsync>d__.callJs = callJs;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiManager.<OpenViewAfterPreOpenedAsync>d__33>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023386 RID: 144262 RVA: 0x00A01747 File Offset: 0x009FF947
		public void RemovePreOpenView(int viewId)
		{
			this.PreOpeningViewMap.Remove(viewId);
		}

		// Token: 0x06023387 RID: 144263 RVA: 0x00A01758 File Offset: 0x009FF958
		private unsafe void ClearPreOpenView()
		{
			foreach (UiViewBase uiViewBase in this.PreOpeningViewMap.Values)
			{
				try
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiManager;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "[Clear] 尝试执行销毁的界面";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", uiViewBase.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", uiViewBase.ComponentId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					uiViewBase.OnOpenAfterPreOpened();
					uiViewBase.ClearAsync();
				}
				catch (Exception item)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiManager;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "界面同步关闭异常,业务变量可能未初始化完成,需要关注";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Exception", item);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			this.PreOpeningViewMap.Clear();
		}

		// Token: 0x06023388 RID: 144264 RVA: 0x00A01870 File Offset: 0x009FFA70
		public bool IsViewShow(EUiViewName name)
		{
			HashSet<UiViewBase> valueOrDefault = this.NameToViewSetMap.GetValueOrDefault(name);
			if (valueOrDefault == null)
			{
				return false;
			}
			foreach (UiViewBase uiViewBase in valueOrDefault)
			{
				if (uiViewBase.IsPreOpening)
				{
					return false;
				}
				if (uiViewBase.IsShowOrShowing)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06023389 RID: 144265 RVA: 0x00A018E4 File Offset: 0x009FFAE4
		public bool IsViewOpen(EUiViewName viewName)
		{
			HashSet<UiViewBase> valueOrDefault = this.NameToViewSetMap.GetValueOrDefault(viewName);
			if (valueOrDefault == null)
			{
				return false;
			}
			foreach (UiViewBase uiViewBase in valueOrDefault)
			{
				if (uiViewBase.IsPreOpening)
				{
					return false;
				}
				if (uiViewBase.WaitToDestroy)
				{
					return false;
				}
				if (!uiViewBase.IsDestroyOrDestroying && !uiViewBase.IsHideOrHiding)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602338A RID: 144266 RVA: 0x00A0196C File Offset: 0x009FFB6C
		public bool IsViewCreating(EUiViewName name)
		{
			HashSet<UiViewBase> valueOrDefault = this.NameToViewSetMap.GetValueOrDefault(name);
			if (valueOrDefault == null)
			{
				return false;
			}
			using (HashSet<UiViewBase>.Enumerator enumerator = valueOrDefault.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsCreating)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602338B RID: 144267 RVA: 0x00A019D4 File Offset: 0x009FFBD4
		public bool IsViewDestroying(EUiViewName name)
		{
			HashSet<UiViewBase> valueOrDefault = this.NameToViewSetMap.GetValueOrDefault(name);
			if (valueOrDefault == null)
			{
				return false;
			}
			using (HashSet<UiViewBase>.Enumerator enumerator = valueOrDefault.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsDestroying)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602338C RID: 144268 RVA: 0x00A01A3C File Offset: 0x009FFC3C
		public bool IsViewHide(EUiViewName name)
		{
			HashSet<UiViewBase> valueOrDefault = this.NameToViewSetMap.GetValueOrDefault(name);
			if (valueOrDefault == null)
			{
				return false;
			}
			using (HashSet<UiViewBase>.Enumerator enumerator = valueOrDefault.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsHideOrHiding)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602338D RID: 144269 RVA: 0x00A01AA4 File Offset: 0x009FFCA4
		private void InitContainer()
		{
			this.Containers.Clear();
			this.Containers[ELayerType.HUD] = new UiViewSetContainer(UiModel.Instance.HudMap);
			UiViewStackContainer value = new UiViewStackContainer(UiModel.Instance.NormalStack);
			this.Containers[ELayerType.Normal] = value;
			this.Containers[ELayerType.CG] = value;
			this.Containers[ELayerType.Plot] = new UiViewPlotContainer(UiModel.Instance.PlotNormalStack);
			this.Containers[ELayerType.Pop] = new UiViewListContainer(UiModel.Instance.PopList);
			this.Containers[ELayerType.Float] = new UiViewFloatContainer(UiModel.Instance.FloatQueueMap, UiModel.Instance.ShowViewMap, UiModel.Instance.HideViewMap);
			this.Containers[ELayerType.Guide] = new UiViewListContainer(UiModel.Instance.GuideList);
			this.Containers[ELayerType.Loading] = new UiViewSetContainer(UiModel.Instance.LoadingMap);
			this.Containers[ELayerType.NetWork] = new UiViewListContainer(UiModel.Instance.NetWorkList);
		}

		// Token: 0x0602338E RID: 144270 RVA: 0x00A01BCC File Offset: 0x009FFDCC
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ExitNormalQueueState, new Action(this.ExitNormalQueueState));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.ShowFloatTips));
			EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.HideFloatTips));
			EventSystem.Instance.Add(EEventName.StackOpenView, new Action<int, UiViewInfo>(this.OnStackOpenView));
			EventSystem.Instance.Add(EEventName.StackCloseView, new Action<int, EUiViewName, UiViewInfo>(this.OnStackCloseView));
		}

		// Token: 0x0602338F RID: 144271 RVA: 0x00A01C5F File Offset: 0x009FFE5F
		[NullableContext(2)]
		private void OnStackOpenView(int viewId, UiViewInfo lastView)
		{
			this.CheckAndEmitNormalTopViewChange();
		}

		// Token: 0x06023390 RID: 144272 RVA: 0x00A01C67 File Offset: 0x009FFE67
		[NullableContext(2)]
		private void OnStackCloseView(int viewId, EUiViewName viewName, UiViewInfo stackTopInfo)
		{
			this.CheckAndEmitNormalTopViewChange();
		}

		// Token: 0x06023391 RID: 144273 RVA: 0x00A01C70 File Offset: 0x009FFE70
		private void CheckAndEmitNormalTopViewChange()
		{
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
			EUiViewName? euiViewName;
			if (topView == null)
			{
				euiViewName = null;
			}
			else
			{
				UiViewInfo viewInfo = topView.ViewInfo;
				euiViewName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
			}
			EUiViewName? euiViewName2 = euiViewName;
			if (euiViewName2 == null)
			{
				return;
			}
			if (this.LastNormalTopViewName == euiViewName2)
			{
				return;
			}
			this.LastNormalTopViewName = euiViewName2;
			EventSystem.Instance.Emit<EUiViewName>(EEventName.OnNormalTopViewChange, euiViewName2.Value);
		}

		// Token: 0x06023392 RID: 144274 RVA: 0x00A01D1C File Offset: 0x009FFF1C
		private void ResetToBattleViewForEvent()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "重置回到主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			((UiViewListContainer)this.Containers[ELayerType.Pop]).CloseAllView();
			this.NormalResetToView(EUiViewName.BattleView, null, true);
		}

		// Token: 0x06023393 RID: 144275 RVA: 0x00A01D6C File Offset: 0x009FFF6C
		private void ExitNormalQueueState()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "退出队列状态,重置回到主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StartFloatWaitingNormalView();
		}

		// Token: 0x06023394 RID: 144276 RVA: 0x00A01DA0 File Offset: 0x009FFFA0
		[NullableContext(2)]
		public void ResetToBattleView(Action<bool> callback = null)
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "重置回到主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			((UiViewListContainer)this.Containers[ELayerType.Pop]).CloseAllView();
			this.NormalResetToView(UiModel.Instance.MainViewName, callback, true);
			EventSystem.Instance.Emit(EEventName.OnResetToBattleView);
		}

		// Token: 0x06023395 RID: 144277 RVA: 0x00A01E08 File Offset: 0x00A00008
		[NullableContext(2)]
		public void NormalResetToView(EUiViewName viewName, Action<bool> callback = null, bool callJs = true)
		{
			this.NormalResetToViewAsync(viewName, callJs).ContinueWith(delegate()
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[NormalResetToView]流程执行成功";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(true);
			}).Forget(delegate(Exception exception)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[NormalResetToView]流程执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.ErrorWithStack(module, author, message, exception, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
			}, true);
		}

		// Token: 0x06023396 RID: 144278 RVA: 0x00A01E5C File Offset: 0x00A0005C
		public UniTask NormalResetToViewAsync(EUiViewName viewName, bool callJs = true)
		{
			UiManager.<NormalResetToViewAsync>d__50 <NormalResetToViewAsync>d__;
			<NormalResetToViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NormalResetToViewAsync>d__.<>4__this = this;
			<NormalResetToViewAsync>d__.viewName = viewName;
			<NormalResetToViewAsync>d__.callJs = callJs;
			<NormalResetToViewAsync>d__.<>1__state = -1;
			<NormalResetToViewAsync>d__.<>t__builder.Start<UiManager.<NormalResetToViewAsync>d__50>(ref <NormalResetToViewAsync>d__);
			return <NormalResetToViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023397 RID: 144279 RVA: 0x00A01EB0 File Offset: 0x00A000B0
		[NullableContext(2)]
		public void CloseHistoryRingView(EUiViewName viewName, Action<bool> callback = null)
		{
			this.CloseHistoryRingViewAsync(viewName).ContinueWith(delegate()
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CloseHistoryRingView]流程执行成功";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(true);
			}).Forget(delegate(Exception exception)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CloseHistoryRingView]流程执行异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.ErrorWithStack(module, author, message, exception, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
			}, true);
		}

		// Token: 0x06023398 RID: 144280 RVA: 0x00A01F00 File Offset: 0x00A00100
		public UniTask CloseHistoryRingViewAsync(EUiViewName viewName)
		{
			UiManager.<CloseHistoryRingViewAsync>d__52 <CloseHistoryRingViewAsync>d__;
			<CloseHistoryRingViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseHistoryRingViewAsync>d__.<>4__this = this;
			<CloseHistoryRingViewAsync>d__.viewName = viewName;
			<CloseHistoryRingViewAsync>d__.<>1__state = -1;
			<CloseHistoryRingViewAsync>d__.<>t__builder.Start<UiManager.<CloseHistoryRingViewAsync>d__52>(ref <CloseHistoryRingViewAsync>d__);
			return <CloseHistoryRingViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023399 RID: 144281 RVA: 0x00A01F4B File Offset: 0x00A0014B
		private void ShowFloatTips()
		{
			UiModel.Instance.IsInMainView = true;
			((UiViewFloatContainer)this.Containers[ELayerType.Float]).ShowFloatTips();
			EventSystem.Instance.Emit(EEventName.ShowFloatTips);
		}

		// Token: 0x0602339A RID: 144282 RVA: 0x00A01F82 File Offset: 0x00A00182
		private void HideFloatTips()
		{
			UiModel.Instance.IsInMainView = false;
			((UiViewFloatContainer)this.Containers[ELayerType.Float]).HideFloatTips();
		}

		// Token: 0x0602339B RID: 144283 RVA: 0x00A01FAC File Offset: 0x00A001AC
		public void AddTickView(IPanelTickInterface view)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiManager;
			ELogAuthor author = ELogAuthor.TL;
			string message = "[AddTickView] 添加界面Tick";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", view.GetType().Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TickViewSet.Add(view);
		}

		// Token: 0x0602339C RID: 144284 RVA: 0x00A01FFC File Offset: 0x00A001FC
		public void RemoveTickView(IPanelTickInterface view)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiManager;
			ELogAuthor author = ELogAuthor.TL;
			string message = "[RemoveTickView] 移除界面Tick";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", view.GetType().Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TickViewSet.Remove(view);
		}

		// Token: 0x0602339D RID: 144285 RVA: 0x00A0204C File Offset: 0x00A0024C
		[NullableContext(2)]
		private UiViewBase RegisterView(EUiViewName name, object param = null, ELayerType? layer = null)
		{
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(name);
			if (uiViewInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "界面信息viewInfo获取失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (uiViewInfo != null)
			{
				uiViewInfo.SetContainerLayerType(layer);
			}
			UiViewBase uiViewBase = uiViewInfo.Ctor(uiViewInfo);
			if (uiViewBase is IUiViewResource)
			{
				UiConfig.Instance.RewritePath(uiViewInfo, uiViewBase as IUiViewResource, param);
			}
			if (uiViewBase is IExtraUiPopFrameType)
			{
				UiConfig.Instance.RewritePopFrameType(uiViewInfo, uiViewBase as IExtraUiPopFrameType, param);
			}
			uiViewBase.InitRootActorLoadInfo();
			if (uiViewInfo.CommonPopBg > (EUiBehaviourPopType)0)
			{
				UiPopFrameView uiPopFrameView = new UiPopFrameView(uiViewInfo);
				uiViewBase.ChildPopView = uiPopFrameView;
				uiViewBase.AddChild(uiPopFrameView);
			}
			this.AddView(uiViewBase);
			EventSystem.Instance.Emit<UiViewBase>(EEventName.CreateViewInstance, uiViewBase);
			return uiViewBase;
		}

		// Token: 0x0602339E RID: 144286 RVA: 0x00A02120 File Offset: 0x00A00320
		[NullableContext(2)]
		private UiViewBase PickViewByName(EUiViewName viewName)
		{
			HashSet<UiViewBase> valueOrDefault = this.NameToViewSetMap.GetValueOrDefault(viewName);
			if (valueOrDefault == null)
			{
				return null;
			}
			UiViewBase uiViewBase = null;
			foreach (UiViewBase uiViewBase2 in valueOrDefault)
			{
				if (uiViewBase == null || uiViewBase2.GetViewId() > uiViewBase.GetViewId())
				{
					uiViewBase = uiViewBase2;
				}
			}
			return uiViewBase;
		}

		// Token: 0x0602339F RID: 144287 RVA: 0x00A02190 File Offset: 0x00A00390
		private void StartFloatWaitingNormalView()
		{
			((UiViewFloatContainer)this.Containers[ELayerType.Float]).StartWaitingNormalView();
		}

		// Token: 0x060233A0 RID: 144288 RVA: 0x00A021AC File Offset: 0x00A003AC
		public UniTask Initialize()
		{
			UiManager.<Initialize>d__60 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UiManager.<Initialize>d__60>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x060233A1 RID: 144289 RVA: 0x00A021F0 File Offset: 0x00A003F0
		public void LockOpen()
		{
			LguiUtil.Instance.SetActorIsPermanent(UiLayer.Instance.UiRoot, true, true);
			this.OpenLock = true;
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "[UIManager.UnLockOpen] 禁止打开界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060233A2 RID: 144290 RVA: 0x00A0223C File Offset: 0x00A0043C
		public void UnLockOpen()
		{
			this.OpenLock = false;
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "[UIManager.UnLockOpen] 恢复打开界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x060233A3 RID: 144291 RVA: 0x00A0226F File Offset: 0x00A0046F
		public bool IsLockOpen
		{
			get
			{
				return this.OpenLock;
			}
		}

		// Token: 0x060233A4 RID: 144292 RVA: 0x00A02278 File Offset: 0x00A00478
		[NullableContext(2)]
		private unsafe bool CanOpenView(EUiViewName viewName, bool isMultipleView = false, object param = null)
		{
			if (GlobalData.IsSceneClearing && !UiConfig.Instance.CanOpenWhileClearSceneViewNameSet.Contains(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.TL;
				string message = "[CanOpenView] 退出场景清理时不允许打开UI界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (this.OpenLock)
			{
				Log.Instance.Warn(ELogModule.UiManager, ELogAuthor.TL, "全局锁定了界面打开!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiManager;
				ELogAuthor author2 = ELogAuthor.TL;
				string message2 = "界面信息viewInfo获取失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", viewName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!isMultipleView && (uiViewInfo.Type & ELayerType.Float) == (ELayerType)0)
			{
				if (this.IsViewOpen(viewName))
				{
					string item = "同名界面已经打开";
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.UiManager;
					ELogAuthor author3 = ELogAuthor.TL;
					string message3 = "[多开界面检查]打开界面失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", viewName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", item);
					instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
				if (this.IsViewCreating(viewName))
				{
					string item2 = "同名界面正在创建中";
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.UiManager;
					ELogAuthor author4 = ELogAuthor.TL;
					string message4 = "[多开界面检查]打开界面失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", viewName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("reason", item2);
					instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return false;
				}
			}
			return this.CheckOpenViewCheckFunctions(viewName, false, param) && this.CheckOpenViewCheckFunctions(viewName, true, param);
		}

		// Token: 0x060233A5 RID: 144293 RVA: 0x00A02448 File Offset: 0x00A00648
		public void AddOpenViewCheckFunction(EUiViewName viewName, Func<EUiViewName, object, bool> func, string reason)
		{
			Dictionary<Func<EUiViewName, object, bool>, string> dictionary;
			if (!this.OpenViewCheckFunctionsMap.TryGetValue(viewName, out dictionary))
			{
				dictionary = new Dictionary<Func<EUiViewName, object, bool>, string>();
				this.OpenViewCheckFunctionsMap[viewName] = dictionary;
			}
			dictionary[func] = reason;
		}

		// Token: 0x060233A6 RID: 144294 RVA: 0x00A02480 File Offset: 0x00A00680
		public void RemoveOpenViewCheckFunction(EUiViewName viewName, Func<EUiViewName, object, bool> func)
		{
			Dictionary<Func<EUiViewName, object, bool>, string> dictionary;
			if (!this.OpenViewCheckFunctionsMap.TryGetValue(viewName, out dictionary))
			{
				return;
			}
			dictionary.Remove(func);
		}

		// Token: 0x060233A7 RID: 144295 RVA: 0x00A024A8 File Offset: 0x00A006A8
		[NullableContext(2)]
		private unsafe bool CheckOpenViewCheckFunctions(EUiViewName viewName, bool isAll = false, object param = null)
		{
			Dictionary<Func<EUiViewName, object, bool>, string> dictionary;
			if (!this.OpenViewCheckFunctionsMap.TryGetValue(isAll ? EUiViewName.All : viewName, out dictionary) || dictionary.Count == 0)
			{
				return true;
			}
			foreach (KeyValuePair<Func<EUiViewName, object, bool>, string> keyValuePair in dictionary)
			{
				Func<EUiViewName, object, bool> key = keyValuePair.Key;
				string value = keyValuePair.Value;
				try
				{
					if (!key(viewName, param))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.UiManager;
						ELogAuthor author = ELogAuthor.TL;
						string message = "[自定义检查]打开界面失败";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", viewName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", value);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return false;
					}
				}
				catch (Exception item)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiManager;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "[自定义检查]检查函数抛出异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Exception", item);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					if (!isAll)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060233A8 RID: 144296 RVA: 0x00A025E0 File Offset: 0x00A007E0
		[NullableContext(2)]
		public UiViewBase GetViewByName(EUiViewName viewName)
		{
			return this.PickViewByName(viewName);
		}

		// Token: 0x060233A9 RID: 144297 RVA: 0x00A025EC File Offset: 0x00A007EC
		[NullableContext(2)]
		public UiViewBase GetView(int viewId)
		{
			UiViewBase result;
			this.IdToViewMap.TryGetValue(viewId, out result);
			return result;
		}

		// Token: 0x060233AA RID: 144298 RVA: 0x00A0260C File Offset: 0x00A0080C
		private void AddView(UiViewBase view)
		{
			int viewId = view.GetViewId();
			this.IdToViewMap[viewId] = view;
			EUiViewName name = view.ViewInfo.Name;
			this.NameToViewSetMap.TryAdd(name, new HashSet<UiViewBase>());
			HashSet<UiViewBase> hashSet;
			if (this.NameToViewSetMap.TryGetValue(name, out hashSet))
			{
				hashSet.Add(view);
			}
		}

		// Token: 0x060233AB RID: 144299 RVA: 0x00A02664 File Offset: 0x00A00864
		public void RemoveView(int viewId)
		{
			UiViewBase uiViewBase;
			if (!this.IdToViewMap.TryGetValue(viewId, out uiViewBase))
			{
				return;
			}
			EUiViewName name = uiViewBase.ViewInfo.Name;
			this.IdToViewMap.Remove(viewId);
			HashSet<UiViewBase> hashSet;
			if (this.NameToViewSetMap.TryGetValue(name, out hashSet))
			{
				hashSet.Remove(uiViewBase);
				if (hashSet.Count == 0)
				{
					this.NameToViewSetMap.Remove(name);
				}
			}
		}

		// Token: 0x060233AC RID: 144300 RVA: 0x00A026C8 File Offset: 0x00A008C8
		public void RefreshByPureModeChanged()
		{
			UiViewContainer uiViewContainer;
			this.Containers.TryGetValue(ELayerType.Float, out uiViewContainer);
			UiViewFloatContainer uiViewFloatContainer = uiViewContainer as UiViewFloatContainer;
			if (uiViewFloatContainer != null)
			{
				uiViewFloatContainer.RefreshByPureModeChanged();
			}
		}

		// Token: 0x060233AD RID: 144301 RVA: 0x00A026F8 File Offset: 0x00A008F8
		public void GmClearFloatContainer()
		{
			(this.Containers[ELayerType.Float] as UiViewFloatContainer).ClearContainer(false);
		}

		// Token: 0x060233AE RID: 144302 RVA: 0x00A02718 File Offset: 0x00A00918
		public void Tick(float delta)
		{
			float deltaTime = delta * Time.Instance.InverseSelfCenteredTimeDilation;
			foreach (IPanelTickInterface panelTickInterface in this.TickViewSet)
			{
				panelTickInterface.Tick(deltaTime);
			}
			UiActorPool.Instance.Tick(deltaTime);
		}

		// Token: 0x060233AF RID: 144303 RVA: 0x00A02784 File Offset: 0x00A00984
		public void AfterTick(float delta)
		{
			foreach (IPanelTickInterface panelTickInterface in this.TickViewSet)
			{
				panelTickInterface.AfterTick(delta);
			}
		}

		// Token: 0x060233B0 RID: 144304 RVA: 0x00A027D8 File Offset: 0x00A009D8
		public UniTask PauseNormalContainer(Func<UniTask> createPlotView, Func<UniTask> showPlotView)
		{
			UiManager.<PauseNormalContainer>d__78 <PauseNormalContainer>d__;
			<PauseNormalContainer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PauseNormalContainer>d__.<>4__this = this;
			<PauseNormalContainer>d__.createPlotView = createPlotView;
			<PauseNormalContainer>d__.showPlotView = showPlotView;
			<PauseNormalContainer>d__.<>1__state = -1;
			<PauseNormalContainer>d__.<>t__builder.Start<UiManager.<PauseNormalContainer>d__78>(ref <PauseNormalContainer>d__);
			return <PauseNormalContainer>d__.<>t__builder.Task;
		}

		// Token: 0x060233B1 RID: 144305 RVA: 0x00A0282C File Offset: 0x00A00A2C
		public UniTask ResumeNormalContainer(Func<UniTask> destroyOtherView = null)
		{
			UiManager.<ResumeNormalContainer>d__79 <ResumeNormalContainer>d__;
			<ResumeNormalContainer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeNormalContainer>d__.<>4__this = this;
			<ResumeNormalContainer>d__.destroyOtherView = destroyOtherView;
			<ResumeNormalContainer>d__.<>1__state = -1;
			<ResumeNormalContainer>d__.<>t__builder.Start<UiManager.<ResumeNormalContainer>d__79>(ref <ResumeNormalContainer>d__);
			return <ResumeNormalContainer>d__.<>t__builder.Task;
		}

		// Token: 0x060233B2 RID: 144306 RVA: 0x00A02878 File Offset: 0x00A00A78
		public void ResumeNormalContainerInClear()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.XXJ, "[UIManager.ClearAsync]ResumeNormalContainerInClear", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiTimeDilation.Instance.RestoreSaveData();
			UiLayer.Instance.SetLayerActive(ELayerType.Normal, true);
			((UiViewStackContainer)this.Containers[ELayerType.Normal]).TryUnlock();
		}

		// Token: 0x060233B3 RID: 144307 RVA: 0x00A028D0 File Offset: 0x00A00AD0
		public bool CheckIfCanShowPlotView()
		{
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
			if (topView != null)
			{
				EUiViewName name = topView.ViewInfo.Name;
				return UiModel.Instance.CanShowPlotViewWhiteList.Contains(name) && this.IsViewShow(name);
			}
			return false;
		}

		// Token: 0x060233B4 RID: 144308 RVA: 0x00A02915 File Offset: 0x00A00B15
		public bool IsNormalContainerEmpty()
		{
			return ((UiViewStackContainer)this.Containers[ELayerType.Normal]).IsViewPendingListEmpty();
		}

		// Token: 0x060233B5 RID: 144309 RVA: 0x00A0292D File Offset: 0x00A00B2D
		public void CloseAllPopView()
		{
			((UiViewListContainer)this.Containers[ELayerType.Pop]).CloseAllView();
		}

		// Token: 0x060233B6 RID: 144310 RVA: 0x00A02946 File Offset: 0x00A00B46
		public UniTask ContinueNormalContainer(Func<UniTask> destroyOtherView = null)
		{
			return this.ResumeNormalContainer(destroyOtherView);
		}

		// Token: 0x060233B7 RID: 144311 RVA: 0x00A02950 File Offset: 0x00A00B50
		private UniTask ClearNonNormalAndPlotContainerView(bool isSeamlessTravel)
		{
			UiManager.<ClearNonNormalAndPlotContainerView>d__85 <ClearNonNormalAndPlotContainerView>d__;
			<ClearNonNormalAndPlotContainerView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearNonNormalAndPlotContainerView>d__.<>4__this = this;
			<ClearNonNormalAndPlotContainerView>d__.isSeamlessTravel = isSeamlessTravel;
			<ClearNonNormalAndPlotContainerView>d__.<>1__state = -1;
			<ClearNonNormalAndPlotContainerView>d__.<>t__builder.Start<UiManager.<ClearNonNormalAndPlotContainerView>d__85>(ref <ClearNonNormalAndPlotContainerView>d__);
			return <ClearNonNormalAndPlotContainerView>d__.<>t__builder.Task;
		}

		// Token: 0x060233B8 RID: 144312 RVA: 0x00A0299C File Offset: 0x00A00B9C
		private UniTask ClearNormalAndPlotContainerView(bool isSeamlessTravel)
		{
			UiManager.<ClearNormalAndPlotContainerView>d__86 <ClearNormalAndPlotContainerView>d__;
			<ClearNormalAndPlotContainerView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearNormalAndPlotContainerView>d__.<>4__this = this;
			<ClearNormalAndPlotContainerView>d__.isSeamlessTravel = isSeamlessTravel;
			<ClearNormalAndPlotContainerView>d__.<>1__state = -1;
			<ClearNormalAndPlotContainerView>d__.<>t__builder.Start<UiManager.<ClearNormalAndPlotContainerView>d__86>(ref <ClearNormalAndPlotContainerView>d__);
			return <ClearNormalAndPlotContainerView>d__.<>t__builder.Task;
		}

		// Token: 0x060233B9 RID: 144313 RVA: 0x00A029E8 File Offset: 0x00A00BE8
		private UniTask ResumeNormalViewInClear(bool isSeamlessTravel)
		{
			UiManager.<ResumeNormalViewInClear>d__87 <ResumeNormalViewInClear>d__;
			<ResumeNormalViewInClear>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeNormalViewInClear>d__.<>4__this = this;
			<ResumeNormalViewInClear>d__.isSeamlessTravel = isSeamlessTravel;
			<ResumeNormalViewInClear>d__.<>1__state = -1;
			<ResumeNormalViewInClear>d__.<>t__builder.Start<UiManager.<ResumeNormalViewInClear>d__87>(ref <ResumeNormalViewInClear>d__);
			return <ResumeNormalViewInClear>d__.<>t__builder.Task;
		}

		// Token: 0x060233BA RID: 144314 RVA: 0x00A02A34 File Offset: 0x00A00C34
		private void ClearUiCameraAnimation()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.XXJ, "[UIManager.ClearAsync] ClearUiCameraAnimation", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				UiCameraModel.Instance.ClearDisplay();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Game;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "[Game.LeaveLevel] 调用UiCameraModel.ClearDisplay异常。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Exception", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060233BB RID: 144315 RVA: 0x00A02AA8 File Offset: 0x00A00CA8
		public UniTask ClearAsync(bool isSeamlessTravel)
		{
			UiManager.<ClearAsync>d__89 <ClearAsync>d__;
			<ClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAsync>d__.<>4__this = this;
			<ClearAsync>d__.isSeamlessTravel = isSeamlessTravel;
			<ClearAsync>d__.<>1__state = -1;
			<ClearAsync>d__.<>t__builder.Start<UiManager.<ClearAsync>d__89>(ref <ClearAsync>d__);
			return <ClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x060233BC RID: 144316 RVA: 0x00A02AF3 File Offset: 0x00A00CF3
		public static UiManager Instance
		{
			get
			{
				if (UiManager._instance == null)
				{
					UiManager._instance = new UiManager();
					UiManager._instance.OnInit();
				}
				return UiManager._instance;
			}
		}

		// Token: 0x060233BD RID: 144317 RVA: 0x00A02B16 File Offset: 0x00A00D16
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060233BE RID: 144318 RVA: 0x00A02B18 File Offset: 0x00A00D18
		public static void ResetStaticDefaultValue()
		{
			UiManager instance = UiManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiManager._instance = null;
		}

		// Token: 0x060233BF RID: 144319 RVA: 0x00A02B31 File Offset: 0x00A00D31
		static UiManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiManager.CreateStaticDefaultValue), new Action(UiManager.ResetStaticDefaultValue));
		}

		// Token: 0x04013DCF RID: 81359
		private EInitState InitState;

		// Token: 0x04013DD0 RID: 81360
		public bool IsClear;

		// Token: 0x04013DD1 RID: 81361
		private readonly Dictionary<ELayerType, UiViewContainer> Containers = new Dictionary<ELayerType, UiViewContainer>();

		// Token: 0x04013DD2 RID: 81362
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})]
		private readonly Dictionary<EUiViewName, Dictionary<Func<EUiViewName, object, bool>, string>> OpenViewCheckFunctionsMap = new Dictionary<EUiViewName, Dictionary<Func<EUiViewName, object, bool>, string>>();

		// Token: 0x04013DD3 RID: 81363
		private readonly Stat StatsObject = Stat.Create("UiManger", "", "");

		// Token: 0x04013DD4 RID: 81364
		private readonly Dictionary<int, UiViewBase> IdToViewMap = new Dictionary<int, UiViewBase>();

		// Token: 0x04013DD5 RID: 81365
		private readonly Dictionary<EUiViewName, HashSet<UiViewBase>> NameToViewSetMap = new Dictionary<EUiViewName, HashSet<UiViewBase>>();

		// Token: 0x04013DD6 RID: 81366
		private readonly OrderedSet<IPanelTickInterface> TickViewSet = new OrderedSet<IPanelTickInterface>();

		// Token: 0x04013DD7 RID: 81367
		private readonly Dictionary<int, UiViewBase> PreOpeningViewMap = new Dictionary<int, UiViewBase>();

		// Token: 0x04013DD8 RID: 81368
		private EUiViewName? LastNormalTopViewName;

		// Token: 0x04013DD9 RID: 81369
		private int CsRequestId;

		// Token: 0x04013DDA RID: 81370
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Dictionary<int, object> CsRequestParamMap = new Dictionary<int, object>();

		// Token: 0x04013DDB RID: 81371
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Dictionary<int, TOpenViewCallBack> CsRequestCallbackMap = new Dictionary<int, TOpenViewCallBack>();

		// Token: 0x04013DDC RID: 81372
		private Dictionary<int, bool> CsRequestNeedOpenInSharpMap = new Dictionary<int, bool>();

		// Token: 0x04013DDD RID: 81373
		private bool OpenLock;

		// Token: 0x04013DDE RID: 81374
		[Nullable(2)]
		private static UiManager _instance;
	}
}
