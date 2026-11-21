using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F24 RID: 20260
	[NullableContext(1)]
	public interface IWheelTowerSeasonScoreData
	{
		// Token: 0x1700633C RID: 25404
		// (get) Token: 0x06032E97 RID: 208535
		// (set) Token: 0x06032E98 RID: 208536
		int Score { get; set; }

		// Token: 0x1700633D RID: 25405
		// (get) Token: 0x06032E99 RID: 208537
		// (set) Token: 0x06032E9A RID: 208538
		int PrevScore { get; set; }

		// Token: 0x1700633E RID: 25406
		// (get) Token: 0x06032E9B RID: 208539
		// (set) Token: 0x06032E9C RID: 208540
		int TotalScore { get; set; }

		// Token: 0x1700633F RID: 25407
		// (get) Token: 0x06032E9D RID: 208541
		// (set) Token: 0x06032E9E RID: 208542
		int CurScore { get; set; }

		// Token: 0x17006340 RID: 25408
		// (get) Token: 0x06032E9F RID: 208543
		// (set) Token: 0x06032EA0 RID: 208544
		bool IsReceived { get; set; }

		// Token: 0x17006341 RID: 25409
		// (get) Token: 0x06032EA1 RID: 208545
		// (set) Token: 0x06032EA2 RID: 208546
		int DropId { get; set; }

		// Token: 0x17006342 RID: 25410
		// (get) Token: 0x06032EA3 RID: 208547
		// (set) Token: 0x06032EA4 RID: 208548
		int MotorPreviewId { get; set; }

		// Token: 0x17006343 RID: 25411
		// (get) Token: 0x06032EA5 RID: 208549
		// (set) Token: 0x06032EA6 RID: 208550
		int WeaponPreviewId { get; set; }

		// Token: 0x17006344 RID: 25412
		// (get) Token: 0x06032EA7 RID: 208551
		// (set) Token: 0x06032EA8 RID: 208552
		string PreviewIcon { get; set; }
	}
}
