using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A89 RID: 31369
	public class ITalkEffectStopT
	{
		// Token: 0x1700E5CB RID: 58827
		// (get) Token: 0x060374C3 RID: 226499 RVA: 0x007623F1 File Offset: 0x007605F1
		// (set) Token: 0x060374C4 RID: 226500 RVA: 0x007623F9 File Offset: 0x007605F9
		public ETalkEffectActionType Type { get; set; }

		// Token: 0x1700E5CC RID: 58828
		// (get) Token: 0x060374C5 RID: 226501 RVA: 0x00762402 File Offset: 0x00760602
		// (set) Token: 0x060374C6 RID: 226502 RVA: 0x0076240A File Offset: 0x0076060A
		public List<string> EffectKeys { get; set; }

		// Token: 0x1700E5CD RID: 58829
		// (get) Token: 0x060374C7 RID: 226503 RVA: 0x00762413 File Offset: 0x00760613
		// (set) Token: 0x060374C8 RID: 226504 RVA: 0x0076241B File Offset: 0x0076061B
		public float DelayTime { get; set; }

		// Token: 0x1700E5CE RID: 58830
		// (get) Token: 0x060374C9 RID: 226505 RVA: 0x00762424 File Offset: 0x00760624
		// (set) Token: 0x060374CA RID: 226506 RVA: 0x0076242C File Offset: 0x0076062C
		public bool ImmediatelyDestroy { get; set; }

		// Token: 0x1700E5CF RID: 58831
		// (get) Token: 0x060374CB RID: 226507 RVA: 0x00762435 File Offset: 0x00760635
		// (set) Token: 0x060374CC RID: 226508 RVA: 0x0076243D File Offset: 0x0076063D
		public byte NullMask { get; set; }

		// Token: 0x060374CD RID: 226509 RVA: 0x00762446 File Offset: 0x00760646
		public ITalkEffectStopT()
		{
			this.Type = ETalkEffectActionType.Play;
			this.EffectKeys = null;
			this.DelayTime = 0f;
			this.ImmediatelyDestroy = false;
			this.NullMask = 0;
		}
	}
}
