using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B6 RID: 24758
	[NullableContext(1)]
	public interface ISolarSpeedRewardCellPanelData
	{
		// Token: 0x170090D1 RID: 37073
		// (get) Token: 0x0603E983 RID: 256387
		// (set) Token: 0x0603E984 RID: 256388
		int RewardId { get; set; }

		// Token: 0x170090D2 RID: 37074
		// (get) Token: 0x0603E985 RID: 256389
		// (set) Token: 0x0603E986 RID: 256390
		string TitleTextId { get; set; }

		// Token: 0x170090D3 RID: 37075
		// (get) Token: 0x0603E987 RID: 256391
		// (set) Token: 0x0603E988 RID: 256392
		string ProgressTextId { get; set; }

		// Token: 0x170090D4 RID: 37076
		// (get) Token: 0x0603E989 RID: 256393
		// (set) Token: 0x0603E98A RID: 256394
		string[] ProgressTextArgs { get; set; }

		// Token: 0x170090D5 RID: 37077
		// (get) Token: 0x0603E98B RID: 256395
		// (set) Token: 0x0603E98C RID: 256396
		TItem[] ItemsData { get; set; }

		// Token: 0x170090D6 RID: 37078
		// (get) Token: 0x0603E98D RID: 256397
		// (set) Token: 0x0603E98E RID: 256398
		string ButtonTextId { get; set; }

		// Token: 0x170090D7 RID: 37079
		// (get) Token: 0x0603E98F RID: 256399
		// (set) Token: 0x0603E990 RID: 256400
		bool ButtonActive { get; set; }

		// Token: 0x170090D8 RID: 37080
		// (get) Token: 0x0603E991 RID: 256401
		// (set) Token: 0x0603E992 RID: 256402
		bool RightActive { get; set; }

		// Token: 0x170090D9 RID: 37081
		// (get) Token: 0x0603E993 RID: 256403
		// (set) Token: 0x0603E994 RID: 256404
		bool DoneSpriteActive { get; set; }
	}
}
