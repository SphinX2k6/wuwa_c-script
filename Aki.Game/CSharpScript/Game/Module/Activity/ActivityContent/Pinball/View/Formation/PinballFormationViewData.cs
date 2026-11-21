using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052EC RID: 21228
	public class PinballFormationViewData : IPinballFormationViewData
	{
		// Token: 0x170066A3 RID: 26275
		// (get) Token: 0x06034D31 RID: 216369 RVA: 0x00EC4276 File Offset: 0x00EC2476
		// (set) Token: 0x06034D32 RID: 216370 RVA: 0x00EC427E File Offset: 0x00EC247E
		public int LevelId { get; set; }

		// Token: 0x170066A4 RID: 26276
		// (get) Token: 0x06034D33 RID: 216371 RVA: 0x00EC4287 File Offset: 0x00EC2487
		// (set) Token: 0x06034D34 RID: 216372 RVA: 0x00EC428F File Offset: 0x00EC248F
		public bool? IsRestart { get; set; }

		// Token: 0x170066A5 RID: 26277
		// (get) Token: 0x06034D35 RID: 216373 RVA: 0x00EC4298 File Offset: 0x00EC2498
		// (set) Token: 0x06034D36 RID: 216374 RVA: 0x00EC42A0 File Offset: 0x00EC24A0
		public bool? IfReturnToPinballMainView { get; set; }
	}
}
