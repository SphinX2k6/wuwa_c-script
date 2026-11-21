using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004119 RID: 16665
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaRootViewBase<[Nullable(0)] TViewModel> : UiViewBase, IPhantomArenaRootViewBase where TViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x0602A1CD RID: 172493 RVA: 0x00BE6B07 File Offset: 0x00BE4D07
		public PhantomArenaRootViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A1CE RID: 172494 RVA: 0x00BE6B26 File Offset: 0x00BE4D26
		protected override void OnBeforeCreate()
		{
			this.OnRegisterViewData();
			this.OnRegisterDefaultChildView();
		}

		// Token: 0x0602A1CF RID: 172495
		protected abstract void OnRegisterDefaultChildView();

		// Token: 0x0602A1D0 RID: 172496
		protected abstract void OnRegisterContentItem();

		// Token: 0x0602A1D1 RID: 172497
		protected abstract void OnRegisterViewData();

		// Token: 0x0602A1D2 RID: 172498 RVA: 0x00BE6B34 File Offset: 0x00BE4D34
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A1D3 RID: 172499 RVA: 0x00BE6B78 File Offset: 0x00BE4D78
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnShowAsyncImplementImplement>d__12 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnShowAsyncImplementImplement>d__12>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A1D4 RID: 172500 RVA: 0x00BE6BBC File Offset: 0x00BE4DBC
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnHideAsyncImplementImplement>d__13 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnHideAsyncImplementImplement>d__13>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A1D5 RID: 172501 RVA: 0x00BE6C00 File Offset: 0x00BE4E00
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			PhantomArenaRootViewBase<TViewModel>.<OnDestroyAsyncImplementImplement>d__14 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaRootViewBase<TViewModel>.<OnDestroyAsyncImplementImplement>d__14>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A1D6 RID: 172502 RVA: 0x00BE6C44 File Offset: 0x00BE4E44
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

		// Token: 0x0602A1D7 RID: 172503 RVA: 0x00BE6C90 File Offset: 0x00BE4E90
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

		// Token: 0x0602A1D8 RID: 172504 RVA: 0x00BE6CD4 File Offset: 0x00BE4ED4
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

		// Token: 0x0602A1D9 RID: 172505 RVA: 0x00BE6D20 File Offset: 0x00BE4F20
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

		// Token: 0x0602A1DA RID: 172506 RVA: 0x00BE6D50 File Offset: 0x00BE4F50
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

		// Token: 0x0602A1DB RID: 172507 RVA: 0x00BE6D94 File Offset: 0x00BE4F94
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

		// Token: 0x0602A1DC RID: 172508 RVA: 0x00BE6DD8 File Offset: 0x00BE4FD8
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

		// Token: 0x0602A1DD RID: 172509 RVA: 0x00BE6E23 File Offset: 0x00BE5023
		protected PhantomArenaChildViewBase GetCurChildView()
		{
			return this.ChildViewStack.Peek();
		}

		// Token: 0x0602A1DE RID: 172510 RVA: 0x00BE6E30 File Offset: 0x00BE5030
		public void Back()
		{
			if (this.ChildViewStack.Size > 1)
			{
				this.CloseCurChildView();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x04016F56 RID: 94038
		public TViewModel ViewModel;

		// Token: 0x04016F57 RID: 94039
		public int ActivityId;

		// Token: 0x04016F58 RID: 94040
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x04016F59 RID: 94041
		protected EPhantomArenaChildViewName? DefaultChildViewName;

		// Token: 0x04016F5A RID: 94042
		private readonly Stack<PhantomArenaChildViewBase> ChildViewStack = new Stack<PhantomArenaChildViewBase>();

		// Token: 0x04016F5B RID: 94043
		protected UiMask ViewMask = new UiMask();
	}
}
