using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F4E RID: 24398
	public class WheelTowerMedalItemData : IWheelTowerMedalItemData
	{
		// Token: 0x17008FD2 RID: 36818
		// (get) Token: 0x0603DFD5 RID: 253909 RVA: 0x00EF5DAF File Offset: 0x00EF3FAF
		// (set) Token: 0x0603DFD6 RID: 253910 RVA: 0x00EF5DB7 File Offset: 0x00EF3FB7
		public int GroupId { get; set; }

		// Token: 0x17008FD3 RID: 36819
		// (get) Token: 0x0603DFD7 RID: 253911 RVA: 0x00EF5DC0 File Offset: 0x00EF3FC0
		// (set) Token: 0x0603DFD8 RID: 253912 RVA: 0x00EF5DC8 File Offset: 0x00EF3FC8
		public bool? IsLast { get; set; }

		// Token: 0x17008FD4 RID: 36820
		// (get) Token: 0x0603DFD9 RID: 253913 RVA: 0x00EF5DD1 File Offset: 0x00EF3FD1
		// (set) Token: 0x0603DFDA RID: 253914 RVA: 0x00EF5DD9 File Offset: 0x00EF3FD9
		public bool? DisableInteract { get; set; }

		// Token: 0x17008FD5 RID: 36821
		// (get) Token: 0x0603DFDB RID: 253915 RVA: 0x00EF5DE2 File Offset: 0x00EF3FE2
		// (set) Token: 0x0603DFDC RID: 253916 RVA: 0x00EF5DEA File Offset: 0x00EF3FEA
		public bool? HideDetails { get; set; }

		// Token: 0x17008FD6 RID: 36822
		// (get) Token: 0x0603DFDD RID: 253917 RVA: 0x00EF5DF3 File Offset: 0x00EF3FF3
		// (set) Token: 0x0603DFDE RID: 253918 RVA: 0x00EF5DFB File Offset: 0x00EF3FFB
		public bool HideMedalPnl { get; set; }
	}
}
