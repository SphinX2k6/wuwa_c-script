using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004111 RID: 16657
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChildViewBase : UiPanelBase, GuideDefine.ICustomTabViewForGuide
	{
		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x0602A12F RID: 172335 RVA: 0x00BE5B05 File Offset: 0x00BE3D05
		// (set) Token: 0x0602A130 RID: 172336 RVA: 0x00BE5B0D File Offset: 0x00BE3D0D
		public EPhantomArenaChildViewName? ViewName { get; set; }

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x0602A131 RID: 172337 RVA: 0x00BE5B16 File Offset: 0x00BE3D16
		// (set) Token: 0x0602A132 RID: 172338 RVA: 0x00BE5B1E File Offset: 0x00BE3D1E
		public int ActivityId { get; set; }

		// Token: 0x0602A133 RID: 172339 RVA: 0x00BE5B27 File Offset: 0x00BE3D27
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x0602A134 RID: 172340 RVA: 0x00BE5B29 File Offset: 0x00BE3D29
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602A135 RID: 172341 RVA: 0x00BE5B30 File Offset: 0x00BE3D30
		protected virtual UniTask OnPlayingShowSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602A136 RID: 172342 RVA: 0x00BE5B37 File Offset: 0x00BE3D37
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602A137 RID: 172343 RVA: 0x00BE5B3E File Offset: 0x00BE3D3E
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602A138 RID: 172344 RVA: 0x00BE5B45 File Offset: 0x00BE3D45
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x0602A139 RID: 172345 RVA: 0x00BE5B47 File Offset: 0x00BE3D47
		protected override void OnStartImplement()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.FirstShow = true;
			EventSystem.Instance.Emit<string>(EEventName.OnPhantomArenaChildViewOpen, this.GetViewName());
		}

		// Token: 0x0602A13A RID: 172346 RVA: 0x00BE5B77 File Offset: 0x00BE3D77
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
		}

		// Token: 0x0602A13B RID: 172347 RVA: 0x00BE5B80 File Offset: 0x00BE3D80
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PhantomArenaChildViewBase.<OnShowAsyncImplementImplement>d__20 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaChildViewBase.<OnShowAsyncImplementImplement>d__20>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A13C RID: 172348 RVA: 0x00BE5BC4 File Offset: 0x00BE3DC4
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PhantomArenaChildViewBase.<OnHideAsyncImplementImplement>d__21 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaChildViewBase.<OnHideAsyncImplementImplement>d__21>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A13D RID: 172349 RVA: 0x00BE5C07 File Offset: 0x00BE3E07
		protected override void OnAfterHideImplement()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x0602A13E RID: 172350 RVA: 0x00BE5C0F File Offset: 0x00BE3E0F
		public void OpenChildView(EPhantomArenaChildViewName viewName)
		{
			this.RootView.OpenChildView(viewName);
		}

		// Token: 0x0602A13F RID: 172351 RVA: 0x00BE5C20 File Offset: 0x00BE3E20
		public UniTask OpenChildViewAsync(EPhantomArenaChildViewName viewName)
		{
			PhantomArenaChildViewBase.<OpenChildViewAsync>d__24 <OpenChildViewAsync>d__;
			<OpenChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewAsync>d__.<>4__this = this;
			<OpenChildViewAsync>d__.viewName = viewName;
			<OpenChildViewAsync>d__.<>1__state = -1;
			<OpenChildViewAsync>d__.<>t__builder.Start<PhantomArenaChildViewBase.<OpenChildViewAsync>d__24>(ref <OpenChildViewAsync>d__);
			return <OpenChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A140 RID: 172352 RVA: 0x00BE5C6C File Offset: 0x00BE3E6C
		[NullableContext(0)]
		public override UniTask<bool> CloseMeAsync()
		{
			PhantomArenaChildViewBase.<CloseMeAsync>d__25 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<PhantomArenaChildViewBase.<CloseMeAsync>d__25>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A141 RID: 172353 RVA: 0x00BE5CAF File Offset: 0x00BE3EAF
		public void CloseMe()
		{
			this.RootView.CloseCurChildView();
		}

		// Token: 0x0602A142 RID: 172354 RVA: 0x00BE5CBC File Offset: 0x00BE3EBC
		public string GetViewName()
		{
			EPhantomArenaChildViewName? ephantomArenaChildViewName;
			return ((this.ViewName != null) ? ephantomArenaChildViewName.GetValueOrDefault().ToString() : null) ?? "";
		}

		// Token: 0x0602A143 RID: 172355 RVA: 0x00BE5CFA File Offset: 0x00BE3EFA
		public void BackToLastView()
		{
			this.RootView.Back();
		}

		// Token: 0x04016F25 RID: 93989
		public IPhantomArenaRootViewBase RootView;

		// Token: 0x04016F26 RID: 93990
		public IPhantomArenaTabViewModelBase ViewModel;

		// Token: 0x04016F29 RID: 93993
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x04016F2A RID: 93994
		private bool FirstShow = true;
	}
}
