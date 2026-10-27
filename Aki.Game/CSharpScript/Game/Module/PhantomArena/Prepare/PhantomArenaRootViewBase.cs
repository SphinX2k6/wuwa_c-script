using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005149 RID: 20809
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaRootViewBase<[Nullable(0)] TViewModel> : UiViewBase, IPhantomArenaRootViewBase where TViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x060352D1 RID: 217809 RVA: 0x00C99607 File Offset: 0x00C97807
		public PhantomArenaRootViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060352D2 RID: 217810 RVA: 0x00C99626 File Offset: 0x00C97826
		protected override void OnBeforeCreate()
		{
			this.OnRegisterViewData();
			this.OnRegisterDefaultChildView();
		}

		// Token: 0x060352D3 RID: 217811
		protected abstract void OnRegisterDefaultChildView();

		// Token: 0x060352D4 RID: 217812
		protected abstract void OnRegisterContentItem();

		// Token: 0x060352D5 RID: 217813
		protected abstract void OnRegisterViewData();

		// Token: 0x060352D6 RID: 217814 RVA: 0x00C99634 File Offset: 0x00C97834
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352D7 RID: 217815 RVA: 0x00C99678 File Offset: 0x00C97878
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnShowAsyncImplementImplement>d__12 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnShowAsyncImplementImplement>d__12>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060352D8 RID: 217816 RVA: 0x00C996BC File Offset: 0x00C978BC
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnHideAsyncImplementImplement>d__13 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnHideAsyncImplementImplement>d__13>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060352D9 RID: 217817 RVA: 0x00C99700 File Offset: 0x00C97900
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnDestroyAsyncImplementImplement>d__14 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnDestroyAsyncImplementImplement>d__14>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060352DA RID: 217818 RVA: 0x00C99744 File Offset: 0x00C97944
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PhantomArenaChildViewBase> CreateChildViewAsync(EPhantomArenaChildViewName viewName)
		{
			PhantomArenaRootViewBase<TViewModel>.<CreateChildViewAsync>d__15 <CreateChildViewAsync>d__;
			<CreateChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaChildViewBase>.Create();
			<CreateChildViewAsync>d__.<>4__this = this;
			<CreateChildViewAsync>d__.viewName = viewName;
			<CreateChildViewAsync>d__.<>1__state = -1;
			<CreateChildViewAsync>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<CreateChildViewAsync>d__15>(ref <CreateChildViewAsync>d__);
			return <CreateChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352DB RID: 217819 RVA: 0x00C99790 File Offset: 0x00C97990
		public void OpenChildView(EPhantomArenaChildViewName viewName)
		{
			PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass16_0 CS$<>8__locals1 = new PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass16_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.viewName = viewName;
			UiAsyncTask task = new UiAsyncTask("PhantomArenaRootViewBase", delegate()
			{
				PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass16_0.<<OpenChildView>b__0>d <<OpenChildView>b__0>d;
				<<OpenChildView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OpenChildView>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenChildView>b__0>d.<>1__state = -1;
				<<OpenChildView>b__0>d.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass16_0.<<OpenChildView>b__0>d>(ref <<OpenChildView>b__0>d);
				return <<OpenChildView>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060352DC RID: 217820 RVA: 0x00C997D4 File Offset: 0x00C979D4
		public UniTask OpenChildViewAsync(EPhantomArenaChildViewName viewName)
		{
			PhantomArenaRootViewBase<TViewModel>.<OpenChildViewAsync>d__17 <OpenChildViewAsync>d__;
			<OpenChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewAsync>d__.<>4__this = this;
			<OpenChildViewAsync>d__.viewName = viewName;
			<OpenChildViewAsync>d__.<>1__state = -1;
			<OpenChildViewAsync>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OpenChildViewAsync>d__17>(ref <OpenChildViewAsync>d__);
			return <OpenChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352DD RID: 217821 RVA: 0x00C99820 File Offset: 0x00C97A20
		public void CloseCurChildView()
		{
			UiAsyncTask task = new UiAsyncTask("PhantomArenaRootViewBase", delegate()
			{
				PhantomArenaRootViewBase<TViewModel>.<<CloseCurChildView>b__18_0>d <<CloseCurChildView>b__18_0>d;
				<<CloseCurChildView>b__18_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CloseCurChildView>b__18_0>d.<>4__this = this;
				<<CloseCurChildView>b__18_0>d.<>1__state = -1;
				<<CloseCurChildView>b__18_0>d.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<<CloseCurChildView>b__18_0>d>(ref <<CloseCurChildView>b__18_0>d);
				return <<CloseCurChildView>b__18_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060352DE RID: 217822 RVA: 0x00C99850 File Offset: 0x00C97A50
		[NullableContext(0)]
		public UniTask<bool> CloseCurChildViewAsync()
		{
			PhantomArenaRootViewBase<TViewModel>.<CloseCurChildViewAsync>d__19 <CloseCurChildViewAsync>d__;
			<CloseCurChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseCurChildViewAsync>d__.<>4__this = this;
			<CloseCurChildViewAsync>d__.<>1__state = -1;
			<CloseCurChildViewAsync>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<CloseCurChildViewAsync>d__19>(ref <CloseCurChildViewAsync>d__);
			return <CloseCurChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352DF RID: 217823 RVA: 0x00C99894 File Offset: 0x00C97A94
		public void CloseChildView(PhantomArenaChildViewBase childView)
		{
			PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass20_0 CS$<>8__locals1 = new PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass20_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.childView = childView;
			UiAsyncTask task = new UiAsyncTask("PhantomArenaRootViewBase", delegate()
			{
				PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass20_0.<<CloseChildView>b__0>d <<CloseChildView>b__0>d;
				<<CloseChildView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CloseChildView>b__0>d.<>4__this = CS$<>8__locals1;
				<<CloseChildView>b__0>d.<>1__state = -1;
				<<CloseChildView>b__0>d.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<>c__DisplayClass20_0.<<CloseChildView>b__0>d>(ref <<CloseChildView>b__0>d);
				return <<CloseChildView>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060352E0 RID: 217824 RVA: 0x00C998D8 File Offset: 0x00C97AD8
		[NullableContext(0)]
		public UniTask<bool> CloseChildViewAsync([Nullable(1)] PhantomArenaChildViewBase childView)
		{
			PhantomArenaRootViewBase<TViewModel>.<CloseChildViewAsync>d__21 <CloseChildViewAsync>d__;
			<CloseChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseChildViewAsync>d__.<>4__this = this;
			<CloseChildViewAsync>d__.childView = childView;
			<CloseChildViewAsync>d__.<>1__state = -1;
			<CloseChildViewAsync>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<CloseChildViewAsync>d__21>(ref <CloseChildViewAsync>d__);
			return <CloseChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352E1 RID: 217825 RVA: 0x00C99923 File Offset: 0x00C97B23
		protected PhantomArenaChildViewBase GetCurChildView()
		{
			return this.ChildViewStack.Peek();
		}

		// Token: 0x060352E2 RID: 217826 RVA: 0x00C99930 File Offset: 0x00C97B30
		public void Back()
		{
			if (this.ChildViewStack.Size > 1)
			{
				this.CloseCurChildView();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0401C521 RID: 116001
		public TViewModel ViewModel;

		// Token: 0x0401C522 RID: 116002
		public int ActivityId;

		// Token: 0x0401C523 RID: 116003
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x0401C524 RID: 116004
		protected EPhantomArenaChildViewName? DefaultChildViewName;

		// Token: 0x0401C525 RID: 116005
		private readonly Stack<PhantomArenaChildViewBase> ChildViewStack = new Stack<PhantomArenaChildViewBase>();

		// Token: 0x0401C526 RID: 116006
		protected UiMask ViewMask = new UiMask();
	}
}
