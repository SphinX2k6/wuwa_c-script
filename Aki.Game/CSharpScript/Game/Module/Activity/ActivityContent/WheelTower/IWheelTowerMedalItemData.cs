using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F34 RID: 20276
	public interface IWheelTowerMedalItemData
	{
		// Token: 0x1700639F RID: 25503
		// (get) Token: 0x06032F66 RID: 208742
		// (set) Token: 0x06032F67 RID: 208743
		int GroupId { get; set; }

		// Token: 0x170063A0 RID: 25504
		// (get) Token: 0x06032F68 RID: 208744
		// (set) Token: 0x06032F69 RID: 208745
		bool? IsLast { get; set; }

		// Token: 0x170063A1 RID: 25505
		// (get) Token: 0x06032F6A RID: 208746
		// (set) Token: 0x06032F6B RID: 208747
		bool? DisableInteract { get; set; }

		// Token: 0x170063A2 RID: 25506
		// (get) Token: 0x06032F6C RID: 208748
		// (set) Token: 0x06032F6D RID: 208749
		bool? HideDetails { get; set; }

		// Token: 0x170063A3 RID: 25507
		// (get) Token: 0x06032F6E RID: 208750
		// (set) Token: 0x06032F6F RID: 208751
		bool HideMedalPnl { get; set; }
	}
}
