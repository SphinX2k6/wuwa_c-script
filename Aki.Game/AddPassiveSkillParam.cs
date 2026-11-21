using System;

// Token: 0x02002424 RID: 9252
public class AddPassiveSkillParam
{
	// Token: 0x17002415 RID: 9237
	// (get) Token: 0x060172A0 RID: 94880 RVA: 0x006CB0A4 File Offset: 0x006C92A4
	// (set) Token: 0x060172A1 RID: 94881 RVA: 0x006CB0AC File Offset: 0x006C92AC
	public bool? NeedBroadcast { get; set; }

	// Token: 0x17002416 RID: 9238
	// (get) Token: 0x060172A2 RID: 94882 RVA: 0x006CB0B5 File Offset: 0x006C92B5
	// (set) Token: 0x060172A3 RID: 94883 RVA: 0x006CB0BD File Offset: 0x006C92BD
	public long CombatMessageId { get; set; }

	// Token: 0x17002417 RID: 9239
	// (get) Token: 0x060172A4 RID: 94884 RVA: 0x006CB0C6 File Offset: 0x006C92C6
	// (set) Token: 0x060172A5 RID: 94885 RVA: 0x006CB0CE File Offset: 0x006C92CE
	public long? PreMessageId { get; set; }
}
