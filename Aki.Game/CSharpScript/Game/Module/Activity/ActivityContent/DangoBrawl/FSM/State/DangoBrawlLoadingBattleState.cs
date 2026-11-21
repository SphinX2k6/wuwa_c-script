using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057DE RID: 22494
	public class DangoBrawlLoadingBattleState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06037856 RID: 227414 RVA: 0x00F84BFC File Offset: 0x00F82DFC
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlLoadingBattleState.<EnterAsync>d__0 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.<>4__this = this;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlLoadingBattleState.<EnterAsync>d__0>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037857 RID: 227415 RVA: 0x00F84C40 File Offset: 0x00F82E40
		private void OnWorldDone()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[LoadingBattleState] WorldDone 时 BattleManager 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				ActivityGameplayEntitySystem.FinishEntityReadyPromise(false);
				return;
			}
			this.LoadEntityAndEnterFight(battleManager).Forget();
		}

		// Token: 0x06037858 RID: 227416 RVA: 0x00F84CAC File Offset: 0x00F82EAC
		[NullableContext(1)]
		private UniTask LoadEntityAndEnterFight(DangoBrawlBattleManager manager)
		{
			DangoBrawlLoadingBattleState.<LoadEntityAndEnterFight>d__2 <LoadEntityAndEnterFight>d__;
			<LoadEntityAndEnterFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEntityAndEnterFight>d__.manager = manager;
			<LoadEntityAndEnterFight>d__.<>1__state = -1;
			<LoadEntityAndEnterFight>d__.<>t__builder.Start<DangoBrawlLoadingBattleState.<LoadEntityAndEnterFight>d__2>(ref <LoadEntityAndEnterFight>d__);
			return <LoadEntityAndEnterFight>d__.<>t__builder.Task;
		}

		// Token: 0x06037859 RID: 227417 RVA: 0x00F84CEF File Offset: 0x00F82EEF
		public override void Exit(EDangoBrawlFsmState? next)
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}
	}
}
