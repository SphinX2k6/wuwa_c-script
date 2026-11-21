using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE0 RID: 19168
	public interface ICookingData : ICookItemData
	{
		// Token: 0x1700601F RID: 24607
		// (get) Token: 0x0602FF1A RID: 196378
		// (set) Token: 0x0602FF1B RID: 196379
		ESubCookDataType SubType { get; set; }

		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x0602FF1C RID: 196380
		// (set) Token: 0x0602FF1D RID: 196381
		int UniqueId { get; set; }

		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x0602FF1E RID: 196382
		// (set) Token: 0x0602FF1F RID: 196383
		int CookCount { get; set; }

		// Token: 0x17006022 RID: 24610
		// (get) Token: 0x0602FF20 RID: 196384
		// (set) Token: 0x0602FF21 RID: 196385
		int? LastRoleId { get; set; }

		// Token: 0x17006023 RID: 24611
		// (get) Token: 0x0602FF22 RID: 196386
		// (set) Token: 0x0602FF23 RID: 196387
		int IsCook { get; set; }

		// Token: 0x17006024 RID: 24612
		// (get) Token: 0x0602FF24 RID: 196388
		// (set) Token: 0x0602FF25 RID: 196389
		int EffectType { get; set; }

		// Token: 0x17006025 RID: 24613
		// (get) Token: 0x0602FF26 RID: 196390
		// (set) Token: 0x0602FF27 RID: 196391
		int DataId { get; set; }

		// Token: 0x17006026 RID: 24614
		// (get) Token: 0x0602FF28 RID: 196392
		// (set) Token: 0x0602FF29 RID: 196393
		int LimitTotalCount { get; set; }

		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x0602FF2A RID: 196394
		// (set) Token: 0x0602FF2B RID: 196395
		int LimitedCount { get; set; }

		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x0602FF2C RID: 196396
		// (set) Token: 0x0602FF2D RID: 196397
		double ExistStartTime { get; set; }

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x0602FF2E RID: 196398
		// (set) Token: 0x0602FF2F RID: 196399
		double ExistEndTime { get; set; }
	}
}
