using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B1 RID: 24753
	public class IActorFxEmotePlayT
	{
		// Token: 0x1700B66B RID: 46699
		// (get) Token: 0x0602A428 RID: 173096 RVA: 0x005D3681 File Offset: 0x005D1881
		// (set) Token: 0x0602A429 RID: 173097 RVA: 0x005D3689 File Offset: 0x005D1889
		public EActorFxEmoteType Type { get; set; }

		// Token: 0x1700B66C RID: 46700
		// (get) Token: 0x0602A42A RID: 173098 RVA: 0x005D3692 File Offset: 0x005D1892
		// (set) Token: 0x0602A42B RID: 173099 RVA: 0x005D369A File Offset: 0x005D189A
		public long FxEmoteId { get; set; }

		// Token: 0x1700B66D RID: 46701
		// (get) Token: 0x0602A42C RID: 173100 RVA: 0x005D36A3 File Offset: 0x005D18A3
		// (set) Token: 0x0602A42D RID: 173101 RVA: 0x005D36AB File Offset: 0x005D18AB
		public IActorFxEmoteOverrideConfigT OverrideConfig { get; set; }

		// Token: 0x1700B66E RID: 46702
		// (get) Token: 0x0602A42E RID: 173102 RVA: 0x005D36B4 File Offset: 0x005D18B4
		// (set) Token: 0x0602A42F RID: 173103 RVA: 0x005D36BC File Offset: 0x005D18BC
		public float DelayTime { get; set; }

		// Token: 0x1700B66F RID: 46703
		// (get) Token: 0x0602A430 RID: 173104 RVA: 0x005D36C5 File Offset: 0x005D18C5
		// (set) Token: 0x0602A431 RID: 173105 RVA: 0x005D36CD File Offset: 0x005D18CD
		public bool LoopPlay { get; set; }

		// Token: 0x1700B670 RID: 46704
		// (get) Token: 0x0602A432 RID: 173106 RVA: 0x005D36D6 File Offset: 0x005D18D6
		// (set) Token: 0x0602A433 RID: 173107 RVA: 0x005D36DE File Offset: 0x005D18DE
		public bool KeepPlay { get; set; }

		// Token: 0x1700B671 RID: 46705
		// (get) Token: 0x0602A434 RID: 173108 RVA: 0x005D36E7 File Offset: 0x005D18E7
		// (set) Token: 0x0602A435 RID: 173109 RVA: 0x005D36EF File Offset: 0x005D18EF
		public byte NullMask { get; set; }

		// Token: 0x0602A436 RID: 173110 RVA: 0x005D36F8 File Offset: 0x005D18F8
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
