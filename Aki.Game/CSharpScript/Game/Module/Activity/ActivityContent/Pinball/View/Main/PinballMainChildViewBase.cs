using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B1 RID: 21169
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMainChildViewBase : UiPanelBase, GuideDefine.ICustomTabViewForGuide
	{
		// Token: 0x06034AFA RID: 215802 RVA: 0x00EBBE31 File Offset: 0x00EBA031
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x06034AFB RID: 215803 RVA: 0x00EBBE33 File Offset: 0x00EBA033
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034AFC RID: 215804 RVA: 0x00EBBE3A File Offset: 0x00EBA03A
		protected virtual UniTask OnPlayingShowSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034AFD RID: 215805 RVA: 0x00EBBE41 File Offset: 0x00EBA041
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034AFE RID: 215806 RVA: 0x00EBBE48 File Offset: 0x00EBA048
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06034AFF RID: 215807 RVA: 0x00EBBE4F File Offset: 0x00EBA04F
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x06034B00 RID: 215808 RVA: 0x00EBBE51 File Offset: 0x00EBA051
		protected override void OnStartImplement()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.FirstShow = true;
		}

		// Token: 0x06034B01 RID: 215809 RVA: 0x00EBBE6B File Offset: 0x00EBA06B
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, this.ViewName);
		}

		// Token: 0x06034B02 RID: 215810 RVA: 0x00EBBE8C File Offset: 0x00EBA08C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PinballMainChildViewBase.<OnShowAsyncImplementImplement>d__14 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PinballMainChildViewBase.<OnShowAsyncImplementImplement>d__14>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034B03 RID: 215811 RVA: 0x00EBBED0 File Offset: 0x00EBA0D0
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PinballMainChildViewBase.<OnHideAsyncImplementImplement>d__15 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PinballMainChildViewBase.<OnHideAsyncImplementImplement>d__15>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034B04 RID: 215812 RVA: 0x00EBBF13 File Offset: 0x00EBA113
		protected override void OnAfterHideImplement()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x06034B05 RID: 215813 RVA: 0x00EBBF1B File Offset: 0x00EBA11B
		public void OpenChildView(string viewName)
		{
			this.RootView.OpenChildView(viewName);
		}

		// Token: 0x06034B06 RID: 215814 RVA: 0x00EBBF2C File Offset: 0x00EBA12C
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

		// Token: 0x06034B07 RID: 215815 RVA: 0x00EBBF78 File Offset: 0x00EBA178
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

		// Token: 0x06034B08 RID: 215816 RVA: 0x00EBBFBB File Offset: 0x00EBA1BB
		public void CloseMe()
		{
			this.RootView.CloseCurChildView();
		}

		// Token: 0x06034B09 RID: 215817 RVA: 0x00EBBFC8 File Offset: 0x00EBA1C8
		public string GetViewName()
		{
			return this.ViewName ?? "";
		}

		// Token: 0x06034B0A RID: 215818 RVA: 0x00EBBFD9 File Offset: 0x00EBA1D9
		public void BackToLastView()
		{
			this.RootView.Back();
		}

		// Token: 0x06034B0B RID: 215819 RVA: 0x00EBBFE6 File Offset: 0x00EBA1E6
		public void PlayRootSequence(string sequenceName)
		{
			this.RootView.PlaySequenceByName(sequenceName);
		}

		// Token: 0x06034B0C RID: 215820 RVA: 0x00EBBFF4 File Offset: 0x00EBA1F4
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

		// Token: 0x0401BE6F RID: 114287
		[Nullable(2)]
		public PinballMainRootViewBase RootView;

		// Token: 0x0401BE70 RID: 114288
		[Nullable(2)]
		public object ViewModel;

		// Token: 0x0401BE71 RID: 114289
		[Nullable(2)]
		public string ViewName;

		// Token: 0x0401BE72 RID: 114290
		public int ActivityId;

		// Token: 0x0401BE73 RID: 114291
		[Nullable(2)]
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0401BE74 RID: 114292
		private bool FirstShow;
	}
}
