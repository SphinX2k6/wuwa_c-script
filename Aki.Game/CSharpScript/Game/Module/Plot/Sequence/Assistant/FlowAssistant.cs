using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02003FFB RID: 16379
	public class FlowAssistant : SeqBaseAssistant
	{
		// Token: 0x0602974E RID: 169806 RVA: 0x00BB0140 File Offset: 0x00BAE340
		[NullableContext(2)]
		public override void PreAllPlay(Action<bool> callback = null)
		{
			this.Model.SubSeqLen = new int?(this.Model.SequenceData.剧情资源.Num());
			this.Model.LastIndex = 0;
			this.Model.SubSeqIndex = 0;
			this.Model.NextIndex = 0;
		}

		// Token: 0x0602974F RID: 169807 RVA: 0x00BB0198 File Offset: 0x00BAE398
		public override void PreEachPlay()
		{
			this.Model.NextIndex++;
			int nextIndex = this.Model.NextIndex;
			int? subSeqLen = this.Model.SubSeqLen;
			if (nextIndex == subSeqLen.GetValueOrDefault() & subSeqLen != null)
			{
				this.Model.NextIndex = -1;
			}
		}

		// Token: 0x06029750 RID: 169808 RVA: 0x00BB01EE File Offset: 0x00BAE3EE
		public override void EachStop()
		{
			this.Model.LastIndex = this.Model.SubSeqIndex;
			this.Model.SubSeqIndex = this.Model.NextIndex;
		}

		// Token: 0x06029751 RID: 169809 RVA: 0x00BB021C File Offset: 0x00BAE41C
		public void SetNextSequenceIndex(int index)
		{
			this.Model.NextIndex = index;
		}
	}
}
