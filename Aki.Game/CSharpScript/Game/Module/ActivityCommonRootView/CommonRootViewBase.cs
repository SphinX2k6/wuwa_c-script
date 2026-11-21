using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ActivityCommonRootView
{
	// Token: 0x02005A8B RID: 23179
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonRootViewBase<[Nullable(0)] TViewModel> : UiTickViewBase, ICommonRootViewBase where TViewModel : ICommonRootViewModel
	{
		// Token: 0x0603921E RID: 234014 RVA: 0x010006E9 File Offset: 0x00FFE8E9
		protected CommonRootViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603921F RID: 234015
		protected abstract void OnRegisterViewData();

		// Token: 0x06039220 RID: 234016
		protected abstract void OnRegisterDefaultChildView();

		// Token: 0x06039221 RID: 234017
		protected abstract void OnRegisterContentItem();

		// Token: 0x06039222 RID: 234018 RVA: 0x01000708 File Offset: 0x00FFE908
		protected virtual void OnChildViewSwitch([Nullable(2)] CommonChildViewBase lastView, CommonChildViewBase curView)
		{
		}

		// Token: 0x06039223 RID: 234019 RVA: 0x0100070A File Offset: 0x00FFE90A
		protected override void OnTick(float delta)
		{
			CommonChildViewBase curChildView = this.GetCurChildView();
			if (curChildView == null)
			{
				return;
			}
			curChildView.OnTick(delta);
		}

		// Token: 0x06039224 RID: 234020 RVA: 0x0100071D File Offset: 0x00FFE91D
		protected override void OnBeforeCreate()
		{
			this.OnRegisterViewData();
			this.OnRegisterDefaultChildView();
		}

		// Token: 0x06039225 RID: 234021 RVA: 0x0100072C File Offset: 0x00FFE92C
		protected override UniTask OnBeforeStartAsync()
		{
			CommonRootViewBase<TViewModel>.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039226 RID: 234022 RVA: 0x01000770 File Offset: 0x00FFE970
		protected override UniTask OnShowAsyncImplementImplement()
		{
			CommonRootViewBase<TViewModel>.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06039227 RID: 234023 RVA: 0x010007B3 File Offset: 0x00FFE9B3
		protected override void OnFinishShow()
		{
			base.OnFinishShow();
			this.NotifyChildViewShowDone(this.GetCurChildView());
		}

		// Token: 0x06039228 RID: 234024 RVA: 0x010007C8 File Offset: 0x00FFE9C8
		[NullableContext(2)]
		private void NotifyChildViewShowDone(CommonChildViewBase childView)
		{
			if (!base.IsShow || childView == null || !childView.IsShow || childView.ViewName == null)
			{
				return;
			}
			EventSystem.Instance.Emit<ECommonChildViewName>(EEventName.OnCommonChildViewShowDone, childView.ViewName.Value);
		}

		// Token: 0x06039229 RID: 234025 RVA: 0x01000818 File Offset: 0x00FFEA18
		protected override UniTask OnHideAsyncImplementImplement()
		{
			CommonRootViewBase<TViewModel>.<OnHideAsyncImplementImplement>d__17 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<OnHideAsyncImplementImplement>d__17>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603922A RID: 234026 RVA: 0x0100085C File Offset: 0x00FFEA5C
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			CommonRootViewBase<TViewModel>.<OnDestroyAsyncImplementImplement>d__18 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<OnDestroyAsyncImplementImplement>d__18>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603922B RID: 234027 RVA: 0x010008A0 File Offset: 0x00FFEAA0
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<CommonChildViewBase> CreateChildViewAsync(ECommonChildViewName viewName, object param = null)
		{
			CommonRootViewBase<TViewModel>.<CreateChildViewAsync>d__19 <CreateChildViewAsync>d__;
			<CreateChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<CommonChildViewBase>.Create();
			<CreateChildViewAsync>d__.<>4__this = this;
			<CreateChildViewAsync>d__.viewName = viewName;
			<CreateChildViewAsync>d__.param = param;
			<CreateChildViewAsync>d__.<>1__state = -1;
			<CreateChildViewAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<CreateChildViewAsync>d__19>(ref <CreateChildViewAsync>d__);
			return <CreateChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603922C RID: 234028 RVA: 0x010008F4 File Offset: 0x00FFEAF4
		[NullableContext(2)]
		public void OpenChildView(ECommonChildViewName viewName, object param = null)
		{
			base.RunAsyncTask(new UiAsyncTask("CommonRootViewBase", () => this.OpenChildViewInternalAsync(viewName, param), null));
		}

		// Token: 0x0603922D RID: 234029 RVA: 0x0100093C File Offset: 0x00FFEB3C
		[NullableContext(2)]
		public UniTask OpenChildViewAsync(ECommonChildViewName viewName, object param = null)
		{
			CommonRootViewBase<TViewModel>.<OpenChildViewAsync>d__21 <OpenChildViewAsync>d__;
			<OpenChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewAsync>d__.<>4__this = this;
			<OpenChildViewAsync>d__.viewName = viewName;
			<OpenChildViewAsync>d__.param = param;
			<OpenChildViewAsync>d__.<>1__state = -1;
			<OpenChildViewAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<OpenChildViewAsync>d__21>(ref <OpenChildViewAsync>d__);
			return <OpenChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603922E RID: 234030 RVA: 0x01000990 File Offset: 0x00FFEB90
		protected UniTask WaitChildViewSwitchIdleAsync()
		{
			CommonRootViewBase<TViewModel>.<WaitChildViewSwitchIdleAsync>d__22 <WaitChildViewSwitchIdleAsync>d__;
			<WaitChildViewSwitchIdleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitChildViewSwitchIdleAsync>d__.<>4__this = this;
			<WaitChildViewSwitchIdleAsync>d__.<>1__state = -1;
			<WaitChildViewSwitchIdleAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<WaitChildViewSwitchIdleAsync>d__22>(ref <WaitChildViewSwitchIdleAsync>d__);
			return <WaitChildViewSwitchIdleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603922F RID: 234031 RVA: 0x010009D4 File Offset: 0x00FFEBD4
		[NullableContext(2)]
		private UniTask OpenChildViewInternalAsync(ECommonChildViewName viewName, object param = null)
		{
			CommonRootViewBase<TViewModel>.<OpenChildViewInternalAsync>d__23 <OpenChildViewInternalAsync>d__;
			<OpenChildViewInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewInternalAsync>d__.<>4__this = this;
			<OpenChildViewInternalAsync>d__.viewName = viewName;
			<OpenChildViewInternalAsync>d__.param = param;
			<OpenChildViewInternalAsync>d__.<>1__state = -1;
			<OpenChildViewInternalAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<OpenChildViewInternalAsync>d__23>(ref <OpenChildViewInternalAsync>d__);
			return <OpenChildViewInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039230 RID: 234032 RVA: 0x01000A28 File Offset: 0x00FFEC28
		private UniTask RemoveNotKeepChildViewsAsync()
		{
			CommonRootViewBase<TViewModel>.<RemoveNotKeepChildViewsAsync>d__24 <RemoveNotKeepChildViewsAsync>d__;
			<RemoveNotKeepChildViewsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveNotKeepChildViewsAsync>d__.<>4__this = this;
			<RemoveNotKeepChildViewsAsync>d__.<>1__state = -1;
			<RemoveNotKeepChildViewsAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<RemoveNotKeepChildViewsAsync>d__24>(ref <RemoveNotKeepChildViewsAsync>d__);
			return <RemoveNotKeepChildViewsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039231 RID: 234033 RVA: 0x01000A6B File Offset: 0x00FFEC6B
		public void CloseCurChildView()
		{
			base.RunAsyncTask(new UiAsyncTask("CommonRootViewBase", delegate()
			{
				CommonRootViewBase<TViewModel>.<<CloseCurChildView>b__25_0>d <<CloseCurChildView>b__25_0>d;
				<<CloseCurChildView>b__25_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CloseCurChildView>b__25_0>d.<>4__this = this;
				<<CloseCurChildView>b__25_0>d.<>1__state = -1;
				<<CloseCurChildView>b__25_0>d.<>t__builder.Start<CommonRootViewBase<TViewModel>.<<CloseCurChildView>b__25_0>d>(ref <<CloseCurChildView>b__25_0>d);
				return <<CloseCurChildView>b__25_0>d.<>t__builder.Task;
			}, null));
		}

		// Token: 0x06039232 RID: 234034 RVA: 0x01000A8C File Offset: 0x00FFEC8C
		[NullableContext(0)]
		public UniTask<bool> CloseCurChildViewAsync()
		{
			CommonRootViewBase<TViewModel>.<CloseCurChildViewAsync>d__26 <CloseCurChildViewAsync>d__;
			<CloseCurChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseCurChildViewAsync>d__.<>4__this = this;
			<CloseCurChildViewAsync>d__.<>1__state = -1;
			<CloseCurChildViewAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<CloseCurChildViewAsync>d__26>(ref <CloseCurChildViewAsync>d__);
			return <CloseCurChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039233 RID: 234035 RVA: 0x01000ACF File Offset: 0x00FFECCF
		public void CloseCurChildViewIfNotKeep()
		{
			base.RunAsyncTask(new UiAsyncTask("CommonRootViewBase", delegate()
			{
				CommonRootViewBase<TViewModel>.<<CloseCurChildViewIfNotKeep>b__27_0>d <<CloseCurChildViewIfNotKeep>b__27_0>d;
				<<CloseCurChildViewIfNotKeep>b__27_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CloseCurChildViewIfNotKeep>b__27_0>d.<>4__this = this;
				<<CloseCurChildViewIfNotKeep>b__27_0>d.<>1__state = -1;
				<<CloseCurChildViewIfNotKeep>b__27_0>d.<>t__builder.Start<CommonRootViewBase<TViewModel>.<<CloseCurChildViewIfNotKeep>b__27_0>d>(ref <<CloseCurChildViewIfNotKeep>b__27_0>d);
				return <<CloseCurChildViewIfNotKeep>b__27_0>d.<>t__builder.Task;
			}, null));
		}

		// Token: 0x06039234 RID: 234036 RVA: 0x01000AF0 File Offset: 0x00FFECF0
		[NullableContext(0)]
		private UniTask<bool> CloseCurChildViewInternalAsync(bool notifyShowDone = true)
		{
			CommonRootViewBase<TViewModel>.<CloseCurChildViewInternalAsync>d__28 <CloseCurChildViewInternalAsync>d__;
			<CloseCurChildViewInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseCurChildViewInternalAsync>d__.<>4__this = this;
			<CloseCurChildViewInternalAsync>d__.notifyShowDone = notifyShowDone;
			<CloseCurChildViewInternalAsync>d__.<>1__state = -1;
			<CloseCurChildViewInternalAsync>d__.<>t__builder.Start<CommonRootViewBase<TViewModel>.<CloseCurChildViewInternalAsync>d__28>(ref <CloseCurChildViewInternalAsync>d__);
			return <CloseCurChildViewInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039235 RID: 234037 RVA: 0x01000B3B File Offset: 0x00FFED3B
		[NullableContext(2)]
		protected CommonChildViewBase GetCurChildView()
		{
			return this.ChildViewStack.Peek();
		}

		// Token: 0x06039236 RID: 234038 RVA: 0x01000B48 File Offset: 0x00FFED48
		public void Back()
		{
			if (this.ChildViewStack.Size > 1)
			{
				this.CloseCurChildView();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0401E0F8 RID: 123128
		private const string SwitchTaskName = "CommonRootViewBase";

		// Token: 0x0401E0F9 RID: 123129
		public TViewModel ViewModel;

		// Token: 0x0401E0FA RID: 123130
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x0401E0FB RID: 123131
		protected ECommonChildViewName? DefaultChildViewName;

		// Token: 0x0401E0FC RID: 123132
		private readonly Stack<CommonChildViewBase> ChildViewStack = new Stack<CommonChildViewBase>();

		// Token: 0x0401E0FD RID: 123133
		protected UiMask ViewMask = new UiMask();
	}
}
