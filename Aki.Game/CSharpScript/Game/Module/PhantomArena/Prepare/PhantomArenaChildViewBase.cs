using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005141 RID: 20801
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaChildViewBase : UiPanelBase, GuideDefine.ICustomTabViewForGuide
	{
		// Token: 0x170080A0 RID: 32928
		// (get) Token: 0x06035233 RID: 217651 RVA: 0x00C98605 File Offset: 0x00C96805
		// (set) Token: 0x06035234 RID: 217652 RVA: 0x00C9860D File Offset: 0x00C9680D
		public EPhantomArenaChildViewName? ViewName { get; set; }

		// Token: 0x170080A1 RID: 32929
		// (get) Token: 0x06035235 RID: 217653 RVA: 0x00C98616 File Offset: 0x00C96816
		// (set) Token: 0x06035236 RID: 217654 RVA: 0x00C9861E File Offset: 0x00C9681E
		public int ActivityId { get; set; }

		// Token: 0x06035237 RID: 217655 RVA: 0x00C98627 File Offset: 0x00C96827
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x06035238 RID: 217656 RVA: 0x00C98629 File Offset: 0x00C96829
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06035239 RID: 217657 RVA: 0x00C98630 File Offset: 0x00C96830
		protected virtual UniTask OnPlayingShowSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603523A RID: 217658 RVA: 0x00C98637 File Offset: 0x00C96837
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603523B RID: 217659 RVA: 0x00C9863E File Offset: 0x00C9683E
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603523C RID: 217660 RVA: 0x00C98645 File Offset: 0x00C96845
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x0603523D RID: 217661 RVA: 0x00C98647 File Offset: 0x00C96847
		protected override void OnStartImplement()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.FirstShow = true;
			EventSystem.Instance.Emit<string>(EEventName.OnPhantomArenaChildViewOpen, this.GetViewName());
		}

		// Token: 0x0603523E RID: 217662 RVA: 0x00C98677 File Offset: 0x00C96877
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
		}

		// Token: 0x0603523F RID: 217663 RVA: 0x00C98680 File Offset: 0x00C96880
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PhantomArenaChildViewBase.<OnShowAsyncImplementImplement>d__20 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaChildViewBase.<OnShowAsyncImplementImplement>d__20>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035240 RID: 217664 RVA: 0x00C986C4 File Offset: 0x00C968C4
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PhantomArenaChildViewBase.<OnHideAsyncImplementImplement>d__21 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaChildViewBase.<OnHideAsyncImplementImplement>d__21>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035241 RID: 217665 RVA: 0x00C98707 File Offset: 0x00C96907
		protected override void OnAfterHideImplement()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x06035242 RID: 217666 RVA: 0x00C9870F File Offset: 0x00C9690F
		public void OpenChildView(EPhantomArenaChildViewName viewName)
		{
			this.RootView.OpenChildView(viewName);
		}

		// Token: 0x06035243 RID: 217667 RVA: 0x00C98720 File Offset: 0x00C96920
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

		// Token: 0x06035244 RID: 217668 RVA: 0x00C9876C File Offset: 0x00C9696C
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

		// Token: 0x06035245 RID: 217669 RVA: 0x00C987AF File Offset: 0x00C969AF
		public void CloseMe()
		{
			this.RootView.CloseCurChildView();
		}

		// Token: 0x06035246 RID: 217670 RVA: 0x00C987BC File Offset: 0x00C969BC
		public string GetViewName()
		{
			EPhantomArenaChildViewName? ephantomArenaChildViewName;
			return ((this.ViewName != null) ? ephantomArenaChildViewName.GetValueOrDefault().ToString() : null) ?? "";
		}

		// Token: 0x06035247 RID: 217671 RVA: 0x00C987FA File Offset: 0x00C969FA
		public void BackToLastView()
		{
			this.RootView.Back();
		}

		// Token: 0x0401C4F0 RID: 115952
		public IPhantomArenaRootViewBase RootView;

		// Token: 0x0401C4F1 RID: 115953
		public IPhantomArenaTabViewModelBase ViewModel;

		// Token: 0x0401C4F4 RID: 115956
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0401C4F5 RID: 115957
		private bool FirstShow = true;
	}
}
