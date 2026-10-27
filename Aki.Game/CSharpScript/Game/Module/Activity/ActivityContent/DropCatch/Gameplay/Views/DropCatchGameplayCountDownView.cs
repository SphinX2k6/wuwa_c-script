using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x020066F2 RID: 26354
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayCountDownView : UiPanelBase
	{
		// Token: 0x06041DB1 RID: 269745 RVA: 0x00FF87BA File Offset: 0x00FF69BA
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
		}

		// Token: 0x06041DB2 RID: 269746 RVA: 0x00FF87E4 File Offset: 0x00FF69E4
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x06041DB3 RID: 269747 RVA: 0x00FF8810 File Offset: 0x00FF6A10
		[NullableContext(1)]
		private void OnEndSequence(string sequenceName)
		{
			this.IsFinished = true;
			base.Destroy(null);
		}

		// Token: 0x06041DB4 RID: 269748 RVA: 0x00FF8820 File Offset: 0x00FF6A20
		public void Pause()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PauseSequence();
		}

		// Token: 0x06041DB5 RID: 269749 RVA: 0x00FF8832 File Offset: 0x00FF6A32
		public void Resume()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.ResumeSequence();
		}

		// Token: 0x06041DB6 RID: 269750 RVA: 0x00FF8844 File Offset: 0x00FF6A44
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

		// Token: 0x040224D1 RID: 140497
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040224D2 RID: 140498
		public Action CloseCallback;

		// Token: 0x040224D3 RID: 140499
		private bool IsFinished;
	}
}
