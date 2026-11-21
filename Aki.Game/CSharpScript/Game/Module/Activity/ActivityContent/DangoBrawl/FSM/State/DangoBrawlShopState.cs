using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057E0 RID: 22496
	public class DangoBrawlShopState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x0603785F RID: 227423 RVA: 0x00F84E19 File Offset: 0x00F83019
		public override void Enter(EDangoBrawlFsmState? prev)
		{
		}

		// Token: 0x06037860 RID: 227424 RVA: 0x00F84E1C File Offset: 0x00F8301C
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlShopState.<EnterAsync>d__2 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.<>4__this = this;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlShopState.<EnterAsync>d__2>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037861 RID: 227425 RVA: 0x00F84E5F File Offset: 0x00F8305F
		private void OnWorldDone()
		{
			this.UnsubscribeWorldDone();
			this.LoadEntityResource();
			this.OpenShopViewThenReleaseAsync().Forget();
		}

		// Token: 0x06037862 RID: 227426 RVA: 0x00F84E78 File Offset: 0x00F83078
		private UniTask OpenShopViewThenReleaseAsync()
		{
			DangoBrawlShopState.<OpenShopViewThenReleaseAsync>d__4 <OpenShopViewThenReleaseAsync>d__;
			<OpenShopViewThenReleaseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShopViewThenReleaseAsync>d__.<>4__this = this;
			<OpenShopViewThenReleaseAsync>d__.<>1__state = -1;
			<OpenShopViewThenReleaseAsync>d__.<>t__builder.Start<DangoBrawlShopState.<OpenShopViewThenReleaseAsync>d__4>(ref <OpenShopViewThenReleaseAsync>d__);
			return <OpenShopViewThenReleaseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037863 RID: 227427 RVA: 0x00F84EBC File Offset: 0x00F830BC
		private UniTask OpenShopViewAsync()
		{
			DangoBrawlShopState.<OpenShopViewAsync>d__5 <OpenShopViewAsync>d__;
			<OpenShopViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShopViewAsync>d__.<>1__state = -1;
			<OpenShopViewAsync>d__.<>t__builder.Start<DangoBrawlShopState.<OpenShopViewAsync>d__5>(ref <OpenShopViewAsync>d__);
			return <OpenShopViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037864 RID: 227428 RVA: 0x00F84EF7 File Offset: 0x00F830F7
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}

		// Token: 0x06037865 RID: 227429 RVA: 0x00F84EFC File Offset: 0x00F830FC
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

		// Token: 0x06037866 RID: 227430 RVA: 0x00F84F47 File Offset: 0x00F83147
		private void UnsubscribeWorldDone()
		{
			if (this.WorldDoneSubscribed)
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
				this.WorldDoneSubscribed = false;
			}
		}

		// Token: 0x06037867 RID: 227431 RVA: 0x00F84F74 File Offset: 0x00F83174
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

		// Token: 0x0401D4A0 RID: 119968
		private bool WorldDoneSubscribed;
	}
}
