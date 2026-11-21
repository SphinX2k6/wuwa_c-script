using System;
using System.Runtime.CompilerServices;

// Token: 0x02002109 RID: 8457
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardBaseData : ISurvivorsRogueCardBase
{
	// Token: 0x17001F4B RID: 8011
	// (get) Token: 0x06014BD9 RID: 84953 RVA: 0x00609550 File Offset: 0x00607750
	// (set) Token: 0x06014BDA RID: 84954 RVA: 0x00609558 File Offset: 0x00607758
	public ESurvivorsRogueItemType Type { get; set; }

	// Token: 0x17001F4C RID: 8012
	// (get) Token: 0x06014BDB RID: 84955 RVA: 0x00609561 File Offset: 0x00607761
	// (set) Token: 0x06014BDC RID: 84956 RVA: 0x00609569 File Offset: 0x00607769
	public int Id { get; set; }

	// Token: 0x17001F4D RID: 8013
	// (get) Token: 0x06014BDD RID: 84957 RVA: 0x00609572 File Offset: 0x00607772
	// (set) Token: 0x06014BDE RID: 84958 RVA: 0x0060957A File Offset: 0x0060777A
	public int? IncId { get; set; }

	// Token: 0x17001F4E RID: 8014
	// (get) Token: 0x06014BDF RID: 84959 RVA: 0x00609583 File Offset: 0x00607783
	// (set) Token: 0x06014BE0 RID: 84960 RVA: 0x0060958B File Offset: 0x0060778B
	public int Index { get; set; }

	// Token: 0x17001F4F RID: 8015
	// (get) Token: 0x06014BE1 RID: 84961 RVA: 0x00609594 File Offset: 0x00607794
	// (set) Token: 0x06014BE2 RID: 84962 RVA: 0x0060959C File Offset: 0x0060779C
	public int QualityId { get; set; }

	// Token: 0x17001F50 RID: 8016
	// (get) Token: 0x06014BE3 RID: 84963 RVA: 0x006095A5 File Offset: 0x006077A5
	// (set) Token: 0x06014BE4 RID: 84964 RVA: 0x006095AD File Offset: 0x006077AD
	public string TitleId { get; set; }

	// Token: 0x17001F51 RID: 8017
	// (get) Token: 0x06014BE5 RID: 84965 RVA: 0x006095B6 File Offset: 0x006077B6
	// (set) Token: 0x06014BE6 RID: 84966 RVA: 0x006095BE File Offset: 0x006077BE
	public string TitleText { get; set; }

	// Token: 0x17001F52 RID: 8018
	// (get) Token: 0x06014BE7 RID: 84967 RVA: 0x006095C7 File Offset: 0x006077C7
	// (set) Token: 0x06014BE8 RID: 84968 RVA: 0x006095CF File Offset: 0x006077CF
	[Nullable(1)]
	public string DescId { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17001F53 RID: 8019
	// (get) Token: 0x06014BE9 RID: 84969 RVA: 0x006095D8 File Offset: 0x006077D8
	// (set) Token: 0x06014BEA RID: 84970 RVA: 0x006095E0 File Offset: 0x006077E0
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

	// Token: 0x17001F54 RID: 8020
	// (get) Token: 0x06014BEB RID: 84971 RVA: 0x006095E9 File Offset: 0x006077E9
	// (set) Token: 0x06014BEC RID: 84972 RVA: 0x006095F1 File Offset: 0x006077F1
	public bool? TagVisible { get; set; }

	// Token: 0x17001F55 RID: 8021
	// (get) Token: 0x06014BED RID: 84973 RVA: 0x006095FA File Offset: 0x006077FA
	// (set) Token: 0x06014BEE RID: 84974 RVA: 0x00609602 File Offset: 0x00607802
	public string TagId { get; set; }

	// Token: 0x17001F56 RID: 8022
	// (get) Token: 0x06014BEF RID: 84975 RVA: 0x0060960B File Offset: 0x0060780B
	// (set) Token: 0x06014BF0 RID: 84976 RVA: 0x00609613 File Offset: 0x00607813
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

	// Token: 0x17001F57 RID: 8023
	// (get) Token: 0x06014BF1 RID: 84977 RVA: 0x0060961C File Offset: 0x0060781C
	// (set) Token: 0x06014BF2 RID: 84978 RVA: 0x00609624 File Offset: 0x00607824
	public bool? UseToggle { get; set; }

	// Token: 0x17001F58 RID: 8024
	// (get) Token: 0x06014BF3 RID: 84979 RVA: 0x0060962D File Offset: 0x0060782D
	// (set) Token: 0x06014BF4 RID: 84980 RVA: 0x00609635 File Offset: 0x00607835
	public bool? IsLevelUp { get; set; }

	// Token: 0x17001F59 RID: 8025
	// (get) Token: 0x06014BF5 RID: 84981 RVA: 0x0060963E File Offset: 0x0060783E
	// (set) Token: 0x06014BF6 RID: 84982 RVA: 0x00609646 File Offset: 0x00607846
	public bool? NeedLock { get; set; }

	// Token: 0x17001F5A RID: 8026
	// (get) Token: 0x06014BF7 RID: 84983 RVA: 0x0060964F File Offset: 0x0060784F
	// (set) Token: 0x06014BF8 RID: 84984 RVA: 0x00609657 File Offset: 0x00607857
	public bool? LockState { get; set; }

	// Token: 0x17001F5B RID: 8027
	// (get) Token: 0x06014BF9 RID: 84985 RVA: 0x00609660 File Offset: 0x00607860
	// (set) Token: 0x06014BFA RID: 84986 RVA: 0x00609668 File Offset: 0x00607868
	public int? Cost { get; set; }

	// Token: 0x17001F5C RID: 8028
	// (get) Token: 0x06014BFB RID: 84987 RVA: 0x00609671 File Offset: 0x00607871
	// (set) Token: 0x06014BFC RID: 84988 RVA: 0x00609679 File Offset: 0x00607879
	public bool? CostEnoughCheck { get; set; }
}
