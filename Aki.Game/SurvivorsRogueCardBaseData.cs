using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B8D RID: 11149
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardBaseData : ISurvivorsRogueCardBase
{
	// Token: 0x17001EF3 RID: 7923
	// (get) Token: 0x060171A8 RID: 94632 RVA: 0x005DC970 File Offset: 0x005DAB70
	// (set) Token: 0x060171A9 RID: 94633 RVA: 0x005DC978 File Offset: 0x005DAB78
	public ESurvivorsRogueItemType Type { get; set; }

	// Token: 0x17001EF4 RID: 7924
	// (get) Token: 0x060171AA RID: 94634 RVA: 0x005DC981 File Offset: 0x005DAB81
	// (set) Token: 0x060171AB RID: 94635 RVA: 0x005DC989 File Offset: 0x005DAB89
	public int Id { get; set; }

	// Token: 0x17001EF5 RID: 7925
	// (get) Token: 0x060171AC RID: 94636 RVA: 0x005DC992 File Offset: 0x005DAB92
	// (set) Token: 0x060171AD RID: 94637 RVA: 0x005DC99A File Offset: 0x005DAB9A
	public int? IncId { get; set; }

	// Token: 0x17001EF6 RID: 7926
	// (get) Token: 0x060171AE RID: 94638 RVA: 0x005DC9A3 File Offset: 0x005DABA3
	// (set) Token: 0x060171AF RID: 94639 RVA: 0x005DC9AB File Offset: 0x005DABAB
	public int Index { get; set; }

	// Token: 0x17001EF7 RID: 7927
	// (get) Token: 0x060171B0 RID: 94640 RVA: 0x005DC9B4 File Offset: 0x005DABB4
	// (set) Token: 0x060171B1 RID: 94641 RVA: 0x005DC9BC File Offset: 0x005DABBC
	public int QualityId { get; set; }

	// Token: 0x17001EF8 RID: 7928
	// (get) Token: 0x060171B2 RID: 94642 RVA: 0x005DC9C5 File Offset: 0x005DABC5
	// (set) Token: 0x060171B3 RID: 94643 RVA: 0x005DC9CD File Offset: 0x005DABCD
	public string TitleId { get; set; }

	// Token: 0x17001EF9 RID: 7929
	// (get) Token: 0x060171B4 RID: 94644 RVA: 0x005DC9D6 File Offset: 0x005DABD6
	// (set) Token: 0x060171B5 RID: 94645 RVA: 0x005DC9DE File Offset: 0x005DABDE
	public string TitleText { get; set; }

	// Token: 0x17001EFA RID: 7930
	// (get) Token: 0x060171B6 RID: 94646 RVA: 0x005DC9E7 File Offset: 0x005DABE7
	// (set) Token: 0x060171B7 RID: 94647 RVA: 0x005DC9EF File Offset: 0x005DABEF
	[Nullable(1)]
	public string DescId { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17001EFB RID: 7931
	// (get) Token: 0x060171B8 RID: 94648 RVA: 0x005DC9F8 File Offset: 0x005DABF8
	// (set) Token: 0x060171B9 RID: 94649 RVA: 0x005DCA00 File Offset: 0x005DAC00
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] DescParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001EFC RID: 7932
	// (get) Token: 0x060171BA RID: 94650 RVA: 0x005DCA09 File Offset: 0x005DAC09
	// (set) Token: 0x060171BB RID: 94651 RVA: 0x005DCA11 File Offset: 0x005DAC11
	public bool? TagVisible { get; set; }

	// Token: 0x17001EFD RID: 7933
	// (get) Token: 0x060171BC RID: 94652 RVA: 0x005DCA1A File Offset: 0x005DAC1A
	// (set) Token: 0x060171BD RID: 94653 RVA: 0x005DCA22 File Offset: 0x005DAC22
	public string TagId { get; set; }

	// Token: 0x17001EFE RID: 7934
	// (get) Token: 0x060171BE RID: 94654 RVA: 0x005DCA2B File Offset: 0x005DAC2B
	// (set) Token: 0x060171BF RID: 94655 RVA: 0x005DCA33 File Offset: 0x005DAC33
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] TagParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001EFF RID: 7935
	// (get) Token: 0x060171C0 RID: 94656 RVA: 0x005DCA3C File Offset: 0x005DAC3C
	// (set) Token: 0x060171C1 RID: 94657 RVA: 0x005DCA44 File Offset: 0x005DAC44
	public bool? UseToggle { get; set; }

	// Token: 0x17001F00 RID: 7936
	// (get) Token: 0x060171C2 RID: 94658 RVA: 0x005DCA4D File Offset: 0x005DAC4D
	// (set) Token: 0x060171C3 RID: 94659 RVA: 0x005DCA55 File Offset: 0x005DAC55
	public bool? IsLevelUp { get; set; }

	// Token: 0x17001F01 RID: 7937
	// (get) Token: 0x060171C4 RID: 94660 RVA: 0x005DCA5E File Offset: 0x005DAC5E
	// (set) Token: 0x060171C5 RID: 94661 RVA: 0x005DCA66 File Offset: 0x005DAC66
	public bool? NeedLock { get; set; }

	// Token: 0x17001F02 RID: 7938
	// (get) Token: 0x060171C6 RID: 94662 RVA: 0x005DCA6F File Offset: 0x005DAC6F
	// (set) Token: 0x060171C7 RID: 94663 RVA: 0x005DCA77 File Offset: 0x005DAC77
	public bool? LockState { get; set; }

	// Token: 0x17001F03 RID: 7939
	// (get) Token: 0x060171C8 RID: 94664 RVA: 0x005DCA80 File Offset: 0x005DAC80
	// (set) Token: 0x060171C9 RID: 94665 RVA: 0x005DCA88 File Offset: 0x005DAC88
	public int? Cost { get; set; }

	// Token: 0x17001F04 RID: 7940
	// (get) Token: 0x060171CA RID: 94666 RVA: 0x005DCA91 File Offset: 0x005DAC91
	// (set) Token: 0x060171CB RID: 94667 RVA: 0x005DCA99 File Offset: 0x005DAC99
	public bool? CostEnoughCheck { get; set; }
}
