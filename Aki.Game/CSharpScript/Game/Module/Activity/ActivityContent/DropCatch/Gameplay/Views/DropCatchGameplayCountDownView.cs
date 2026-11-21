using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005642 RID: 22082
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayCountDownView : UiPanelBase
	{
		// Token: 0x060368FD RID: 223485 RVA: 0x00F39BAE File Offset: 0x00F37DAE
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
		}

		// Token: 0x060368FE RID: 223486 RVA: 0x00F39BD8 File Offset: 0x00F37DD8
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x060368FF RID: 223487 RVA: 0x00F39C04 File Offset: 0x00F37E04
		[NullableContext(1)]
		private void OnEndSequence(string sequenceName)
		{
			this.IsFinished = true;
			base.Destroy(null);
		}

		// Token: 0x06036900 RID: 223488 RVA: 0x00F39C14 File Offset: 0x00F37E14
		public void Pause()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PauseSequence();
		}

		// Token: 0x06036901 RID: 223489 RVA: 0x00F39C26 File Offset: 0x00F37E26
		public void Resume()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.ResumeSequence();
		}

		// Token: 0x06036902 RID: 223490 RVA: 0x00F39C38 File Offset: 0x00F37E38
		protected override void OnBeforeDestroy()
		{
			if (this.IsFinished)
			{
				Action closeCallback = this.CloseCallback;
				if (closeCallback != null)
				{
					closeCallback();
				}
			}
			this.CloseCallback = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0401CD2A RID: 118058
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401CD2B RID: 118059
		public Action CloseCallback;

		// Token: 0x0401CD2C RID: 118060
		private bool IsFinished;
	}
}
