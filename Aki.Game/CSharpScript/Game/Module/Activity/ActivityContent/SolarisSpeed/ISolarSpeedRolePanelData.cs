using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005038 RID: 20536
	[NullableContext(2)]
	public interface ISolarSpeedRolePanelData
	{
		// Token: 0x1700644D RID: 25677
		// (get) Token: 0x0603367D RID: 210557
		// (set) Token: 0x0603367E RID: 210558
		int Rank { get; set; }

		// Token: 0x1700644E RID: 25678
		// (get) Token: 0x0603367F RID: 210559
		// (set) Token: 0x06033680 RID: 210560
		int PlayerId { get; set; }

		// Token: 0x1700644F RID: 25679
		// (get) Token: 0x06033681 RID: 210561
		// (set) Token: 0x06033682 RID: 210562
		bool IsAddButtonAvailable { get; set; }

		// Token: 0x17006450 RID: 25680
		// (get) Token: 0x06033683 RID: 210563
		// (set) Token: 0x06033684 RID: 210564
		bool IsSelf { get; set; }

		// Token: 0x17006451 RID: 25681
		// (get) Token: 0x06033685 RID: 210565
		// (set) Token: 0x06033686 RID: 210566
		[Nullable(1)]
		string BgPath { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006452 RID: 25682
		// (get) Token: 0x06033687 RID: 210567
		// (set) Token: 0x06033688 RID: 210568
		string MedalTexturePath { get; set; }

		// Token: 0x17006453 RID: 25683
		// (get) Token: 0x06033689 RID: 210569
		// (set) Token: 0x0603368A RID: 210570
		[Nullable(1)]
		string MedalColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006454 RID: 25684
		// (get) Token: 0x0603368B RID: 210571
		// (set) Token: 0x0603368C RID: 210572
		[Nullable(1)]
		string FxColorHex { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006455 RID: 25685
		// (get) Token: 0x0603368D RID: 210573
		// (set) Token: 0x0603368E RID: 210574
		string PlayerIndexIconPath { get; set; }

		// Token: 0x17006456 RID: 25686
		// (get) Token: 0x0603368F RID: 210575
		// (set) Token: 0x06033690 RID: 210576
		[Nullable(1)]
		string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006457 RID: 25687
		// (get) Token: 0x06033691 RID: 210577
		// (set) Token: 0x06033692 RID: 210578
		string DescTextId { get; set; }

		// Token: 0x17006458 RID: 25688
		// (get) Token: 0x06033693 RID: 210579
		// (set) Token: 0x06033694 RID: 210580
		string TitleTextId { get; set; }

		// Token: 0x17006459 RID: 25689
		// (get) Token: 0x06033695 RID: 210581
		// (set) Token: 0x06033696 RID: 210582
		[Nullable(1)]
		ISolarSpeedRoleIconPanelData IconData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700645A RID: 25690
		// (get) Token: 0x06033697 RID: 210583
		// (set) Token: 0x06033698 RID: 210584
		string AvatarTexturePath { get; set; }

		// Token: 0x1700645B RID: 25691
		// (get) Token: 0x06033699 RID: 210585
		// (set) Token: 0x0603369A RID: 210586
		string LineTexturePath { get; set; }

		// Token: 0x1700645C RID: 25692
		// (get) Token: 0x0603369B RID: 210587
		// (set) Token: 0x0603369C RID: 210588
		string BgTexturePath { get; set; }
	}
}
