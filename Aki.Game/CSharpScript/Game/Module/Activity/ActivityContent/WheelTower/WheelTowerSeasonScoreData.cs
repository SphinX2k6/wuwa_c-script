using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F25 RID: 20261
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonScoreData : IWheelTowerSeasonScoreData
	{
		// Token: 0x17006345 RID: 25413
		// (get) Token: 0x06032EA9 RID: 208553 RVA: 0x00E47664 File Offset: 0x00E45864
		// (set) Token: 0x06032EAA RID: 208554 RVA: 0x00E4766C File Offset: 0x00E4586C
		public int Score { get; set; }

		// Token: 0x17006346 RID: 25414
		// (get) Token: 0x06032EAB RID: 208555 RVA: 0x00E47675 File Offset: 0x00E45875
		// (set) Token: 0x06032EAC RID: 208556 RVA: 0x00E4767D File Offset: 0x00E4587D
		public int PrevScore { get; set; }

		// Token: 0x17006347 RID: 25415
		// (get) Token: 0x06032EAD RID: 208557 RVA: 0x00E47686 File Offset: 0x00E45886
		// (set) Token: 0x06032EAE RID: 208558 RVA: 0x00E4768E File Offset: 0x00E4588E
		public int TotalScore { get; set; }

		// Token: 0x17006348 RID: 25416
		// (get) Token: 0x06032EAF RID: 208559 RVA: 0x00E47697 File Offset: 0x00E45897
		// (set) Token: 0x06032EB0 RID: 208560 RVA: 0x00E4769F File Offset: 0x00E4589F
		public int CurScore { get; set; }

		// Token: 0x17006349 RID: 25417
		// (get) Token: 0x06032EB1 RID: 208561 RVA: 0x00E476A8 File Offset: 0x00E458A8
		// (set) Token: 0x06032EB2 RID: 208562 RVA: 0x00E476B0 File Offset: 0x00E458B0
		public bool IsReceived { get; set; }

		// Token: 0x1700634A RID: 25418
		// (get) Token: 0x06032EB3 RID: 208563 RVA: 0x00E476B9 File Offset: 0x00E458B9
		// (set) Token: 0x06032EB4 RID: 208564 RVA: 0x00E476C1 File Offset: 0x00E458C1
		public int DropId { get; set; }

		// Token: 0x1700634B RID: 25419
		// (get) Token: 0x06032EB5 RID: 208565 RVA: 0x00E476CA File Offset: 0x00E458CA
		// (set) Token: 0x06032EB6 RID: 208566 RVA: 0x00E476D2 File Offset: 0x00E458D2
		public int MotorPreviewId { get; set; }

		// Token: 0x1700634C RID: 25420
		// (get) Token: 0x06032EB7 RID: 208567 RVA: 0x00E476DB File Offset: 0x00E458DB
		// (set) Token: 0x06032EB8 RID: 208568 RVA: 0x00E476E3 File Offset: 0x00E458E3
		public int WeaponPreviewId { get; set; }

		// Token: 0x1700634D RID: 25421
		// (get) Token: 0x06032EB9 RID: 208569 RVA: 0x00E476EC File Offset: 0x00E458EC
		// (set) Token: 0x06032EBA RID: 208570 RVA: 0x00E476F4 File Offset: 0x00E458F4
		public string PreviewIcon { get; set; }
	}
}
