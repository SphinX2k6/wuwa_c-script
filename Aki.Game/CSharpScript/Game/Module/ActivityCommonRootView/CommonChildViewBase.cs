using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.ActivityCommonRootView
{
	// Token: 0x02005A88 RID: 23176
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonChildViewBase : UiPanelBase
	{
		// Token: 0x17006CCC RID: 27852
		// (get) Token: 0x06039200 RID: 233984 RVA: 0x010003ED File Offset: 0x00FFE5ED
		// (set) Token: 0x06039201 RID: 233985 RVA: 0x010003F5 File Offset: 0x00FFE5F5
		public ECommonChildViewName? ViewName { get; set; }

		// Token: 0x17006CCD RID: 27853
		// (get) Token: 0x06039202 RID: 233986 RVA: 0x010003FE File Offset: 0x00FFE5FE
		public virtual bool ShouldKeepInStack
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06039203 RID: 233987 RVA: 0x01000401 File Offset: 0x00FFE601
		public virtual void OnReopen()
		{
		}

		// Token: 0x06039204 RID: 233988 RVA: 0x01000403 File Offset: 0x00FFE603
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x06039205 RID: 233989 RVA: 0x01000405 File Offset: 0x00FFE605
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x06039206 RID: 233990 RVA: 0x01000407 File Offset: 0x00FFE607
		public virtual void OnTick(float delta)
		{
		}

		// Token: 0x06039207 RID: 233991 RVA: 0x01000409 File Offset: 0x00FFE609
		protected virtual UniTask OnPlayingStartSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06039208 RID: 233992 RVA: 0x01000410 File Offset: 0x00FFE610
		protected virtual UniTask OnPlayingShowSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06039209 RID: 233993 RVA: 0x01000417 File Offset: 0x00FFE617
		protected virtual UniTask OnPlayingHideSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603920A RID: 233994 RVA: 0x0100041E File Offset: 0x00FFE61E
		protected virtual UniTask OnPlayingCloseSequenceAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603920B RID: 233995 RVA: 0x01000425 File Offset: 0x00FFE625
		protected override void OnStartImplement()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.FirstShow = true;
		}

		// Token: 0x0603920C RID: 233996 RVA: 0x0100043F File Offset: 0x00FFE63F
		protected override void OnBeforeShowImplement()
		{
			this.OnAddEventListener();
		}

		// Token: 0x0603920D RID: 233997 RVA: 0x01000448 File Offset: 0x00FFE648
		protected override UniTask OnShowAsyncImplementImplement()
		{
			CommonChildViewBase.<OnShowAsyncImplementImplement>d__20 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CommonChildViewBase.<OnShowAsyncImplementImplement>d__20>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603920E RID: 233998 RVA: 0x0100048C File Offset: 0x00FFE68C
		protected override UniTask OnHideAsyncImplementImplement()
		{
			CommonChildViewBase.<OnHideAsyncImplementImplement>d__21 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<CommonChildViewBase.<OnHideAsyncImplementImplement>d__21>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603920F RID: 233999 RVA: 0x010004CF File Offset: 0x00FFE6CF
		protected override void OnAfterHideImplement()
		{
			this.OnRemoveEventListener();
		}

		// Token: 0x06039210 RID: 234000 RVA: 0x010004D7 File Offset: 0x00FFE6D7
		public void OpenChildView(ECommonChildViewName viewName)
		{
			this.RootView.OpenChildView(viewName, null);
		}

		// Token: 0x06039211 RID: 234001 RVA: 0x010004E8 File Offset: 0x00FFE6E8
		public UniTask OpenChildViewAsync(ECommonChildViewName viewName)
		{
			CommonChildViewBase.<OpenChildViewAsync>d__24 <OpenChildViewAsync>d__;
			<OpenChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildViewAsync>d__.<>4__this = this;
			<OpenChildViewAsync>d__.viewName = viewName;
			<OpenChildViewAsync>d__.<>1__state = -1;
			<OpenChildViewAsync>d__.<>t__builder.Start<CommonChildViewBase.<OpenChildViewAsync>d__24>(ref <OpenChildViewAsync>d__);
			return <OpenChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039212 RID: 234002 RVA: 0x01000534 File Offset: 0x00FFE734
		[NullableContext(0)]
		public override UniTask<bool> CloseMeAsync()
		{
			CommonChildViewBase.<CloseMeAsync>d__25 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<CommonChildViewBase.<CloseMeAsync>d__25>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039213 RID: 234003 RVA: 0x01000577 File Offset: 0x00FFE777
		public void CloseMe()
		{
			this.RootView.CloseCurChildView();
		}

		// Token: 0x06039214 RID: 234004 RVA: 0x01000584 File Offset: 0x00FFE784
		public string GetViewName()
		{
			ECommonChildViewName? ecommonChildViewName;
			return ((this.ViewName != null) ? ecommonChildViewName.GetValueOrDefault().ToString() : null) ?? "";
		}

		// Token: 0x06039215 RID: 234005 RVA: 0x010005C2 File Offset: 0x00FFE7C2
		public void BackToLastView()
		{
			this.RootView.Back();
		}

		// Token: 0x0401E0F2 RID: 123122
		public ICommonRootViewBase RootView;

		// Token: 0x0401E0F3 RID: 123123
		public ICommonRootViewModel ViewModel;

		// Token: 0x0401E0F5 RID: 123125
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0401E0F6 RID: 123126
		private bool FirstShow = true;
	}
}
