using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F3D RID: 24381
	[NullableContext(1)]
	public interface IWheelTowerSeasonScoreData
	{
		// Token: 0x17008F6A RID: 36714
		// (get) Token: 0x0603DEFC RID: 253692
		// (set) Token: 0x0603DEFD RID: 253693
		int Score { get; set; }

		// Token: 0x17008F6B RID: 36715
		// (get) Token: 0x0603DEFE RID: 253694
		// (set) Token: 0x0603DEFF RID: 253695
		int PrevScore { get; set; }

		// Token: 0x17008F6C RID: 36716
		// (get) Token: 0x0603DF00 RID: 253696
		// (set) Token: 0x0603DF01 RID: 253697
		int TotalScore { get; set; }

		// Token: 0x17008F6D RID: 36717
		// (get) Token: 0x0603DF02 RID: 253698
		// (set) Token: 0x0603DF03 RID: 253699
		int CurScore { get; set; }

		// Token: 0x17008F6E RID: 36718
		// (get) Token: 0x0603DF04 RID: 253700
		// (set) Token: 0x0603DF05 RID: 253701
		bool IsReceived { get; set; }

		// Token: 0x17008F6F RID: 36719
		// (get) Token: 0x0603DF06 RID: 253702
		// (set) Token: 0x0603DF07 RID: 253703
		int DropId { get; set; }

		// Token: 0x17008F70 RID: 36720
		// (get) Token: 0x0603DF08 RID: 253704
		// (set) Token: 0x0603DF09 RID: 253705
		int MotorPreviewId { get; set; }

		// Token: 0x17008F71 RID: 36721
		// (get) Token: 0x0603DF0A RID: 253706
		// (set) Token: 0x0603DF0B RID: 253707
		int WeaponPreviewId { get; set; }

		// Token: 0x17008F72 RID: 36722
		// (get) Token: 0x0603DF0C RID: 253708
		// (set) Token: 0x0603DF0D RID: 253709
		string PreviewIcon { get; set; }
	}
}
