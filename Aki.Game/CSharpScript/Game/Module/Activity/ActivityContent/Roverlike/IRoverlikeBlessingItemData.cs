using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005102 RID: 20738
	public interface IRoverlikeBlessingItemData
	{
		// Token: 0x17006524 RID: 25892
		// (get) Token: 0x06033E28 RID: 212520
		// (set) Token: 0x06033E29 RID: 212521
		int BlessId { get; set; }

		// Token: 0x17006525 RID: 25893
		// (get) Token: 0x06033E2A RID: 212522
		// (set) Token: 0x06033E2B RID: 212523
		int? IncId { get; set; }

		// Token: 0x17006526 RID: 25894
		// (get) Token: 0x06033E2C RID: 212524
		// (set) Token: 0x06033E2D RID: 212525
		bool? AllowToggleInteract { get; set; }

		// Token: 0x17006527 RID: 25895
		// (get) Token: 0x06033E2E RID: 212526
		// (set) Token: 0x06033E2F RID: 212527
		bool? IsUp { get; set; }

		// Token: 0x17006528 RID: 25896
		// (get) Token: 0x06033E30 RID: 212528
		// (set) Token: 0x06033E31 RID: 212529
		bool? CheckSameSlot { get; set; }

		// Token: 0x17006529 RID: 25897
		// (get) Token: 0x06033E32 RID: 212530
		// (set) Token: 0x06033E33 RID: 212531
		bool? ShowRecommend { get; set; }
	}
}
