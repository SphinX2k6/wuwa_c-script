using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200620C RID: 25100
	[NullableContext(1)]
	public interface IRhythmShipSubLevelRatingData
	{
		// Token: 0x17009236 RID: 37430
		// (get) Token: 0x0603F50A RID: 259338
		// (set) Token: 0x0603F50B RID: 259339
		int PlayerId { get; set; }

		// Token: 0x17009237 RID: 37431
		// (get) Token: 0x0603F50C RID: 259340
		// (set) Token: 0x0603F50D RID: 259341
		string NameText { get; set; }

		// Token: 0x17009238 RID: 37432
		// (get) Token: 0x0603F50E RID: 259342
		// (set) Token: 0x0603F50F RID: 259343
		int RoleId { get; set; }

		// Token: 0x17009239 RID: 37433
		// (get) Token: 0x0603F510 RID: 259344
		// (set) Token: 0x0603F511 RID: 259345
		int Score { get; set; }

		// Token: 0x1700923A RID: 37434
		// (get) Token: 0x0603F512 RID: 259346
		// (set) Token: 0x0603F513 RID: 259347
		int Accuracy { get; set; }

		// Token: 0x1700923B RID: 37435
		// (get) Token: 0x0603F514 RID: 259348
		// (set) Token: 0x0603F515 RID: 259349
		int? RankingNumber { get; set; }
	}
}
