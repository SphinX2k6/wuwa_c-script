using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006333 RID: 25395
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMainChildViewBase : UiPanelBase, GuideDefine.ICustomTabViewForGuide
	{
		// Token: 0x0603FE39 RID: 261689 RVA: 0x00F74ED5 File Offset: 0x00F730D5
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x0603FE3A RID: 261690 RVA: 0x00F74ED7 File Offset: 0x00F730D7
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603FE3B RID: 261691 RVA: 0x00F74EDE File Offset: 0x00F730DE
		protected virtual UniTask OnPlayingShowSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603FE3C RID: 261692 RVA: 0x00F74EE5 File Offset: 0x00F730E5
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603FE3D RID: 261693 RVA: 0x00F74EEC File Offset: 0x00F730EC
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603FE3E RID: 261694 RVA: 0x00F74EF3 File Offset: 0x00F730F3
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x0603FE3F RID: 261695 RVA: 0x00F74EF5 File Offset: 0x00F730F5
		protected override void OnStartImplement()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.FirstShow = true;
		}

		// Token: 0x0603FE40 RID: 261696 RVA: 0x00F74F0F File Offset: 0x00F7310F
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, this.ViewName);
		}

		// Token: 0x0603FE41 RID: 261697 RVA: 0x00F74F30 File Offset: 0x00F73130
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PinballMainChildViewBase.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PinballMainChildViewBase.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE42 RID: 261698 RVA: 0x00F74F74 File Offset: 0x00F73174
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PinballMainChildViewBase.<OnHideAsyncImplementImplement>d__15 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PinballMainChildViewBase.<OnHideAsyncImplementImplement>d__15>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE43 RID: 261699 RVA: 0x00F74FB7 File Offset: 0x00F731B7
		protected override void OnAfterHideImplement()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x0603FE44 RID: 261700 RVA: 0x00F74FBF File Offset: 0x00F731BF
		public void OpenChildView(string viewName)
		{
			this.RootView.OpenChildView(viewName);
		}

		// Token: 0x0603FE45 RID: 261701 RVA: 0x00F74FD0 File Offset: 0x00F731D0
		public UniTask OpenChildViewAsync(string viewName)
		{
			PinballMainChildViewBase.<OpenChildViewAsync>d__18 <OpenChildViewAsync>d__;
			<OpenChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewAsync>d__.<>4__this = this;
			<OpenChildViewAsync>d__.viewName = viewName;
			<OpenChildViewAsync>d__.<>1__state = -1;
			<OpenChildViewAsync>d__.<>t__builder.Start<PinballMainChildViewBase.<OpenChildViewAsync>d__18>(ref <OpenChildViewAsync>d__);
			return <OpenChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE46 RID: 261702 RVA: 0x00F7501C File Offset: 0x00F7321C
		[NullableContext(0)]
		public override UniTask<bool> CloseMeAsync()
		{
			PinballMainChildViewBase.<CloseMeAsync>d__19 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<PinballMainChildViewBase.<CloseMeAsync>d__19>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE47 RID: 261703 RVA: 0x00F7505F File Offset: 0x00F7325F
		public void CloseMe()
		{
			this.RootView.CloseCurChildView();
		}

		// Token: 0x0603FE48 RID: 261704 RVA: 0x00F7506C File Offset: 0x00F7326C
		public string GetViewName()
		{
			return this.ViewName ?? "";
		}

		// Token: 0x0603FE49 RID: 261705 RVA: 0x00F7507D File Offset: 0x00F7327D
		public void BackToLastView()
		{
			this.RootView.Back();
		}

		// Token: 0x0603FE4A RID: 261706 RVA: 0x00F7508A File Offset: 0x00F7328A
		public void PlayRootSequence(string sequenceName)
		{
			this.RootView.PlaySequenceByName(sequenceName);
		}

		// Token: 0x0603FE4B RID: 261707 RVA: 0x00F75098 File Offset: 0x00F73298
		public UniTask PlayRootSequenceAsync(string sequenceName)
		{
			PinballMainChildViewBase.<PlayRootSequenceAsync>d__24 <PlayRootSequenceAsync>d__;
			<PlayRootSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRootSequenceAsync>d__.<>4__this = this;
			<PlayRootSequenceAsync>d__.sequenceName = sequenceName;
			<PlayRootSequenceAsync>d__.<>1__state = -1;
			<PlayRootSequenceAsync>d__.<>t__builder.Start<PinballMainChildViewBase.<PlayRootSequenceAsync>d__24>(ref <PlayRootSequenceAsync>d__);
			return <PlayRootSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04021540 RID: 136512
		[Nullable(2)]
		public PinballMainRootViewBase RootView;

		// Token: 0x04021541 RID: 136513
		[Nullable(2)]
		public object ViewModel;

		// Token: 0x04021542 RID: 136514
		[Nullable(2)]
		public string ViewName;

		// Token: 0x04021543 RID: 136515
		public int ActivityId;

		// Token: 0x04021544 RID: 136516
		[Nullable(2)]
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x04021545 RID: 136517
		private bool FirstShow;
	}
}
