using System;

// Token: 0x02002ED1 RID: 11985
public class AddPassiveSkillParam
{
	// Token: 0x17002365 RID: 9061
	// (get) Token: 0x060199A6 RID: 104870 RVA: 0x006A4ED8 File Offset: 0x006A30D8
	// (set) Token: 0x060199A7 RID: 104871 RVA: 0x006A4EE0 File Offset: 0x006A30E0
	public bool? NeedBroadcast { get; set; }

	// Token: 0x17002366 RID: 9062
	// (get) Token: 0x060199A8 RID: 104872 RVA: 0x006A4EE9 File Offset: 0x006A30E9
	// (set) Token: 0x060199A9 RID: 104873 RVA: 0x006A4EF1 File Offset: 0x006A30F1
	public long CombatMessageId { get; set; }

	// Token: 0x17002367 RID: 9063
	// (get) Token: 0x060199AA RID: 104874 RVA: 0x006A4EFA File Offset: 0x006A30FA
	// (set) Token: 0x060199AB RID: 104875 RVA: 0x006A4F02 File Offset: 0x006A3102
	public long? PreMessageId { get; set; }
}
