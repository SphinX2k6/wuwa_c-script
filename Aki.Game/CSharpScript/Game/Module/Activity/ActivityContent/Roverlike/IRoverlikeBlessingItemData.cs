using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006184 RID: 24964
	public interface IRoverlikeBlessingItemData
	{
		// Token: 0x170091C2 RID: 37314
		// (get) Token: 0x0603F168 RID: 258408
		// (set) Token: 0x0603F169 RID: 258409
		int BlessId { get; set; }

		// Token: 0x170091C3 RID: 37315
		// (get) Token: 0x0603F16A RID: 258410
		// (set) Token: 0x0603F16B RID: 258411
		int? IncId { get; set; }

		// Token: 0x170091C4 RID: 37316
		// (get) Token: 0x0603F16C RID: 258412
		// (set) Token: 0x0603F16D RID: 258413
		bool? AllowToggleInteract { get; set; }

		// Token: 0x170091C5 RID: 37317
		// (get) Token: 0x0603F16E RID: 258414
		// (set) Token: 0x0603F16F RID: 258415
		bool? IsUp { get; set; }

		// Token: 0x170091C6 RID: 37318
		// (get) Token: 0x0603F170 RID: 258416
		// (set) Token: 0x0603F171 RID: 258417
		bool? CheckSameSlot { get; set; }

		// Token: 0x170091C7 RID: 37319
		// (get) Token: 0x0603F172 RID: 258418
		// (set) Token: 0x0603F173 RID: 258419
		bool? ShowRecommend { get; set; }
	}
}
