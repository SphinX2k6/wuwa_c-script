using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02006DEC RID: 28140
	public class AstrologyLineView : UiPanelBase
	{
		// Token: 0x06044A8A RID: 281226 RVA: 0x010F2CB2 File Offset: 0x010F0EB2
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06044A8B RID: 281227 RVA: 0x010F2CDC File Offset: 0x010F0EDC
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06044A8C RID: 281228 RVA: 0x010F2CF6 File Offset: 0x010F0EF6
		[NullableContext(1)]
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06044A8D RID: 281229 RVA: 0x010F2D0C File Offset: 0x010F0F0C
		public void SetLineActive(bool isActive)
		{
			if (isActive == this.IsActive)
			{
				return;
			}
			this.IsActive = isActive;
			this.SequencePlayer.StopPrevSequence(false, true);
			if (isActive)
			{
				this.SetActive(true);
				this.SequencePlayer.PlaySequencePurely("Start", false, false);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x04023B85 RID: 146309
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04023B86 RID: 146310
		private bool IsActive;
	}
}
