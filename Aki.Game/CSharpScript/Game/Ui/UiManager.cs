using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046D3 RID: 18131
	[NullableContext(1)]
	[Nullable(0)]
	public class UiManager : Singleton, ITickable
	{
		// Token: 0x1700767C RID: 30332
		// (get) Token: 0x0602EC39 RID: 191545 RVA: 0x00AD2FA6 File Offset: 0x00AD11A6
		public bool IsInited
		{
			get
			{
				return this.InitState == EInitState.Inited;
			}
		}

		// Token: 0x0602EC3A RID: 191546 RVA: 0x00AD2FB1 File Offset: 0x00AD11B1
		public IReadOnlyDictionary<EUiViewName, HashSet<UiViewBase>> GetNameToViewSetMap()
		{
			return this.NameToViewSetMap;
		}

		// Token: 0x0602EC3B RID: 191547 RVA: 0x00AD2FBC File Offset: 0x00AD11BC
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

		// Token: 0x0602EC3C RID: 191548 RVA: 0x00AD3024 File Offset: 0x00AD1224
		[NullableContext(2)]
		public void OpenView(EUiViewName name, object param = null, TOpenViewCallBack finishCallback = null)
		{
			this.OpenViewPrivate(name, param, null, finishCallback);
		}

		// Token: 0x0602EC3D RID: 191549 RVA: 0x00AD3043 File Offset: 0x00AD1243
		[NullableContext(2)]
		public void OpenViewWithLayer(EUiViewName name, ELayerType layerType, object param = null, TOpenViewCallBack finishCallback = null)
		{
			this.OpenViewPrivate(name, param, new ELayerType?(layerType), finishCallback);
		}

		// Token: 0x0602EC3E RID: 191550 RVA: 0x00AD3055 File Offset: 0x00AD1255
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

		// Token: 0x0602EC3F RID: 191551 RVA: 0x00AD3084 File Offset: 0x00AD1284
		[NullableContext(0)]
		public UniTask<int?> OpenViewAsync(EUiViewName name, [Nullable(2)] object param = null, ELayerType? layerType = null)
		{
			UiManager.<OpenViewAsync>d__21 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.name = name;
			<OpenViewAsync>d__.param = param;
			<OpenViewAsync>d__.layerType = layerType;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiManager.<OpenViewAsync>d__21>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC40 RID: 191552 RVA: 0x00AD30E0 File Offset: 0x00AD12E0
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

		// Token: 0x0602EC41 RID: 191553 RVA: 0x00AD3130 File Offset: 0x00AD1330
		[NullableContext(0)]
		public UniTask<bool> CloseViewAsync(EUiViewName name)
		{
			UiManager.<CloseViewAsync>d__23 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.name = name;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiManager.<CloseViewAsync>d__23>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC42 RID: 191554 RVA: 0x00AD317C File Offset: 0x00AD137C
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

		// Token: 0x0602EC43 RID: 191555 RVA: 0x00AD31CC File Offset: 0x00AD13CC
		[NullableContext(0)]
		public UniTask<bool> CloseViewByIdAsync(int viewId)
		{
			UiManager.<CloseViewByIdAsync>d__25 <CloseViewByIdAsync>d__;
			<CloseViewByIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewByIdAsync>d__.<>4__this = this;
			<CloseViewByIdAsync>d__.viewId = viewId;
			<CloseViewByIdAsync>d__.<>1__state = -1;
			<CloseViewByIdAsync>d__.<>t__builder.Start<UiManager.<CloseViewByIdAsync>d__25>(ref <CloseViewByIdAsync>d__);
			return <CloseViewByIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC44 RID: 191556 RVA: 0x00AD3218 File Offset: 0x00AD1418
		[NullableContext(0)]
		public UniTask<bool> CloseViewImplementAsync([Nullable(1)] UiViewBase view, bool fromCloseMe = false)
		{
			UiManager.<CloseViewImplementAsync>d__26 <CloseViewImplementAsync>d__;
			<CloseViewImplementAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewImplementAsync>d__.<>4__this = this;
			<CloseViewImplementAsync>d__.view = view;
			<CloseViewImplementAsync>d__.<>1__state = -1;
			<CloseViewImplementAsync>d__.<>t__builder.Start<UiManager.<CloseViewImplementAsync>d__26>(ref <CloseViewImplementAsync>d__);
			return <CloseViewImplementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC45 RID: 191557 RVA: 0x00AD3264 File Offset: 0x00AD1464
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

		// Token: 0x0602EC46 RID: 191558 RVA: 0x00AD32C8 File Offset: 0x00AD14C8
		[NullableContext(0)]
		public UniTask<bool> CloseAndOpenViewAsync(EUiViewName closeViewName, EUiViewName openViewName, [Nullable(2)] object param, bool callJs = true)
		{
			UiManager.<CloseAndOpenViewAsync>d__28 <CloseAndOpenViewAsync>d__;
			<CloseAndOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseAndOpenViewAsync>d__.<>4__this = this;
			<CloseAndOpenViewAsync>d__.closeViewName = closeViewName;
			<CloseAndOpenViewAsync>d__.openViewName = openViewName;
			<CloseAndOpenViewAsync>d__.param = param;
			<CloseAndOpenViewAsync>d__.callJs = callJs;
			<CloseAndOpenViewAsync>d__.<>1__state = -1;
			<CloseAndOpenViewAsync>d__.<>t__builder.Start<UiManager.<CloseAndOpenViewAsync>d__28>(ref <CloseAndOpenViewAsync>d__);
			return <CloseAndOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC47 RID: 191559 RVA: 0x00AD332C File Offset: 0x00AD152C
		[NullableContext(0)]
		public UniTask<int?> PreOpenViewAsync(EUiViewName name, bool callJs = false)
		{
			UiManager.<PreOpenViewAsync>d__29 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<PreOpenViewAsync>d__.<>4__this = this;
			<PreOpenViewAsync>d__.name = name;
			<PreOpenViewAsync>d__.callJs = callJs;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiManager.<PreOpenViewAsync>d__29>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC48 RID: 191560 RVA: 0x00AD3380 File Offset: 0x00AD1580
		[NullableContext(0)]
		public UniTask<bool> OpenViewAfterPreOpenedAsync(int viewId, [Nullable(2)] object param = null, bool callJs = true)
		{
			UiManager.<OpenViewAfterPreOpenedAsync>d__30 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAfterPreOpenedAsync>d__.<>4__this = this;
			<OpenViewAfterPreOpenedAsync>d__.viewId = viewId;
			<OpenViewAfterPreOpenedAsync>d__.param = param;
			<OpenViewAfterPreOpenedAsync>d__.callJs = callJs;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiManager.<OpenViewAfterPreOpenedAsync>d__30>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC49 RID: 191561 RVA: 0x00AD33DB File Offset: 0x00AD15DB
		public void RemovePreOpenView(int viewId)
		{
			this.PreOpeningViewMap.Remove(viewId);
		}

		// Token: 0x0602EC4A RID: 191562 RVA: 0x00AD33EC File Offset: 0x00AD15EC
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

		// Token: 0x0602EC4B RID: 191563 RVA: 0x00AD3504 File Offset: 0x00AD1704
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

		// Token: 0x0602EC4C RID: 191564 RVA: 0x00AD3578 File Offset: 0x00AD1778
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

		// Token: 0x0602EC4D RID: 191565 RVA: 0x00AD3600 File Offset: 0x00AD1800
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

		// Token: 0x0602EC4E RID: 191566 RVA: 0x00AD3668 File Offset: 0x00AD1868
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

		// Token: 0x0602EC4F RID: 191567 RVA: 0x00AD36D0 File Offset: 0x00AD18D0
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

		// Token: 0x0602EC50 RID: 191568 RVA: 0x00AD3738 File Offset: 0x00AD1938
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
			if (!Info.Instance.IsBuildShipping)
			{
				this.Containers[ELayerType.Debug] = new UiViewSetContainer(UiModel.Instance.DebugMap);
			}
		}

		// Token: 0x0602EC51 RID: 191569 RVA: 0x00AD388C File Offset: 0x00AD1A8C
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ExitNormalQueueState, new Action(this.ExitNormalQueueState));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.ShowFloatTips));
			EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.HideFloatTips));
			EventSystem.Instance.Add(EEventName.StackOpenView, new Action<int, UiViewInfo>(this.OnStackOpenView));
			EventSystem.Instance.Add(EEventName.StackCloseView, new Action<int, EUiViewName, UiViewInfo>(this.OnStackCloseView));
		}

		// Token: 0x0602EC52 RID: 191570 RVA: 0x00AD391E File Offset: 0x00AD1B1E
		[NullableContext(2)]
		private void OnStackOpenView(int viewId, UiViewInfo lastView)
		{
			this.CheckAndEmitNormalTopViewChange();
		}

		// Token: 0x0602EC53 RID: 191571 RVA: 0x00AD3926 File Offset: 0x00AD1B26
		[NullableContext(2)]
		private void OnStackCloseView(int viewId, EUiViewName viewName, UiViewInfo stackTopInfo)
		{
			this.CheckAndEmitNormalTopViewChange();
		}

		// Token: 0x0602EC54 RID: 191572 RVA: 0x00AD3930 File Offset: 0x00AD1B30
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

		// Token: 0x0602EC55 RID: 191573 RVA: 0x00AD39DC File Offset: 0x00AD1BDC
		private void ResetToBattleViewForEvent()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "重置回到主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			((UiViewListContainer)this.Containers[ELayerType.Pop]).CloseAllView();
			this.NormalResetToView(EUiViewName.BattleView, null, true);
		}

		// Token: 0x0602EC56 RID: 191574 RVA: 0x00AD3A2C File Offset: 0x00AD1C2C
		private void ExitNormalQueueState()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "退出队列状态,重置回到主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StartFloatWaitingNormalView();
		}

		// Token: 0x0602EC57 RID: 191575 RVA: 0x00AD3A60 File Offset: 0x00AD1C60
		[NullableContext(2)]
		public void ResetToBattleView(Action<bool> callback = null)
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "重置回到主界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			((UiViewListContainer)this.Containers[ELayerType.Pop]).CloseAllView();
			this.NormalResetToView(UiModel.Instance.MainViewName, callback, true);
			EventSystem.Instance.Emit(EEventName.OnResetToBattleView);
		}

		// Token: 0x0602EC58 RID: 191576 RVA: 0x00AD3AC8 File Offset: 0x00AD1CC8
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

		// Token: 0x0602EC59 RID: 191577 RVA: 0x00AD3B1C File Offset: 0x00AD1D1C
		public UniTask NormalResetToViewAsync(EUiViewName viewName, bool callJs = true)
		{
			UiManager.<NormalResetToViewAsync>d__47 <NormalResetToViewAsync>d__;
			<NormalResetToViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NormalResetToViewAsync>d__.<>4__this = this;
			<NormalResetToViewAsync>d__.viewName = viewName;
			<NormalResetToViewAsync>d__.callJs = callJs;
			<NormalResetToViewAsync>d__.<>1__state = -1;
			<NormalResetToViewAsync>d__.<>t__builder.Start<UiManager.<NormalResetToViewAsync>d__47>(ref <NormalResetToViewAsync>d__);
			return <NormalResetToViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC5A RID: 191578 RVA: 0x00AD3B70 File Offset: 0x00AD1D70
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

		// Token: 0x0602EC5B RID: 191579 RVA: 0x00AD3BC0 File Offset: 0x00AD1DC0
		public UniTask CloseHistoryRingViewAsync(EUiViewName viewName)
		{
			UiManager.<CloseHistoryRingViewAsync>d__49 <CloseHistoryRingViewAsync>d__;
			<CloseHistoryRingViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseHistoryRingViewAsync>d__.<>4__this = this;
			<CloseHistoryRingViewAsync>d__.viewName = viewName;
			<CloseHistoryRingViewAsync>d__.<>1__state = -1;
			<CloseHistoryRingViewAsync>d__.<>t__builder.Start<UiManager.<CloseHistoryRingViewAsync>d__49>(ref <CloseHistoryRingViewAsync>d__);
			return <CloseHistoryRingViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC5C RID: 191580 RVA: 0x00AD3C0B File Offset: 0x00AD1E0B
		private void ShowFloatTips()
		{
			UiModel.Instance.IsInMainView = true;
			((UiViewFloatContainer)this.Containers[ELayerType.Float]).ShowFloatTips();
			EventSystem.Instance.Emit(EEventName.ShowFloatTips);
		}

		// Token: 0x0602EC5D RID: 191581 RVA: 0x00AD3C42 File Offset: 0x00AD1E42
		private void HideFloatTips()
		{
			UiModel.Instance.IsInMainView = false;
			((UiViewFloatContainer)this.Containers[ELayerType.Float]).HideFloatTips();
		}

		// Token: 0x0602EC5E RID: 191582 RVA: 0x00AD3C6C File Offset: 0x00AD1E6C
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

		// Token: 0x0602EC5F RID: 191583 RVA: 0x00AD3CBC File Offset: 0x00AD1EBC
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

		// Token: 0x0602EC60 RID: 191584 RVA: 0x00AD3D0C File Offset: 0x00AD1F0C
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

		// Token: 0x0602EC61 RID: 191585 RVA: 0x00AD3DE0 File Offset: 0x00AD1FE0
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

		// Token: 0x0602EC62 RID: 191586 RVA: 0x00AD3E50 File Offset: 0x00AD2050
		private void StartFloatWaitingNormalView()
		{
			((UiViewFloatContainer)this.Containers[ELayerType.Float]).StartWaitingNormalView();
		}

		// Token: 0x0602EC63 RID: 191587 RVA: 0x00AD3E6C File Offset: 0x00AD206C
		public UniTask Initialize()
		{
			UiManager.<Initialize>d__57 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UiManager.<Initialize>d__57>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC64 RID: 191588 RVA: 0x00AD3EB0 File Offset: 0x00AD20B0
		public void LockOpen()
		{
			LguiUtil.Instance.SetActorIsPermanent(UiLayer.Instance.UiRoot, true, true);
			this.OpenLock = true;
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "[UIManager.UnLockOpen] 禁止打开界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602EC65 RID: 191589 RVA: 0x00AD3EFC File Offset: 0x00AD20FC
		public void UnLockOpen()
		{
			this.OpenLock = false;
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.TL, "[UIManager.UnLockOpen] 恢复打开界面", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x1700767D RID: 30333
		// (get) Token: 0x0602EC66 RID: 191590 RVA: 0x00AD3F2F File Offset: 0x00AD212F
		public bool IsLockOpen
		{
			get
			{
				return this.OpenLock;
			}
		}

		// Token: 0x0602EC67 RID: 191591 RVA: 0x00AD3F38 File Offset: 0x00AD2138
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

		// Token: 0x0602EC68 RID: 191592 RVA: 0x00AD4108 File Offset: 0x00AD2308
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

		// Token: 0x0602EC69 RID: 191593 RVA: 0x00AD4140 File Offset: 0x00AD2340
		public void RemoveOpenViewCheckFunction(EUiViewName viewName, Func<EUiViewName, object, bool> func)
		{
			Dictionary<Func<EUiViewName, object, bool>, string> dictionary;
			if (!this.OpenViewCheckFunctionsMap.TryGetValue(viewName, out dictionary))
			{
				return;
			}
			dictionary.Remove(func);
		}

		// Token: 0x0602EC6A RID: 191594 RVA: 0x00AD4168 File Offset: 0x00AD2368
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

		// Token: 0x0602EC6B RID: 191595 RVA: 0x00AD42A0 File Offset: 0x00AD24A0
		[NullableContext(2)]
		public UiViewBase GetViewByName(EUiViewName viewName)
		{
			return this.PickViewByName(viewName);
		}

		// Token: 0x0602EC6C RID: 191596 RVA: 0x00AD42AC File Offset: 0x00AD24AC
		[NullableContext(2)]
		public UiViewBase GetView(int viewId)
		{
			UiViewBase result;
			this.IdToViewMap.TryGetValue(viewId, out result);
			return result;
		}

		// Token: 0x0602EC6D RID: 191597 RVA: 0x00AD42CC File Offset: 0x00AD24CC
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

		// Token: 0x0602EC6E RID: 191598 RVA: 0x00AD4324 File Offset: 0x00AD2524
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

		// Token: 0x0602EC6F RID: 191599 RVA: 0x00AD4388 File Offset: 0x00AD2588
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

		// Token: 0x0602EC70 RID: 191600 RVA: 0x00AD43B8 File Offset: 0x00AD25B8
		public void GmClearFloatContainer()
		{
			(this.Containers[ELayerType.Float] as UiViewFloatContainer).ClearContainer(false);
		}

		// Token: 0x0602EC71 RID: 191601 RVA: 0x00AD43D8 File Offset: 0x00AD25D8
		public void Tick(float delta)
		{
			float deltaTime = delta * Time.Instance.InverseSelfCenteredTimeDilation;
			this.TempTickView.Clear();
			this.TempTickView.AddRange(this.TickViewSet);
			foreach (IPanelTickInterface panelTickInterface in this.TempTickView)
			{
				panelTickInterface.Tick(deltaTime);
			}
			UiActorPool.Instance.Tick(deltaTime);
		}

		// Token: 0x0602EC72 RID: 191602 RVA: 0x00AD4460 File Offset: 0x00AD2660
		public void AfterTick(float delta)
		{
			foreach (IPanelTickInterface panelTickInterface in this.TickViewSet)
			{
				panelTickInterface.AfterTick(delta);
			}
		}

		// Token: 0x0602EC73 RID: 191603 RVA: 0x00AD44B4 File Offset: 0x00AD26B4
		public UniTask PauseNormalContainer(Func<UniTask> createPlotView, Func<UniTask> showPlotView)
		{
			UiManager.<PauseNormalContainer>d__76 <PauseNormalContainer>d__;
			<PauseNormalContainer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PauseNormalContainer>d__.<>4__this = this;
			<PauseNormalContainer>d__.createPlotView = createPlotView;
			<PauseNormalContainer>d__.showPlotView = showPlotView;
			<PauseNormalContainer>d__.<>1__state = -1;
			<PauseNormalContainer>d__.<>t__builder.Start<UiManager.<PauseNormalContainer>d__76>(ref <PauseNormalContainer>d__);
			return <PauseNormalContainer>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC74 RID: 191604 RVA: 0x00AD4508 File Offset: 0x00AD2708
		public UniTask ResumeNormalContainer(Func<UniTask> destroyOtherView = null)
		{
			UiManager.<ResumeNormalContainer>d__77 <ResumeNormalContainer>d__;
			<ResumeNormalContainer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeNormalContainer>d__.<>4__this = this;
			<ResumeNormalContainer>d__.destroyOtherView = destroyOtherView;
			<ResumeNormalContainer>d__.<>1__state = -1;
			<ResumeNormalContainer>d__.<>t__builder.Start<UiManager.<ResumeNormalContainer>d__77>(ref <ResumeNormalContainer>d__);
			return <ResumeNormalContainer>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC75 RID: 191605 RVA: 0x00AD4554 File Offset: 0x00AD2754
		public void ResumeNormalContainerInClear()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.XXJ, "[UIManager.ClearAsync]ResumeNormalContainerInClear", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiTimeDilation.Instance.RestoreSaveData();
			UiLayer.Instance.SetLayerActive(ELayerType.Normal, true);
			((UiViewStackContainer)this.Containers[ELayerType.Normal]).TryUnlock();
		}

		// Token: 0x0602EC76 RID: 191606 RVA: 0x00AD45AC File Offset: 0x00AD27AC
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

		// Token: 0x0602EC77 RID: 191607 RVA: 0x00AD45F1 File Offset: 0x00AD27F1
		public bool IsNormalContainerEmpty()
		{
			return ((UiViewStackContainer)this.Containers[ELayerType.Normal]).IsViewPendingListEmpty();
		}

		// Token: 0x0602EC78 RID: 191608 RVA: 0x00AD4609 File Offset: 0x00AD2809
		public void CloseAllPopView()
		{
			((UiViewListContainer)this.Containers[ELayerType.Pop]).CloseAllView();
		}

		// Token: 0x0602EC79 RID: 191609 RVA: 0x00AD4622 File Offset: 0x00AD2822
		public UniTask ContinueNormalContainer(Func<UniTask> destroyOtherView = null)
		{
			return this.ResumeNormalContainer(destroyOtherView);
		}

		// Token: 0x0602EC7A RID: 191610 RVA: 0x00AD462C File Offset: 0x00AD282C
		private UniTask ClearNonNormalAndPlotContainerView(bool isSeamlessTravel)
		{
			UiManager.<ClearNonNormalAndPlotContainerView>d__83 <ClearNonNormalAndPlotContainerView>d__;
			<ClearNonNormalAndPlotContainerView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearNonNormalAndPlotContainerView>d__.<>4__this = this;
			<ClearNonNormalAndPlotContainerView>d__.isSeamlessTravel = isSeamlessTravel;
			<ClearNonNormalAndPlotContainerView>d__.<>1__state = -1;
			<ClearNonNormalAndPlotContainerView>d__.<>t__builder.Start<UiManager.<ClearNonNormalAndPlotContainerView>d__83>(ref <ClearNonNormalAndPlotContainerView>d__);
			return <ClearNonNormalAndPlotContainerView>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC7B RID: 191611 RVA: 0x00AD4678 File Offset: 0x00AD2878
		private UniTask ClearNormalAndPlotContainerView(bool isSeamlessTravel)
		{
			UiManager.<ClearNormalAndPlotContainerView>d__84 <ClearNormalAndPlotContainerView>d__;
			<ClearNormalAndPlotContainerView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearNormalAndPlotContainerView>d__.<>4__this = this;
			<ClearNormalAndPlotContainerView>d__.isSeamlessTravel = isSeamlessTravel;
			<ClearNormalAndPlotContainerView>d__.<>1__state = -1;
			<ClearNormalAndPlotContainerView>d__.<>t__builder.Start<UiManager.<ClearNormalAndPlotContainerView>d__84>(ref <ClearNormalAndPlotContainerView>d__);
			return <ClearNormalAndPlotContainerView>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC7C RID: 191612 RVA: 0x00AD46C4 File Offset: 0x00AD28C4
		private UniTask ResumeNormalViewInClear(bool isSeamlessTravel)
		{
			UiManager.<ResumeNormalViewInClear>d__85 <ResumeNormalViewInClear>d__;
			<ResumeNormalViewInClear>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeNormalViewInClear>d__.<>4__this = this;
			<ResumeNormalViewInClear>d__.isSeamlessTravel = isSeamlessTravel;
			<ResumeNormalViewInClear>d__.<>1__state = -1;
			<ResumeNormalViewInClear>d__.<>t__builder.Start<UiManager.<ResumeNormalViewInClear>d__85>(ref <ResumeNormalViewInClear>d__);
			return <ResumeNormalViewInClear>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC7D RID: 191613 RVA: 0x00AD4710 File Offset: 0x00AD2910
		private void ClearUiCameraAnimation()
		{
			Log.Instance.Info(ELogModule.UiManager, ELogAuthor.XXJ, "[UIManager.ClearAsync] ClearUiCameraAnimation", default(ReadOnlySpan<ValueTuple<string, object>>));
			try
			{
				UiCameraAnimationManager.Instance.ClearDisplay();
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Game;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "[Game.LeaveLevel] 调用UiCameraAnimationManager.ResetUiCameraAnimationManager异常。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Exception", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602EC7E RID: 191614 RVA: 0x00AD4784 File Offset: 0x00AD2984
		public UniTask ClearAsync(bool isSeamlessTravel)
		{
			UiManager.<ClearAsync>d__87 <ClearAsync>d__;
			<ClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAsync>d__.<>4__this = this;
			<ClearAsync>d__.isSeamlessTravel = isSeamlessTravel;
			<ClearAsync>d__.<>1__state = -1;
			<ClearAsync>d__.<>t__builder.Start<UiManager.<ClearAsync>d__87>(ref <ClearAsync>d__);
			return <ClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC7F RID: 191615 RVA: 0x00AD47D0 File Offset: 0x00AD29D0
		public unsafe void CheckUiPanelBindValid()
		{
			List<Type> list = (from t in Assembly.GetExecutingAssembly().GetTypes()
			where t.IsSubclassOf(typeof(UiPanelBase))
			where !t.IsAbstract
			where !t.ContainsGenericParameters
			select t).ToList<Type>();
			MethodInfo method = typeof(UiPanelBase).GetMethod("OnRegisterComponent", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field = typeof(UiPanelBase).GetField("ComponentRegisterInfos", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(UiPanelBase).GetField("BtnBindInfo", BindingFlags.Instance | BindingFlags.NonPublic);
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(EUiViewName.AdviceView);
			if (method == null || field == null || field2 == null)
			{
				Log.Instance.Error(ELogModule.UiManager, ELogAuthor.BB, "[UIManager.CheckUiPanelBindValid] 检查UI面板绑定是否有效失败，未找到OnRegisterComponent方法或ComponentRegisterInfos字段或BtnBindInfo字段", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (Type type in list)
			{
				try
				{
					UiPanelBase uiPanelBase = null;
					if (type.IsSubclassOf(typeof(UiViewBase)))
					{
						uiPanelBase = (UiPanelBase)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[]
						{
							uiViewInfo
						}, null);
					}
					else
					{
						ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
						if (constructors.Length == 0)
						{
							Log.Instance.Error(ELogModule.UiManager, ELogAuthor.BB, "[UIManager.CheckUiPanelBindValid] 检查UI面板绑定是否有效失败，类型" + type.Name + "未找到无参构造函数", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						ConstructorInfo[] array = constructors;
						for (int i = 0; i < array.Length; i++)
						{
							ParameterInfo[] parameters = array[i].GetParameters();
							if (parameters.Length == 0)
							{
								uiPanelBase = (UiPanelBase)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
								break;
							}
							if (parameters.Length == 1)
							{
								if (parameters[0].ParameterType == typeof(int))
								{
									uiPanelBase = (UiPanelBase)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[]
									{
										0
									}, null);
									break;
								}
								if (parameters[0].ParameterType == typeof(UUIItem))
								{
									uiPanelBase = (UiPanelBase)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[]
									{
										UiLayer.Instance.UiRootItem
									}, null);
									break;
								}
								if (parameters[0].ParameterType == typeof(AActor))
								{
									uiPanelBase = (UiPanelBase)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[]
									{
										UiLayer.Instance.UiRoot
									}, null);
									break;
								}
							}
							else
							{
								string value = string.Join(", ", from p in parameters
								select p.ParameterType.Name + " " + p.Name);
								Log instance = Log.Instance;
								ELogModule module = ELogModule.UiManager;
								ELogAuthor author = ELogAuthor.BB;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
								defaultInterpolatedStringHandler.AppendLiteral("[CheckUiPanelBindValidLog] 构造函数参数不匹配，类型");
								defaultInterpolatedStringHandler.AppendFormatted(type.Name);
								defaultInterpolatedStringHandler.AppendLiteral(" 构造函数(");
								defaultInterpolatedStringHandler.AppendFormatted(value);
								defaultInterpolatedStringHandler.AppendLiteral(")");
								instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
							}
						}
					}
					if (uiPanelBase != null)
					{
						method.Invoke(uiPanelBase, null);
						List<ValueTuple<int, Type>> list2 = (List<ValueTuple<int, Type>>)field.GetValue(uiPanelBase);
						foreach (ValueTuple<int, Delegate> valueTuple in ((List<ValueTuple<int, Delegate>>)field2.GetValue(uiPanelBase)))
						{
							int item = valueTuple.Item1;
							Delegate item2 = valueTuple.Item2;
							Type left = typeof(UUIButtonComponent);
							foreach (ValueTuple<int, Type> valueTuple2 in list2)
							{
								if (valueTuple2.Item1 == item)
								{
									left = valueTuple2.Item2;
									break;
								}
							}
							if (left == typeof(UUIButtonComponent))
							{
								this.CheckUiButtonBindValid(item2, item, typeof(void), uiPanelBase);
							}
							else if (left == typeof(UUIToggleComponent))
							{
								this.CheckOneParamDelegateBindValid(item2, item, typeof(bool), uiPanelBase);
							}
							else if (left == typeof(UUIExtendToggle))
							{
								this.CheckOneParamDelegateBindValid(item2, item, typeof(EToggleState), uiPanelBase);
							}
							else if (left == typeof(UUISliderComponent))
							{
								this.CheckOneParamDelegateBindValid(item2, item, typeof(float), uiPanelBase);
							}
							else if (left == typeof(UUITextInputComponent))
							{
								this.CheckOneParamDelegateBindValid(item2, item, typeof(bool), uiPanelBase);
							}
						}
					}
				}
				catch (Exception item3)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiManager;
					ELogAuthor author2 = ELogAuthor.BB;
					string message = "[CheckUiPanelBindValidLog] Exception";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PanelType", type.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Exception", item3);
					instance2.Error(module2, author2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0602EC80 RID: 191616 RVA: 0x00AD4DA0 File Offset: 0x00AD2FA0
		private unsafe void CheckUiButtonBindValid(Delegate delegateType, int componentId, Type paramType, UiPanelBase panel)
		{
			Type type = delegateType.GetType();
			if (type == typeof(Action))
			{
				return;
			}
			MethodInfo method = type.GetMethod("Invoke");
			if (method == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[CheckUiPanelBindValidLog] 未找到Invoke方法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PanelType", panel.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", componentId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (method.GetParameters().Length != 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiManager;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[CheckUiPanelBindValidLog] Invoke方法参数数量不为0";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PanelType", panel.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ComponentId", componentId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
		}

		// Token: 0x0602EC81 RID: 191617 RVA: 0x00AD4EB4 File Offset: 0x00AD30B4
		private unsafe void CheckOneParamDelegateBindValid(Delegate delegateType, int componentId, Type paramType, UiPanelBase panel)
		{
			MethodInfo method = delegateType.GetType().GetMethod("Invoke");
			if (method == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[CheckUiPanelBindValidLog] 未找到Invoke方法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PanelType", panel.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", componentId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			ParameterInfo[] parameters = method.GetParameters();
			if (parameters.Length != 1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiManager;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[CheckUiPanelBindValidLog] Invoke方法参数数量不为1";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PanelType", panel.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ComponentId", componentId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			if (parameters[0].ParameterType != paramType)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiManager;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "[CheckUiPanelBindValidLog] Invoke方法参数类型不为指定类型";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PanelType", panel.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ParamType", paramType.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("ComponentId", componentId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			}
		}

		// Token: 0x1700767E RID: 30334
		// (get) Token: 0x0602EC82 RID: 191618 RVA: 0x00AD504C File Offset: 0x00AD324C
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

		// Token: 0x0602EC83 RID: 191619 RVA: 0x00AD506F File Offset: 0x00AD326F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EC84 RID: 191620 RVA: 0x00AD5071 File Offset: 0x00AD3271
		public static void ResetStaticDefaultValue()
		{
			UiManager instance = UiManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiManager._instance = null;
		}

		// Token: 0x0602EC85 RID: 191621 RVA: 0x00AD508A File Offset: 0x00AD328A
		static UiManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiManager.CreateStaticDefaultValue), new Action(UiManager.ResetStaticDefaultValue));
		}

		// Token: 0x04019730 RID: 104240
		private EInitState InitState;

		// Token: 0x04019731 RID: 104241
		public bool IsClear;

		// Token: 0x04019732 RID: 104242
		private readonly Dictionary<ELayerType, UiViewContainer> Containers = new Dictionary<ELayerType, UiViewContainer>();

		// Token: 0x04019733 RID: 104243
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1
		})]
		private readonly Dictionary<EUiViewName, Dictionary<Func<EUiViewName, object, bool>, string>> OpenViewCheckFunctionsMap = new Dictionary<EUiViewName, Dictionary<Func<EUiViewName, object, bool>, string>>();

		// Token: 0x04019734 RID: 104244
		private readonly Stat StatsObject = Stat.Create("UiManger", "", "");

		// Token: 0x04019735 RID: 104245
		private readonly Dictionary<int, UiViewBase> IdToViewMap = new Dictionary<int, UiViewBase>();

		// Token: 0x04019736 RID: 104246
		private readonly Dictionary<EUiViewName, HashSet<UiViewBase>> NameToViewSetMap = new Dictionary<EUiViewName, HashSet<UiViewBase>>();

		// Token: 0x04019737 RID: 104247
		private readonly HashSet<IPanelTickInterface> TickViewSet = new HashSet<IPanelTickInterface>();

		// Token: 0x04019738 RID: 104248
		private readonly Dictionary<int, UiViewBase> PreOpeningViewMap = new Dictionary<int, UiViewBase>();

		// Token: 0x04019739 RID: 104249
		private EUiViewName? LastNormalTopViewName;

		// Token: 0x0401973A RID: 104250
		private int CsRequestId;

		// Token: 0x0401973B RID: 104251
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Dictionary<int, object> CsRequestParamMap = new Dictionary<int, object>();

		// Token: 0x0401973C RID: 104252
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Dictionary<int, TOpenViewCallBack> CsRequestCallbackMap = new Dictionary<int, TOpenViewCallBack>();

		// Token: 0x0401973D RID: 104253
		private Dictionary<int, bool> CsRequestNeedOpenInSharpMap = new Dictionary<int, bool>();

		// Token: 0x0401973E RID: 104254
		private bool OpenLock;

		// Token: 0x0401973F RID: 104255
		private List<IPanelTickInterface> TempTickView = new List<IPanelTickInterface>();

		// Token: 0x04019740 RID: 104256
		[Nullable(2)]
		private static UiManager _instance;
	}
}
