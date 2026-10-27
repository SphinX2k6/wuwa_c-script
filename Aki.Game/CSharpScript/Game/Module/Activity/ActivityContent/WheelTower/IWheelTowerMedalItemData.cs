using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F4D RID: 24397
	public interface IWheelTowerMedalItemData
	{
		// Token: 0x17008FCD RID: 36813
		// (get) Token: 0x0603DFCB RID: 253899
		// (set) Token: 0x0603DFCC RID: 253900
		int GroupId { get; set; }

		// Token: 0x17008FCE RID: 36814
		// (get) Token: 0x0603DFCD RID: 253901
		// (set) Token: 0x0603DFCE RID: 253902
		bool? IsLast { get; set; }

		// Token: 0x17008FCF RID: 36815
		// (get) Token: 0x0603DFCF RID: 253903
		// (set) Token: 0x0603DFD0 RID: 253904
		bool? DisableInteract { get; set; }

		// Token: 0x17008FD0 RID: 36816
		// (get) Token: 0x0603DFD1 RID: 253905
		// (set) Token: 0x0603DFD2 RID: 253906
		bool? HideDetails { get; set; }

		// Token: 0x17008FD1 RID: 36817
		// (get) Token: 0x0603DFD3 RID: 253907
		// (set) Token: 0x0603DFD4 RID: 253908
		bool HideMedalPnl { get; set; }
	}
}
