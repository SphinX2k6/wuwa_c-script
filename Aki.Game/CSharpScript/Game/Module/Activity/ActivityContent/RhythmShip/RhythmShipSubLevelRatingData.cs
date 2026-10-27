using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200620D RID: 25101
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipSubLevelRatingData : IRhythmShipSubLevelRatingData
	{
		// Token: 0x1700923C RID: 37436
		// (get) Token: 0x0603F516 RID: 259350 RVA: 0x00F4CDF5 File Offset: 0x00F4AFF5
		// (set) Token: 0x0603F517 RID: 259351 RVA: 0x00F4CDFD File Offset: 0x00F4AFFD
		public int PlayerId { get; set; }

		// Token: 0x1700923D RID: 37437
		// (get) Token: 0x0603F518 RID: 259352 RVA: 0x00F4CE06 File Offset: 0x00F4B006
		// (set) Token: 0x0603F519 RID: 259353 RVA: 0x00F4CE0E File Offset: 0x00F4B00E
		public string NameText { get; set; }

		// Token: 0x1700923E RID: 37438
		// (get) Token: 0x0603F51A RID: 259354 RVA: 0x00F4CE17 File Offset: 0x00F4B017
		// (set) Token: 0x0603F51B RID: 259355 RVA: 0x00F4CE1F File Offset: 0x00F4B01F
		public int RoleId { get; set; }

		// Token: 0x1700923F RID: 37439
		// (get) Token: 0x0603F51C RID: 259356 RVA: 0x00F4CE28 File Offset: 0x00F4B028
		// (set) Token: 0x0603F51D RID: 259357 RVA: 0x00F4CE30 File Offset: 0x00F4B030
		public int Score { get; set; }

		// Token: 0x17009240 RID: 37440
		// (get) Token: 0x0603F51E RID: 259358 RVA: 0x00F4CE39 File Offset: 0x00F4B039
		// (set) Token: 0x0603F51F RID: 259359 RVA: 0x00F4CE41 File Offset: 0x00F4B041
		public int Accuracy { get; set; }

		// Token: 0x17009241 RID: 37441
		// (get) Token: 0x0603F520 RID: 259360 RVA: 0x00F4CE4A File Offset: 0x00F4B04A
		// (set) Token: 0x0603F521 RID: 259361 RVA: 0x00F4CE52 File Offset: 0x00F4B052
		public int? RankingNumber { get; set; }
	}
}
