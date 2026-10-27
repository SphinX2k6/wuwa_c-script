using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E3 RID: 20963
	[NullableContext(1)]
	[Nullable(0)]
	public class CardCommonComponent : CardComponentBase
	{
		// Token: 0x06035A2E RID: 219694 RVA: 0x00CB4CB5 File Offset: 0x00CB2EB5
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06035A2F RID: 219695 RVA: 0x00CB4CDF File Offset: 0x00CB2EDF
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035A30 RID: 219696 RVA: 0x00CB4CEC File Offset: 0x00CB2EEC
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close".ToString())
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035A31 RID: 219697 RVA: 0x00CB4D07 File Offset: 0x00CB2F07
		public void SetComponentActive(bool isActive)
		{
			this.Sequence.StopPrevSequence(false, true);
			if (isActive)
			{
				this.SetActive(true);
				this.Sequence.PlaySequencePurely("Start", false, false);
				return;
			}
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x06035A32 RID: 219698 RVA: 0x00CB4D45 File Offset: 0x00CB2F45
		public void SetComponentDisActiveWithoutSequence()
		{
			this.SetActive(false);
		}

		// Token: 0x06035A33 RID: 219699 RVA: 0x00CB4D4E File Offset: 0x00CB2F4E
		public override void Refresh(object data)
		{
		}

		// Token: 0x0401C768 RID: 116584
		protected UiSequencePlayer Sequence;
	}
}
