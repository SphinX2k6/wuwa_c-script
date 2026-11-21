using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E2F RID: 20015
	[NullableContext(2)]
	[Nullable(0)]
	public class WeaknessBreakItem : UiPanelBase
	{
		// Token: 0x060325D5 RID: 206293 RVA: 0x00E20B78 File Offset: 0x00E1ED78
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

		// Token: 0x060325D6 RID: 206294 RVA: 0x00E20BC3 File Offset: 0x00E1EDC3
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060325D7 RID: 206295 RVA: 0x00E20BD6 File Offset: 0x00E1EDD6
		public void Play()
		{
			if (this.IsPlaying)
			{
				return;
			}
			this.IsPlaying = true;
			base.Show(null);
		}

		// Token: 0x060325D8 RID: 206296 RVA: 0x00E20BF0 File Offset: 0x00E1EDF0
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

		// Token: 0x060325D9 RID: 206297 RVA: 0x00E20C4D File Offset: 0x00E1EE4D
		private void OnBreakingTimerEnd(float _)
		{
			this.BreakingTimer = null;
			this.IsPlaying = false;
			base.Hide(null);
		}

		// Token: 0x060325DA RID: 206298 RVA: 0x00E20C64 File Offset: 0x00E1EE64
		private void RemoveBreakingTimer()
		{
			if (this.BreakingTimer != null)
			{
				TimerSystem.Instance.Remove(this.BreakingTimer);
				this.BreakingTimer = null;
			}
		}

		// Token: 0x060325DB RID: 206299 RVA: 0x00E20C86 File Offset: 0x00E1EE86
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

		// Token: 0x0401AB5A RID: 109402
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401AB5B RID: 109403
		private bool IsPlaying;

		// Token: 0x0401AB5C RID: 109404
		private TimerHandle BreakingTimer;
	}
}
