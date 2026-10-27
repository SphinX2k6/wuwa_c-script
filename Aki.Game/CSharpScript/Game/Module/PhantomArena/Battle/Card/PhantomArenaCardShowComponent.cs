using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x020052BE RID: 21182
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardShowComponent : UiPanelBase
	{
		// Token: 0x060362EF RID: 221935 RVA: 0x00CD1B1F File Offset: 0x00CCFD1F
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x060362F0 RID: 221936 RVA: 0x00CD1B49 File Offset: 0x00CCFD49
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x060362F1 RID: 221937 RVA: 0x00CD1B56 File Offset: 0x00CCFD56
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

		// Token: 0x060362F2 RID: 221938 RVA: 0x00CD1B88 File Offset: 0x00CCFD88
		public void PlayStart()
		{
			this.SkipDisActive = false;
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x060362F3 RID: 221939 RVA: 0x00CD1BB7 File Offset: 0x00CCFDB7
		public void PlayClose()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x060362F4 RID: 221940 RVA: 0x00CD1BD8 File Offset: 0x00CCFDD8
		public void PlayLoop()
		{
			this.SkipDisActive = true;
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Start", false, false);
			this.Sequence.PlaySequencePurely("Loop", false, false);
		}

		// Token: 0x0401CAA1 RID: 117409
		protected UiSequencePlayer Sequence;

		// Token: 0x0401CAA2 RID: 117410
		protected bool SkipDisActive;
	}
}
