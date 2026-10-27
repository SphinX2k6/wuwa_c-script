using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02005030 RID: 20528
	public class FlowAssistant : SeqBaseAssistant
	{
		// Token: 0x060348A1 RID: 215201 RVA: 0x00C64704 File Offset: 0x00C62904
		[NullableContext(2)]
		public override void PreAllPlay(Action<bool> callback = null)
		{
			this.Model.SubSeqLen = new int?(this.Model.SequenceData.剧情资源.Num());
			this.Model.LastIndex = 0;
			this.Model.SubSeqIndex = 0;
			this.Model.NextIndex = 0;
		}

		// Token: 0x060348A2 RID: 215202 RVA: 0x00C6475C File Offset: 0x00C6295C
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

		// Token: 0x060348A3 RID: 215203 RVA: 0x00C647B2 File Offset: 0x00C629B2
		public override void EachStop()
		{
			this.Model.LastIndex = this.Model.SubSeqIndex;
			this.Model.SubSeqIndex = this.Model.NextIndex;
		}

		// Token: 0x060348A4 RID: 215204 RVA: 0x00C647E0 File Offset: 0x00C629E0
		public void SetNextSequenceIndex(int index)
		{
			this.Model.NextIndex = index;
		}
	}
}
