using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x02006890 RID: 26768
	public class DangoBrawlShopState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042D07 RID: 273671 RVA: 0x01043899 File Offset: 0x01041A99
		public override void Enter(EDangoBrawlFsmState? prev)
		{
		}

		// Token: 0x06042D08 RID: 273672 RVA: 0x0104389C File Offset: 0x01041A9C
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlShopState.<EnterAsync>d__2 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.<>4__this = this;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlShopState.<EnterAsync>d__2>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042D09 RID: 273673 RVA: 0x010438DF File Offset: 0x01041ADF
		private void OnWorldDone()
		{
			this.UnsubscribeWorldDone();
			this.LoadEntityResource();
			this.OpenShopViewThenReleaseAsync().Forget();
		}

		// Token: 0x06042D0A RID: 273674 RVA: 0x010438F8 File Offset: 0x01041AF8
		private UniTask OpenShopViewThenReleaseAsync()
		{
			DangoBrawlShopState.<OpenShopViewThenReleaseAsync>d__4 <OpenShopViewThenReleaseAsync>d__;
			<OpenShopViewThenReleaseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShopViewThenReleaseAsync>d__.<>4__this = this;
			<OpenShopViewThenReleaseAsync>d__.<>1__state = -1;
			<OpenShopViewThenReleaseAsync>d__.<>t__builder.Start<DangoBrawlShopState.<OpenShopViewThenReleaseAsync>d__4>(ref <OpenShopViewThenReleaseAsync>d__);
			return <OpenShopViewThenReleaseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042D0B RID: 273675 RVA: 0x0104393C File Offset: 0x01041B3C
		private UniTask OpenShopViewAsync()
		{
			DangoBrawlShopState.<OpenShopViewAsync>d__5 <OpenShopViewAsync>d__;
			<OpenShopViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShopViewAsync>d__.<>1__state = -1;
			<OpenShopViewAsync>d__.<>t__builder.Start<DangoBrawlShopState.<OpenShopViewAsync>d__5>(ref <OpenShopViewAsync>d__);
			return <OpenShopViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042D0C RID: 273676 RVA: 0x01043977 File Offset: 0x01041B77
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}

		// Token: 0x06042D0D RID: 273677 RVA: 0x0104397C File Offset: 0x01041B7C
		public override UniTask ExitAsync(EDangoBrawlFsmState? next)
		{
			DangoBrawlShopState.<ExitAsync>d__7 <ExitAsync>d__;
			<ExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitAsync>d__.<>4__this = this;
			<ExitAsync>d__.next = next;
			<ExitAsync>d__.<>1__state = -1;
			<ExitAsync>d__.<>t__builder.Start<DangoBrawlShopState.<ExitAsync>d__7>(ref <ExitAsync>d__);
			return <ExitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042D0E RID: 273678 RVA: 0x010439C7 File Offset: 0x01041BC7
		private void UnsubscribeWorldDone()
		{
			if (this.WorldDoneSubscribed)
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
				this.WorldDoneSubscribed = false;
			}
		}

		// Token: 0x06042D0F RID: 273679 RVA: 0x010439F4 File Offset: 0x01041BF4
		private void LoadEntityResource()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[ShopState] BattleManager 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			battleManager.LoadEntityResource().Forget();
		}

		// Token: 0x04022C44 RID: 142404
		private bool WorldDoneSubscribed;
	}
}
