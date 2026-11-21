using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052EB RID: 21227
	public interface IPinballFormationViewData
	{
		// Token: 0x170066A0 RID: 26272
		// (get) Token: 0x06034D2B RID: 216363
		// (set) Token: 0x06034D2C RID: 216364
		int LevelId { get; set; }

		// Token: 0x170066A1 RID: 26273
		// (get) Token: 0x06034D2D RID: 216365
		// (set) Token: 0x06034D2E RID: 216366
		bool? IsRestart { get; set; }

		// Token: 0x170066A2 RID: 26274
		// (get) Token: 0x06034D2F RID: 216367
		// (set) Token: 0x06034D30 RID: 216368
		bool? IfReturnToPinballMainView { get; set; }
	}
}
