using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200465E RID: 18014
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewStackContainer : UiViewContainer
	{
		// Token: 0x0602E810 RID: 190480 RVA: 0x00ABEABB File Offset: 0x00ABCCBB
		public UiViewStackContainer(global::Stack<UiViewBase> stack)
		{
			this.Stack = stack;
		}

		// Token: 0x17007606 RID: 30214
		// (get) Token: 0x0602E811 RID: 190481 RVA: 0x00ABEAF7 File Offset: 0x00ABCCF7
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x0602E812 RID: 190482 RVA: 0x00ABEAFF File Offset: 0x00ABCCFF
		private void Lock(string lockReason = "")
		{
			this.Operating = true;
			this.LockOperationPromise = new CustomPromise();
		}

		// Token: 0x0602E813 RID: 190483 RVA: 0x00ABEB13 File Offset: 0x00ABCD13
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

		// Token: 0x0602E814 RID: 190484 RVA: 0x00ABEB40 File Offset: 0x00ABCD40
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

		// Token: 0x0602E815 RID: 190485 RVA: 0x00ABEB90 File Offset: 0x00ABCD90
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

		// Token: 0x0602E816 RID: 190486 RVA: 0x00ABEC08 File Offset: 0x00ABCE08
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

		// Token: 0x0602E817 RID: 190487 RVA: 0x00ABEC98 File Offset: 0x00ABCE98
		private UniTask ProcessViewPending()
		{
			UiViewStackContainer.<ProcessViewPending>d__13 <ProcessViewPending>d__;
			<ProcessViewPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessViewPending>d__.<>4__this = this;
			<ProcessViewPending>d__.<>1__state = -1;
			<ProcessViewPending>d__.<>t__builder.Start<UiViewStackContainer.<ProcessViewPending>d__13>(ref <ProcessViewPending>d__);
			return <ProcessViewPending>d__.<>t__builder.Task;
		}

		// Token: 0x0602E818 RID: 190488 RVA: 0x00ABECDC File Offset: 0x00ABCEDC
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

		// Token: 0x0602E819 RID: 190489 RVA: 0x00ABED28 File Offset: 0x00ABCF28
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewStackContainer.<PreOpenViewAsync>d__15 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewStackContainer.<PreOpenViewAsync>d__15>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E81A RID: 190490 RVA: 0x00ABED6C File Offset: 0x00ABCF6C
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

		// Token: 0x0602E81B RID: 190491 RVA: 0x00ABEDB8 File Offset: 0x00ABCFB8
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

		// Token: 0x0602E81C RID: 190492 RVA: 0x00ABEE0C File Offset: 0x00ABD00C
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

		// Token: 0x0602E81D RID: 190493 RVA: 0x00ABEE58 File Offset: 0x00ABD058
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

		// Token: 0x0602E81E RID: 190494 RVA: 0x00ABEEAC File Offset: 0x00ABD0AC
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

		// Token: 0x0602E81F RID: 190495 RVA: 0x00ABEEF8 File Offset: 0x00ABD0F8
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

		// Token: 0x0602E820 RID: 190496 RVA: 0x00ABEF54 File Offset: 0x00ABD154
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

		// Token: 0x0602E821 RID: 190497 RVA: 0x00ABEFA0 File Offset: 0x00ABD1A0
		private void PushCameraHandle(UiViewBase view, bool bBlend = true)
		{
			IUiCameraBehavior uiCameraBehavior = view as IUiCameraBehavior;
			if (uiCameraBehavior != null)
			{
				uiCameraBehavior.PushCameraHandle(view.ViewInfo.Name, view.GetViewId(), bBlend);
				return;
			}
			UiCameraAnimationController.Instance.PushCameraHandle(view.ViewInfo.Name, new int?(view.GetViewId()), bBlend);
		}

		// Token: 0x0602E822 RID: 190498 RVA: 0x00ABEFF4 File Offset: 0x00ABD1F4
		private void PopCameraHandle(UiViewBase view, UiViewInfo stackTopInfo, bool popOrDelete = true)
		{
			IUiCameraBehavior uiCameraBehavior = view as IUiCameraBehavior;
			if (uiCameraBehavior != null)
			{
				uiCameraBehavior.PopCameraHandle(view.ViewInfo.Name, stackTopInfo, view.GetViewId(), popOrDelete);
				return;
			}
			UiCameraAnimationController.Instance.PopCameraHandle(view.ViewInfo.Name, stackTopInfo, view.GetViewId(), popOrDelete);
		}

		// Token: 0x0602E823 RID: 190499 RVA: 0x00ABF042 File Offset: 0x00ABD242
		private bool CheckContainerHasSameView(EUiViewName viewName)
		{
			return this.NameToViewSetMap.ContainsKey(viewName);
		}

		// Token: 0x0602E824 RID: 190500 RVA: 0x00ABF050 File Offset: 0x00ABD250
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

		// Token: 0x0602E825 RID: 190501 RVA: 0x00ABF140 File Offset: 0x00ABD340
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

		// Token: 0x0602E826 RID: 190502 RVA: 0x00ABF18C File Offset: 0x00ABD38C
		public UniTask HideViewByPlot()
		{
			UiViewStackContainer.<HideViewByPlot>d__28 <HideViewByPlot>d__;
			<HideViewByPlot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideViewByPlot>d__.<>4__this = this;
			<HideViewByPlot>d__.<>1__state = -1;
			<HideViewByPlot>d__.<>t__builder.Start<UiViewStackContainer.<HideViewByPlot>d__28>(ref <HideViewByPlot>d__);
			return <HideViewByPlot>d__.<>t__builder.Task;
		}

		// Token: 0x0602E827 RID: 190503 RVA: 0x00ABF1D0 File Offset: 0x00ABD3D0
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

		// Token: 0x0602E828 RID: 190504 RVA: 0x00ABF21C File Offset: 0x00ABD41C
		public UniTask WaitSwitchToPlotPending()
		{
			UiViewStackContainer.<WaitSwitchToPlotPending>d__30 <WaitSwitchToPlotPending>d__;
			<WaitSwitchToPlotPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitSwitchToPlotPending>d__.<>4__this = this;
			<WaitSwitchToPlotPending>d__.<>1__state = -1;
			<WaitSwitchToPlotPending>d__.<>t__builder.Start<UiViewStackContainer.<WaitSwitchToPlotPending>d__30>(ref <WaitSwitchToPlotPending>d__);
			return <WaitSwitchToPlotPending>d__.<>t__builder.Task;
		}

		// Token: 0x0602E829 RID: 190505 RVA: 0x00ABF25F File Offset: 0x00ABD45F
		public void TryUnlock()
		{
			if (this.Operating)
			{
				this.Unlock("TryUnlock", true);
			}
		}

		// Token: 0x0602E82A RID: 190506 RVA: 0x00ABF278 File Offset: 0x00ABD478
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

		// Token: 0x0602E82B RID: 190507 RVA: 0x00ABF404 File Offset: 0x00ABD604
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

		// Token: 0x0602E82C RID: 190508 RVA: 0x00ABF45C File Offset: 0x00ABD65C
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

		// Token: 0x0602E82D RID: 190509 RVA: 0x00ABF51F File Offset: 0x00ABD71F
		public bool IsViewPendingListEmpty()
		{
			return this.ViewPendingList.Count == 0;
		}

		// Token: 0x0602E82E RID: 190510 RVA: 0x00ABF530 File Offset: 0x00ABD730
		private bool CheckMainViewAtBottom(UiViewBase view)
		{
			return view.ViewInfo.GetContainerLayerType() != ELayerType.Normal || this.Stack.Size >= 1 || (view.ViewInfo.Name == UiModel.Instance.MainViewName || UiModel.Instance.NormalStackBottomWhiteSet.Contains(view.ViewInfo.Name));
		}

		// Token: 0x04018E3E RID: 101950
		private readonly global::Stack<UiViewBase> Stack;

		// Token: 0x04018E3F RID: 101951
		private readonly Dictionary<EUiViewName, HashSet<UiViewBase>> NameToViewSetMap = new Dictionary<EUiViewName, HashSet<UiViewBase>>();

		// Token: 0x04018E40 RID: 101952
		private bool Operating;

		// Token: 0x04018E41 RID: 101953
		[Nullable(2)]
		private CustomPromise ResetToViewPromise;

		// Token: 0x04018E42 RID: 101954
		[Nullable(2)]
		private CustomPromise LockOperationPromise;

		// Token: 0x04018E43 RID: 101955
		private List<UiViewPending> ViewPendingList = new List<UiViewPending>();

		// Token: 0x04018E44 RID: 101956
		private readonly DoublyLinkedList<UiViewBase> DoublyLinked = new DoublyLinkedList<UiViewBase>(null);

		// Token: 0x04018E45 RID: 101957
		private readonly Dictionary<UiViewBase, DoublyLinkedNode<UiViewBase>> DoublyLinkNodeMap = new Dictionary<UiViewBase, DoublyLinkedNode<UiViewBase>>();
	}
}
