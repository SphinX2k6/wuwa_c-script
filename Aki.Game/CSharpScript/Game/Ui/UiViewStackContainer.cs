using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200358F RID: 13711
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewStackContainer : UiViewContainer
	{
		// Token: 0x06022F5A RID: 143194 RVA: 0x009EC13B File Offset: 0x009EA33B
		public UiViewStackContainer(global::Stack<UiViewBase> stack)
		{
			this.Stack = stack;
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x06022F5B RID: 143195 RVA: 0x009EC177 File Offset: 0x009EA377
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06022F5C RID: 143196 RVA: 0x009EC17F File Offset: 0x009EA37F
		private void Lock(string lockReason = "")
		{
			this.Operating = true;
			this.LockOperationPromise = new CustomPromise();
		}

		// Token: 0x06022F5D RID: 143197 RVA: 0x009EC193 File Offset: 0x009EA393
		private void Unlock(string unlockReason = "", bool needHandlePending = true)
		{
			this.Operating = false;
			CustomPromise lockOperationPromise = this.LockOperationPromise;
			if (lockOperationPromise != null)
			{
				lockOperationPromise.SetResult();
			}
			this.LockOperationPromise = null;
			if (needHandlePending)
			{
				this.ProcessViewPending();
			}
		}

		// Token: 0x06022F5E RID: 143198 RVA: 0x009EC1C0 File Offset: 0x009EA3C0
		private void PushView(UiViewBase view)
		{
			this.Stack.Push(view);
			EUiViewName name = view.ViewInfo.Name;
			HashSet<UiViewBase> hashSet;
			if (!this.NameToViewSetMap.TryGetValue(name, out hashSet))
			{
				hashSet = new HashSet<UiViewBase>();
				this.NameToViewSetMap[name] = hashSet;
			}
			hashSet.Add(view);
		}

		// Token: 0x06022F5F RID: 143199 RVA: 0x009EC210 File Offset: 0x009EA410
		private void PopView()
		{
			UiViewBase uiViewBase = this.Stack.Pop();
			if (uiViewBase == null)
			{
				Log.Instance.Error(ELogModule.StackContainer, ELogAuthor.TL, "StackContainer_PopView 出栈失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EUiViewName name = uiViewBase.ViewInfo.Name;
			HashSet<UiViewBase> hashSet;
			if (this.NameToViewSetMap.TryGetValue(name, out hashSet))
			{
				hashSet.Remove(uiViewBase);
				if (hashSet.Count <= 0)
				{
					this.NameToViewSetMap.Remove(name);
				}
			}
		}

		// Token: 0x06022F60 RID: 143200 RVA: 0x009EC288 File Offset: 0x009EA488
		private bool DeleteView(UiViewBase view)
		{
			EUiViewName name = view.ViewInfo.Name;
			HashSet<UiViewBase> hashSet;
			if (this.NameToViewSetMap.TryGetValue(name, out hashSet))
			{
				hashSet.Remove(view);
				if (hashSet.Count <= 0)
				{
					this.NameToViewSetMap.Remove(name);
				}
			}
			bool flag = this.Stack.Delete(view);
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.StackContainer;
				ELogAuthor author = ELogAuthor.TL;
				string message = "StackContainer_DeleteView删除界面不在栈内";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return flag;
		}

		// Token: 0x06022F61 RID: 143201 RVA: 0x009EC318 File Offset: 0x009EA518
		private UniTask ProcessViewPending()
		{
			UiViewStackContainer.<ProcessViewPending>d__13 <ProcessViewPending>d__;
			<ProcessViewPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessViewPending>d__.<>4__this = this;
			<ProcessViewPending>d__.<>1__state = -1;
			<ProcessViewPending>d__.<>t__builder.Start<UiViewStackContainer.<ProcessViewPending>d__13>(ref <ProcessViewPending>d__);
			return <ProcessViewPending>d__.<>t__builder.Task;
		}

		// Token: 0x06022F62 RID: 143202 RVA: 0x009EC35C File Offset: 0x009EA55C
		[NullableContext(0)]
		public override UniTask<bool> OpenViewAsync([Nullable(1)] UiViewBase view)
		{
			UiViewStackContainer.<OpenViewAsync>d__14 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.view = view;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<OpenViewAsync>d__14>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F63 RID: 143203 RVA: 0x009EC3A8 File Offset: 0x009EA5A8
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewStackContainer.<PreOpenViewAsync>d__15 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<PreOpenViewAsync>d__15>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F64 RID: 143204 RVA: 0x009EC3EC File Offset: 0x009EA5EC
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewStackContainer.<OpenViewAfterPreOpenedAsync>d__16 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.<>4__this = this;
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewStackContainer.<OpenViewAfterPreOpenedAsync>d__16>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F65 RID: 143205 RVA: 0x009EC438 File Offset: 0x009EA638
		private UniTask OpenStackViewAsync(UiViewBase view, [Nullable(2)] UiViewBase lastView)
		{
			UiViewStackContainer.<OpenStackViewAsync>d__17 <OpenStackViewAsync>d__;
			<OpenStackViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenStackViewAsync>d__.<>4__this = this;
			<OpenStackViewAsync>d__.view = view;
			<OpenStackViewAsync>d__.lastView = lastView;
			<OpenStackViewAsync>d__.<>1__state = -1;
			<OpenStackViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<OpenStackViewAsync>d__17>(ref <OpenStackViewAsync>d__);
			return <OpenStackViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F66 RID: 143206 RVA: 0x009EC48C File Offset: 0x009EA68C
		public override UniTask CloseViewAsync(UiViewBase view)
		{
			UiViewStackContainer.<CloseViewAsync>d__18 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.view = view;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<CloseViewAsync>d__18>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F67 RID: 143207 RVA: 0x009EC4D8 File Offset: 0x009EA6D8
		public UniTask CloseAndOpenNewAsync(UiViewBase closeView, UiViewBase view)
		{
			UiViewStackContainer.<CloseAndOpenNewAsync>d__19 <CloseAndOpenNewAsync>d__;
			<CloseAndOpenNewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAndOpenNewAsync>d__.<>4__this = this;
			<CloseAndOpenNewAsync>d__.closeView = closeView;
			<CloseAndOpenNewAsync>d__.view = view;
			<CloseAndOpenNewAsync>d__.<>1__state = -1;
			<CloseAndOpenNewAsync>d__.<>t__builder.Start<UiViewStackContainer.<CloseAndOpenNewAsync>d__19>(ref <CloseAndOpenNewAsync>d__);
			return <CloseAndOpenNewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F68 RID: 143208 RVA: 0x009EC52C File Offset: 0x009EA72C
		public UniTask ResetToViewAsync(UiViewBase targetView)
		{
			UiViewStackContainer.<ResetToViewAsync>d__20 <ResetToViewAsync>d__;
			<ResetToViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetToViewAsync>d__.<>4__this = this;
			<ResetToViewAsync>d__.targetView = targetView;
			<ResetToViewAsync>d__.<>1__state = -1;
			<ResetToViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<ResetToViewAsync>d__20>(ref <ResetToViewAsync>d__);
			return <ResetToViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F69 RID: 143209 RVA: 0x009EC578 File Offset: 0x009EA778
		private UniTask CloseViewInternal(UiViewBase view, [Nullable(2)] UiViewBase nextView, bool isCloseAndOpen = false)
		{
			UiViewStackContainer.<CloseViewInternal>d__21 <CloseViewInternal>d__;
			<CloseViewInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewInternal>d__.<>4__this = this;
			<CloseViewInternal>d__.view = view;
			<CloseViewInternal>d__.nextView = nextView;
			<CloseViewInternal>d__.isCloseAndOpen = isCloseAndOpen;
			<CloseViewInternal>d__.<>1__state = -1;
			<CloseViewInternal>d__.<>t__builder.Start<UiViewStackContainer.<CloseViewInternal>d__21>(ref <CloseViewInternal>d__);
			return <CloseViewInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06022F6A RID: 143210 RVA: 0x009EC5D4 File Offset: 0x009EA7D4
		public UniTask CloseHistoryRingViewAsync(EUiViewName viewName)
		{
			UiViewStackContainer.<CloseHistoryRingViewAsync>d__22 <CloseHistoryRingViewAsync>d__;
			<CloseHistoryRingViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseHistoryRingViewAsync>d__.<>4__this = this;
			<CloseHistoryRingViewAsync>d__.viewName = viewName;
			<CloseHistoryRingViewAsync>d__.<>1__state = -1;
			<CloseHistoryRingViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<CloseHistoryRingViewAsync>d__22>(ref <CloseHistoryRingViewAsync>d__);
			return <CloseHistoryRingViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F6B RID: 143211 RVA: 0x009EC620 File Offset: 0x009EA820
		private void PushCameraHandleByOpenView(UiViewBase view, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend)
		{
			IUiViewCameraBehavior uiViewCameraBehavior = view as IUiViewCameraBehavior;
			if (uiViewCameraBehavior != null)
			{
				uiViewCameraBehavior.PushCameraHandleByOpenView(view.ViewInfo.Name, view.GetViewId(), operationType);
				return;
			}
			UiCameraController.Instance.PushCameraHandleByOpenView(view.ViewInfo.Name, view.GetViewId(), operationType);
		}

		// Token: 0x06022F6C RID: 143212 RVA: 0x009EC66C File Offset: 0x009EA86C
		private void PopCameraHandleByCloseView(UiViewBase view, [Nullable(2)] UiViewBase nextView, EUiCameraHandleOperationType operationType)
		{
			IUiViewCameraBehavior uiViewCameraBehavior = view as IUiViewCameraBehavior;
			if (uiViewCameraBehavior != null)
			{
				IUiViewCameraBehavior uiViewCameraBehavior2 = uiViewCameraBehavior;
				EUiViewName name = view.ViewInfo.Name;
				EUiViewName? nextViewName;
				if (nextView == null)
				{
					nextViewName = null;
				}
				else
				{
					UiViewInfo viewInfo = nextView.ViewInfo;
					nextViewName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
				}
				uiViewCameraBehavior2.PopCameraHandleByCloseView(name, nextViewName, view.GetViewId(), operationType);
				return;
			}
			UiCameraController instance = UiCameraController.Instance;
			EUiViewName name2 = view.ViewInfo.Name;
			EUiViewName? nextViewName2;
			if (nextView == null)
			{
				nextViewName2 = null;
			}
			else
			{
				UiViewInfo viewInfo2 = nextView.ViewInfo;
				nextViewName2 = ((viewInfo2 != null) ? new EUiViewName?(viewInfo2.Name) : null);
			}
			instance.PopCameraHandleByCloseView(name2, nextViewName2, view.GetViewId(), operationType);
		}

		// Token: 0x06022F6D RID: 143213 RVA: 0x009EC712 File Offset: 0x009EA912
		private bool CheckContainerHasSameView(EUiViewName viewName)
		{
			return this.NameToViewSetMap.ContainsKey(viewName);
		}

		// Token: 0x06022F6E RID: 143214 RVA: 0x009EC720 File Offset: 0x009EA920
		public override void ClearContainer(bool isSeamlessTravel)
		{
			List<UiViewBase> list = new List<UiViewBase>();
			foreach (UiViewBase uiViewBase in this.Stack)
			{
				uiViewBase.IsExistInLeaveLevel = true;
				if (!uiViewBase.ViewInfo.IsPermanent && (!isSeamlessTravel || !UiModel.Instance.SeamlessStackWhileList.Contains(uiViewBase.ViewInfo.Name)))
				{
					base.TryCatchViewDestroyCompatible(uiViewBase);
					list.Add(uiViewBase);
				}
			}
			foreach (UiViewBase view in list)
			{
				this.DeleteView(view);
			}
			Log.Instance.Info(ELogModule.StackContainer, ELogAuthor.TL, "ClearContainer 清栈", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06022F6F RID: 143215 RVA: 0x009EC810 File Offset: 0x009EAA10
		public override UniTask BeforeClearContainerAsync(bool isSeamlessTravel)
		{
			UiViewStackContainer.<BeforeClearContainerAsync>d__27 <BeforeClearContainerAsync>d__;
			<BeforeClearContainerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeforeClearContainerAsync>d__.<>4__this = this;
			<BeforeClearContainerAsync>d__.isSeamlessTravel = isSeamlessTravel;
			<BeforeClearContainerAsync>d__.<>1__state = -1;
			<BeforeClearContainerAsync>d__.<>t__builder.Start<UiViewStackContainer.<BeforeClearContainerAsync>d__27>(ref <BeforeClearContainerAsync>d__);
			return <BeforeClearContainerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F70 RID: 143216 RVA: 0x009EC85C File Offset: 0x009EAA5C
		public UniTask HideViewByPlot()
		{
			UiViewStackContainer.<HideViewByPlot>d__28 <HideViewByPlot>d__;
			<HideViewByPlot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideViewByPlot>d__.<>4__this = this;
			<HideViewByPlot>d__.<>1__state = -1;
			<HideViewByPlot>d__.<>t__builder.Start<UiViewStackContainer.<HideViewByPlot>d__28>(ref <HideViewByPlot>d__);
			return <HideViewByPlot>d__.<>t__builder.Task;
		}

		// Token: 0x06022F71 RID: 143217 RVA: 0x009EC8A0 File Offset: 0x009EAAA0
		public UniTask ShowViewByPlot(Func<UniTask> destroyOtherView = null)
		{
			UiViewStackContainer.<ShowViewByPlot>d__29 <ShowViewByPlot>d__;
			<ShowViewByPlot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowViewByPlot>d__.<>4__this = this;
			<ShowViewByPlot>d__.destroyOtherView = destroyOtherView;
			<ShowViewByPlot>d__.<>1__state = -1;
			<ShowViewByPlot>d__.<>t__builder.Start<UiViewStackContainer.<ShowViewByPlot>d__29>(ref <ShowViewByPlot>d__);
			return <ShowViewByPlot>d__.<>t__builder.Task;
		}

		// Token: 0x06022F72 RID: 143218 RVA: 0x009EC8EC File Offset: 0x009EAAEC
		public UniTask WaitSwitchToPlotPending()
		{
			UiViewStackContainer.<WaitSwitchToPlotPending>d__30 <WaitSwitchToPlotPending>d__;
			<WaitSwitchToPlotPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitSwitchToPlotPending>d__.<>4__this = this;
			<WaitSwitchToPlotPending>d__.<>1__state = -1;
			<WaitSwitchToPlotPending>d__.<>t__builder.Start<UiViewStackContainer.<WaitSwitchToPlotPending>d__30>(ref <WaitSwitchToPlotPending>d__);
			return <WaitSwitchToPlotPending>d__.<>t__builder.Task;
		}

		// Token: 0x06022F73 RID: 143219 RVA: 0x009EC92F File Offset: 0x009EAB2F
		public void TryUnlock()
		{
			if (this.Operating)
			{
				this.Unlock("TryUnlock", true);
			}
		}

		// Token: 0x06022F74 RID: 143220 RVA: 0x009EC948 File Offset: 0x009EAB48
		private unsafe UiViewPending AddPendingView(UiViewBase view, EViewPendingType type, [Nullable(2)] UiViewBase nextView = null)
		{
			UiViewPending uiViewPending = new UiViewPending(view, type, nextView);
			if (this.ViewPendingList.Count > 0)
			{
				List<UiViewPending> viewPendingList = this.ViewPendingList;
				UiViewPending uiViewPending2 = viewPendingList[viewPendingList.Count - 1];
				if (uiViewPending2.Equal(uiViewPending))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.StackContainer;
					ELogAuthor author = ELogAuthor.TL;
					string message = "界面缓存操做重复";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					CustomPromise<bool> executePromise = uiViewPending.ExecutePromise;
					if (executePromise != null)
					{
						executePromise.SetResult(true);
					}
					return uiViewPending;
				}
				if (uiViewPending2.IsPairWith(uiViewPending))
				{
					this.ViewPendingList.RemoveAt(this.ViewPendingList.Count - 1);
					UiManager.Instance.RemoveView(view.GetViewId());
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.StackContainer;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "界面缓存操作成对, 自动移除上一个";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					CustomPromise<bool> executePromise2 = uiViewPending.ExecutePromise;
					if (executePromise2 != null)
					{
						executePromise2.SetResult(true);
					}
					return uiViewPending;
				}
			}
			this.ViewPendingList.Add(uiViewPending);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.StackContainer;
			ELogAuthor author3 = ELogAuthor.TL;
			string message3 = "缓存界面操作";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("界面", view.ViewInfo.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("操作类型", type);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return uiViewPending;
		}

		// Token: 0x06022F75 RID: 143221 RVA: 0x009ECAD4 File Offset: 0x009EACD4
		private void DeleteDoublyLinkData(DoublyLinkedNode<UiViewBase> node)
		{
			if (node == null)
			{
				return;
			}
			this.DoublyLinked.Remove(node);
			this.DoublyLinkNodeMap.Remove(node.Element);
			if (this.DoublyLinkNodeMap.Count == 0)
			{
				UiModel.Instance.InNormalQueue = false;
				EventSystem.Instance.Emit(EEventName.ExitNormalQueueState);
			}
		}

		// Token: 0x06022F76 RID: 143222 RVA: 0x009ECB2C File Offset: 0x009EAD2C
		private void AddDoubleLinkData(UiViewBase view)
		{
			DoublyLinkedNode<UiViewBase> doublyLinkedNode = this.DoublyLinked.Find((DoublyLinkedNode<UiViewBase> node) => node.Element == null || view.ViewInfo.SortIndex < node.Element.ViewInfo.SortIndex);
			DoublyLinkedNode<UiViewBase> value;
			if (doublyLinkedNode.Pre != null)
			{
				value = this.DoublyLinked.Insert(view, doublyLinkedNode.Pre);
			}
			else
			{
				value = this.DoublyLinked.AddTail(view);
			}
			this.DoublyLinkNodeMap[view] = value;
			UiModel.Instance.InNormalQueue = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.StackContainer;
			ELogAuthor author = ELogAuthor.TL;
			string message = "缓存界面进入等待队列";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06022F77 RID: 143223 RVA: 0x009ECBEF File Offset: 0x009EADEF
		public bool IsViewPendingListEmpty()
		{
			return this.ViewPendingList.Count == 0;
		}

		// Token: 0x06022F78 RID: 143224 RVA: 0x009ECC00 File Offset: 0x009EAE00
		private bool CheckMainViewAtBottom(UiViewBase view)
		{
			return view.ViewInfo.GetContainerLayerType() != ELayerType.Normal || this.Stack.Size >= 1 || (view.ViewInfo.Name == UiModel.Instance.MainViewName || UiModel.Instance.NormalStackBottomWhiteSet.Contains(view.ViewInfo.Name));
		}

		// Token: 0x04013497 RID: 78999
		private readonly global::Stack<UiViewBase> Stack;

		// Token: 0x04013498 RID: 79000
		private readonly Dictionary<EUiViewName, HashSet<UiViewBase>> NameToViewSetMap = new Dictionary<EUiViewName, HashSet<UiViewBase>>();

		// Token: 0x04013499 RID: 79001
		private bool Operating;

		// Token: 0x0401349A RID: 79002
		[Nullable(2)]
		private CustomPromise ResetToViewPromise;

		// Token: 0x0401349B RID: 79003
		[Nullable(2)]
		private CustomPromise LockOperationPromise;

		// Token: 0x0401349C RID: 79004
		private List<UiViewPending> ViewPendingList = new List<UiViewPending>();

		// Token: 0x0401349D RID: 79005
		private readonly DoublyLinkedList<UiViewBase> DoublyLinked = new DoublyLinkedList<UiViewBase>(null);

		// Token: 0x0401349E RID: 79006
		private readonly Dictionary<UiViewBase, DoublyLinkedNode<UiViewBase>> DoublyLinkNodeMap = new Dictionary<UiViewBase, DoublyLinkedNode<UiViewBase>>();
	}
}
