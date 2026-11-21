using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005035 RID: 20533
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardCellPanelData : ISolarSpeedRewardCellPanelData
	{
		// Token: 0x1700643C RID: 25660
		// (get) Token: 0x06033659 RID: 210521 RVA: 0x00E67286 File Offset: 0x00E65486
		// (set) Token: 0x0603365A RID: 210522 RVA: 0x00E6728E File Offset: 0x00E6548E
		public int RewardId { get; set; }

		// Token: 0x1700643D RID: 25661
		// (get) Token: 0x0603365B RID: 210523 RVA: 0x00E67297 File Offset: 0x00E65497
		// (set) Token: 0x0603365C RID: 210524 RVA: 0x00E6729F File Offset: 0x00E6549F
		public string TitleTextId { get; set; }

		// Token: 0x1700643E RID: 25662
		// (get) Token: 0x0603365D RID: 210525 RVA: 0x00E672A8 File Offset: 0x00E654A8
		// (set) Token: 0x0603365E RID: 210526 RVA: 0x00E672B0 File Offset: 0x00E654B0
		public string ProgressTextId { get; set; }

		// Token: 0x1700643F RID: 25663
		// (get) Token: 0x0603365F RID: 210527 RVA: 0x00E672B9 File Offset: 0x00E654B9
		// (set) Token: 0x06033660 RID: 210528 RVA: 0x00E672C1 File Offset: 0x00E654C1
		public string[] ProgressTextArgs { get; set; }

		// Token: 0x17006440 RID: 25664
		// (get) Token: 0x06033661 RID: 210529 RVA: 0x00E672CA File Offset: 0x00E654CA
		// (set) Token: 0x06033662 RID: 210530 RVA: 0x00E672D2 File Offset: 0x00E654D2
		public TItem[] ItemsData { get; set; }

		// Token: 0x17006441 RID: 25665
		// (get) Token: 0x06033663 RID: 210531 RVA: 0x00E672DB File Offset: 0x00E654DB
		// (set) Token: 0x06033664 RID: 210532 RVA: 0x00E672E3 File Offset: 0x00E654E3
		public string ButtonTextId { get; set; }

		// Token: 0x17006442 RID: 25666
		// (get) Token: 0x06033665 RID: 210533 RVA: 0x00E672EC File Offset: 0x00E654EC
		// (set) Token: 0x06033666 RID: 210534 RVA: 0x00E672F4 File Offset: 0x00E654F4
		public bool ButtonActive { get; set; }

		// Token: 0x17006443 RID: 25667
		// (get) Token: 0x06033667 RID: 210535 RVA: 0x00E672FD File Offset: 0x00E654FD
		// (set) Token: 0x06033668 RID: 210536 RVA: 0x00E67305 File Offset: 0x00E65505
		public bool RightActive { get; set; }

		// Token: 0x17006444 RID: 25668
		// (get) Token: 0x06033669 RID: 210537 RVA: 0x00E6730E File Offset: 0x00E6550E
		// (set) Token: 0x0603366A RID: 210538 RVA: 0x00E67316 File Offset: 0x00E65516
		public bool DoneSpriteActive { get; set; }
	}
}
