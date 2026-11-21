using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02005F6B RID: 24427
	public class AstrologyLineView : UiPanelBase
	{
		// Token: 0x0603ABEE RID: 240622 RVA: 0x0109CEFE File Offset: 0x0109B0FE
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0603ABEF RID: 240623 RVA: 0x0109CF28 File Offset: 0x0109B128
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603ABF0 RID: 240624 RVA: 0x0109CF42 File Offset: 0x0109B142
		[NullableContext(1)]
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0603ABF1 RID: 240625 RVA: 0x0109CF58 File Offset: 0x0109B158
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

		// Token: 0x0401EE27 RID: 126503
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401EE28 RID: 126504
		private bool IsActive;
	}
}
