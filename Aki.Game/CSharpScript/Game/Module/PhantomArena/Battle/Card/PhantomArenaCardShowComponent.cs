using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x0200428E RID: 17038
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardShowComponent : UiPanelBase
	{
		// Token: 0x0602B1EA RID: 176618 RVA: 0x00C1F247 File Offset: 0x00C1D447
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602B1EB RID: 176619 RVA: 0x00C1F271 File Offset: 0x00C1D471
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602B1EC RID: 176620 RVA: 0x00C1F27E File Offset: 0x00C1D47E
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Start" && !this.SkipDisActive)
			{
				this.PlayClose();
				return;
			}
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602B1ED RID: 176621 RVA: 0x00C1F2B0 File Offset: 0x00C1D4B0
		public void PlayStart()
		{
			this.SkipDisActive = false;
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0602B1EE RID: 176622 RVA: 0x00C1F2DF File Offset: 0x00C1D4DF
		public void PlayClose()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x0602B1EF RID: 176623 RVA: 0x00C1F300 File Offset: 0x00C1D500
		public void PlayLoop()
		{
			this.SkipDisActive = true;
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Start", false, false);
			this.Sequence.PlaySequencePurely("Loop", false, false);
		}

		// Token: 0x040174D6 RID: 95446
		protected UiSequencePlayer Sequence;

		// Token: 0x040174D7 RID: 95447
		protected bool SkipDisActive;
	}
}
