using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200518A RID: 20874
	[NullableContext(1)]
	public interface IRhythmShipSubLevelRatingData
	{
		// Token: 0x17006598 RID: 26008
		// (get) Token: 0x060341CB RID: 213451
		// (set) Token: 0x060341CC RID: 213452
		int PlayerId { get; set; }

		// Token: 0x17006599 RID: 26009
		// (get) Token: 0x060341CD RID: 213453
		// (set) Token: 0x060341CE RID: 213454
		string NameText { get; set; }

		// Token: 0x1700659A RID: 26010
		// (get) Token: 0x060341CF RID: 213455
		// (set) Token: 0x060341D0 RID: 213456
		int RoleId { get; set; }

		// Token: 0x1700659B RID: 26011
		// (get) Token: 0x060341D1 RID: 213457
		// (set) Token: 0x060341D2 RID: 213458
		int Score { get; set; }

		// Token: 0x1700659C RID: 26012
		// (get) Token: 0x060341D3 RID: 213459
		// (set) Token: 0x060341D4 RID: 213460
		int Accuracy { get; set; }

		// Token: 0x1700659D RID: 26013
		// (get) Token: 0x060341D5 RID: 213461
		// (set) Token: 0x060341D6 RID: 213462
		int? RankingNumber { get; set; }
	}
}
