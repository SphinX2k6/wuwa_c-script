using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005039 RID: 20537
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSpeedRolePanelData : ISolarSpeedRolePanelData
	{
		// Token: 0x1700645D RID: 25693
		// (get) Token: 0x0603369D RID: 210589 RVA: 0x00E67373 File Offset: 0x00E65573
		// (set) Token: 0x0603369E RID: 210590 RVA: 0x00E6737B File Offset: 0x00E6557B
		public int Rank { get; set; }

		// Token: 0x1700645E RID: 25694
		// (get) Token: 0x0603369F RID: 210591 RVA: 0x00E67384 File Offset: 0x00E65584
		// (set) Token: 0x060336A0 RID: 210592 RVA: 0x00E6738C File Offset: 0x00E6558C
		public int PlayerId { get; set; }

		// Token: 0x1700645F RID: 25695
		// (get) Token: 0x060336A1 RID: 210593 RVA: 0x00E67395 File Offset: 0x00E65595
		// (set) Token: 0x060336A2 RID: 210594 RVA: 0x00E6739D File Offset: 0x00E6559D
		public bool IsAddButtonAvailable { get; set; }

		// Token: 0x17006460 RID: 25696
		// (get) Token: 0x060336A3 RID: 210595 RVA: 0x00E673A6 File Offset: 0x00E655A6
		// (set) Token: 0x060336A4 RID: 210596 RVA: 0x00E673AE File Offset: 0x00E655AE
		public bool IsSelf { get; set; }

		// Token: 0x17006461 RID: 25697
		// (get) Token: 0x060336A5 RID: 210597 RVA: 0x00E673B7 File Offset: 0x00E655B7
		// (set) Token: 0x060336A6 RID: 210598 RVA: 0x00E673BF File Offset: 0x00E655BF
		[Nullable(1)]
		public string BgPath { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006462 RID: 25698
		// (get) Token: 0x060336A7 RID: 210599 RVA: 0x00E673C8 File Offset: 0x00E655C8
		// (set) Token: 0x060336A8 RID: 210600 RVA: 0x00E673D0 File Offset: 0x00E655D0
		public string MedalTexturePath { get; set; }

		// Token: 0x17006463 RID: 25699
		// (get) Token: 0x060336A9 RID: 210601 RVA: 0x00E673D9 File Offset: 0x00E655D9
		// (set) Token: 0x060336AA RID: 210602 RVA: 0x00E673E1 File Offset: 0x00E655E1
		[Nullable(1)]
		public string MedalColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006464 RID: 25700
		// (get) Token: 0x060336AB RID: 210603 RVA: 0x00E673EA File Offset: 0x00E655EA
		// (set) Token: 0x060336AC RID: 210604 RVA: 0x00E673F2 File Offset: 0x00E655F2
		[Nullable(1)]
		public string FxColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006465 RID: 25701
		// (get) Token: 0x060336AD RID: 210605 RVA: 0x00E673FB File Offset: 0x00E655FB
		// (set) Token: 0x060336AE RID: 210606 RVA: 0x00E67403 File Offset: 0x00E65603
		public string PlayerIndexIconPath { get; set; }

		// Token: 0x17006466 RID: 25702
		// (get) Token: 0x060336AF RID: 210607 RVA: 0x00E6740C File Offset: 0x00E6560C
		// (set) Token: 0x060336B0 RID: 210608 RVA: 0x00E67414 File Offset: 0x00E65614
		[Nullable(1)]
		public string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006467 RID: 25703
		// (get) Token: 0x060336B1 RID: 210609 RVA: 0x00E6741D File Offset: 0x00E6561D
		// (set) Token: 0x060336B2 RID: 210610 RVA: 0x00E67425 File Offset: 0x00E65625
		public string DescTextId { get; set; }

		// Token: 0x17006468 RID: 25704
		// (get) Token: 0x060336B3 RID: 210611 RVA: 0x00E6742E File Offset: 0x00E6562E
		// (set) Token: 0x060336B4 RID: 210612 RVA: 0x00E67436 File Offset: 0x00E65636
		public string TitleTextId { get; set; }

		// Token: 0x17006469 RID: 25705
		// (get) Token: 0x060336B5 RID: 210613 RVA: 0x00E6743F File Offset: 0x00E6563F
		// (set) Token: 0x060336B6 RID: 210614 RVA: 0x00E67447 File Offset: 0x00E65647
		[Nullable(1)]
		public ISolarSpeedRoleIconPanelData IconData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700646A RID: 25706
		// (get) Token: 0x060336B7 RID: 210615 RVA: 0x00E67450 File Offset: 0x00E65650
		// (set) Token: 0x060336B8 RID: 210616 RVA: 0x00E67458 File Offset: 0x00E65658
		public string AvatarTexturePath { get; set; }

		// Token: 0x1700646B RID: 25707
		// (get) Token: 0x060336B9 RID: 210617 RVA: 0x00E67461 File Offset: 0x00E65661
		// (set) Token: 0x060336BA RID: 210618 RVA: 0x00E67469 File Offset: 0x00E65669
		public string LineTexturePath { get; set; }

		// Token: 0x1700646C RID: 25708
		// (get) Token: 0x060336BB RID: 210619 RVA: 0x00E67472 File Offset: 0x00E65672
		// (set) Token: 0x060336BC RID: 210620 RVA: 0x00E6747A File Offset: 0x00E6567A
		public string BgTexturePath { get; set; }
	}
}
