using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E4A RID: 24138
	[NullableContext(2)]
	[Nullable(0)]
	public class WeaknessBreakItem : UiPanelBase
	{
		// Token: 0x0603D645 RID: 251461 RVA: 0x00ECF608 File Offset: 0x00ECD808
		[NullableContext(1)]
		public UniTask InitializeAsync(UUIItem parentItem)
		{
			WeaknessBreakItem.<InitializeAsync>d__3 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.parentItem = parentItem;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<WeaknessBreakItem.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D646 RID: 251462 RVA: 0x00ECF653 File Offset: 0x00ECD853
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603D647 RID: 251463 RVA: 0x00ECF666 File Offset: 0x00ECD866
		public void Play()
		{
			if (this.IsPlaying)
			{
				return;
			}
			this.IsPlaying = true;
			base.Show(null);
		}

		// Token: 0x0603D648 RID: 251464 RVA: 0x00ECF680 File Offset: 0x00ECD880
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
			this.RemoveBreakingTimer();
			this.BreakingTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnBreakingTimerEnd), 2000f, null, null, true, 1f);
		}

		// Token: 0x0603D649 RID: 251465 RVA: 0x00ECF6DD File Offset: 0x00ECD8DD
		private void OnBreakingTimerEnd(float _)
		{
			this.BreakingTimer = null;
			this.IsPlaying = false;
			base.Hide(null);
		}

		// Token: 0x0603D64A RID: 251466 RVA: 0x00ECF6F4 File Offset: 0x00ECD8F4
		private void RemoveBreakingTimer()
		{
			if (this.BreakingTimer != null)
			{
				TimerSystem.Instance.Remove(this.BreakingTimer);
				this.BreakingTimer = null;
			}
		}

		// Token: 0x0603D64B RID: 251467 RVA: 0x00ECF716 File Offset: 0x00ECD916
		protected override void OnBeforeHide()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopPlayingSequence(false, true);
			}
			this.IsPlaying = false;
			this.RemoveBreakingTimer();
		}

		// Token: 0x04020093 RID: 131219
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020094 RID: 131220
		private bool IsPlaying;

		// Token: 0x04020095 RID: 131221
		private TimerHandle BreakingTimer;
	}
}
