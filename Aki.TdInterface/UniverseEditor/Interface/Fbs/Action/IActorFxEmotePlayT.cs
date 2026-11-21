using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006713 RID: 26387
	public class IActorFxEmotePlayT
	{
		// Token: 0x1700BFD6 RID: 49110
		// (get) Token: 0x0602CB09 RID: 183049 RVA: 0x0061D629 File Offset: 0x0061B829
		// (set) Token: 0x0602CB0A RID: 183050 RVA: 0x0061D631 File Offset: 0x0061B831
		public EActorFxEmoteType Type { get; set; }

		// Token: 0x1700BFD7 RID: 49111
		// (get) Token: 0x0602CB0B RID: 183051 RVA: 0x0061D63A File Offset: 0x0061B83A
		// (set) Token: 0x0602CB0C RID: 183052 RVA: 0x0061D642 File Offset: 0x0061B842
		public long FxEmoteId { get; set; }

		// Token: 0x1700BFD8 RID: 49112
		// (get) Token: 0x0602CB0D RID: 183053 RVA: 0x0061D64B File Offset: 0x0061B84B
		// (set) Token: 0x0602CB0E RID: 183054 RVA: 0x0061D653 File Offset: 0x0061B853
		public IActorFxEmoteOverrideConfigT OverrideConfig { get; set; }

		// Token: 0x1700BFD9 RID: 49113
		// (get) Token: 0x0602CB0F RID: 183055 RVA: 0x0061D65C File Offset: 0x0061B85C
		// (set) Token: 0x0602CB10 RID: 183056 RVA: 0x0061D664 File Offset: 0x0061B864
		public float DelayTime { get; set; }

		// Token: 0x1700BFDA RID: 49114
		// (get) Token: 0x0602CB11 RID: 183057 RVA: 0x0061D66D File Offset: 0x0061B86D
		// (set) Token: 0x0602CB12 RID: 183058 RVA: 0x0061D675 File Offset: 0x0061B875
		public bool LoopPlay { get; set; }

		// Token: 0x1700BFDB RID: 49115
		// (get) Token: 0x0602CB13 RID: 183059 RVA: 0x0061D67E File Offset: 0x0061B87E
		// (set) Token: 0x0602CB14 RID: 183060 RVA: 0x0061D686 File Offset: 0x0061B886
		public bool KeepPlay { get; set; }

		// Token: 0x1700BFDC RID: 49116
		// (get) Token: 0x0602CB15 RID: 183061 RVA: 0x0061D68F File Offset: 0x0061B88F
		// (set) Token: 0x0602CB16 RID: 183062 RVA: 0x0061D697 File Offset: 0x0061B897
		public byte NullMask { get; set; }

		// Token: 0x0602CB17 RID: 183063 RVA: 0x0061D6A0 File Offset: 0x0061B8A0
		public IActorFxEmotePlayT()
		{
			this.Type = EActorFxEmoteType.Play;
			this.FxEmoteId = 0L;
			this.OverrideConfig = null;
			this.DelayTime = 0f;
			this.LoopPlay = false;
			this.KeepPlay = false;
			this.NullMask = 0;
		}
	}
}
