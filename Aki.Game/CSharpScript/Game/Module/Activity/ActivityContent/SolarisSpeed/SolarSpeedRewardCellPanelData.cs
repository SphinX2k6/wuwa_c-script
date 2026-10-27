using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B7 RID: 24759
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardCellPanelData : ISolarSpeedRewardCellPanelData
	{
		// Token: 0x170090DA RID: 37082
		// (get) Token: 0x0603E995 RID: 256405 RVA: 0x00F204C2 File Offset: 0x00F1E6C2
		// (set) Token: 0x0603E996 RID: 256406 RVA: 0x00F204CA File Offset: 0x00F1E6CA
		public int RewardId { get; set; }

		// Token: 0x170090DB RID: 37083
		// (get) Token: 0x0603E997 RID: 256407 RVA: 0x00F204D3 File Offset: 0x00F1E6D3
		// (set) Token: 0x0603E998 RID: 256408 RVA: 0x00F204DB File Offset: 0x00F1E6DB
		public string TitleTextId { get; set; }

		// Token: 0x170090DC RID: 37084
		// (get) Token: 0x0603E999 RID: 256409 RVA: 0x00F204E4 File Offset: 0x00F1E6E4
		// (set) Token: 0x0603E99A RID: 256410 RVA: 0x00F204EC File Offset: 0x00F1E6EC
		public string ProgressTextId { get; set; }

		// Token: 0x170090DD RID: 37085
		// (get) Token: 0x0603E99B RID: 256411 RVA: 0x00F204F5 File Offset: 0x00F1E6F5
		// (set) Token: 0x0603E99C RID: 256412 RVA: 0x00F204FD File Offset: 0x00F1E6FD
		public string[] ProgressTextArgs { get; set; }

		// Token: 0x170090DE RID: 37086
		// (get) Token: 0x0603E99D RID: 256413 RVA: 0x00F20506 File Offset: 0x00F1E706
		// (set) Token: 0x0603E99E RID: 256414 RVA: 0x00F2050E File Offset: 0x00F1E70E
		public TItem[] ItemsData { get; set; }

		// Token: 0x170090DF RID: 37087
		// (get) Token: 0x0603E99F RID: 256415 RVA: 0x00F20517 File Offset: 0x00F1E717
		// (set) Token: 0x0603E9A0 RID: 256416 RVA: 0x00F2051F File Offset: 0x00F1E71F
		public string ButtonTextId { get; set; }

		// Token: 0x170090E0 RID: 37088
		// (get) Token: 0x0603E9A1 RID: 256417 RVA: 0x00F20528 File Offset: 0x00F1E728
		// (set) Token: 0x0603E9A2 RID: 256418 RVA: 0x00F20530 File Offset: 0x00F1E730
		public bool ButtonActive { get; set; }

		// Token: 0x170090E1 RID: 37089
		// (get) Token: 0x0603E9A3 RID: 256419 RVA: 0x00F20539 File Offset: 0x00F1E739
		// (set) Token: 0x0603E9A4 RID: 256420 RVA: 0x00F20541 File Offset: 0x00F1E741
		public bool RightActive { get; set; }

		// Token: 0x170090E2 RID: 37090
		// (get) Token: 0x0603E9A5 RID: 256421 RVA: 0x00F2054A File Offset: 0x00F1E74A
		// (set) Token: 0x0603E9A6 RID: 256422 RVA: 0x00F20552 File Offset: 0x00F1E752
		public bool DoneSpriteActive { get; set; }
	}
}
