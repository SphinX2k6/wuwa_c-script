using System;

// Token: 0x020027F0 RID: 10224
public class SkillSlotExtendData : ISkillSlotExtendData
{
	// Token: 0x17001B99 RID: 7065
	// (get) Token: 0x06014FD7 RID: 85975 RVA: 0x00551327 File Offset: 0x0054F527
	// (set) Token: 0x06014FD8 RID: 85976 RVA: 0x0055132F File Offset: 0x0054F52F
	public int RoleId { get; set; }

	// Token: 0x17001B9A RID: 7066
	// (get) Token: 0x06014FD9 RID: 85977 RVA: 0x00551338 File Offset: 0x0054F538
	// (set) Token: 0x06014FDA RID: 85978 RVA: 0x00551340 File Offset: 0x0054F540
	public int SkillNodeId { get; set; }

	// Token: 0x17001B9B RID: 7067
	// (get) Token: 0x06014FDB RID: 85979 RVA: 0x00551349 File Offset: 0x0054F549
	// (set) Token: 0x06014FDC RID: 85980 RVA: 0x00551351 File Offset: 0x0054F551
	public int IconId { get; set; }

	// Token: 0x17001B9C RID: 7068
	// (get) Token: 0x06014FDD RID: 85981 RVA: 0x0055135A File Offset: 0x0054F55A
	// (set) Token: 0x06014FDE RID: 85982 RVA: 0x00551362 File Offset: 0x0054F562
	public int CurrentLevel { get; set; }

	// Token: 0x17001B9D RID: 7069
	// (get) Token: 0x06014FDF RID: 85983 RVA: 0x0055136B File Offset: 0x0054F56B
	// (set) Token: 0x06014FE0 RID: 85984 RVA: 0x00551373 File Offset: 0x0054F573
	public int NormalTargetLevel { get; set; }

	// Token: 0x17001B9E RID: 7070
	// (get) Token: 0x06014FE1 RID: 85985 RVA: 0x0055137C File Offset: 0x0054F57C
	// (set) Token: 0x06014FE2 RID: 85986 RVA: 0x00551384 File Offset: 0x0054F584
	public int PerfectTargetLevel { get; set; }

	// Token: 0x17001B9F RID: 7071
	// (get) Token: 0x06014FE3 RID: 85987 RVA: 0x0055138D File Offset: 0x0054F58D
	// (set) Token: 0x06014FE4 RID: 85988 RVA: 0x00551395 File Offset: 0x0054F595
	public ESkillType SkillType { get; set; }

	// Token: 0x17001BA0 RID: 7072
	// (get) Token: 0x06014FE5 RID: 85989 RVA: 0x0055139E File Offset: 0x0054F59E
	// (set) Token: 0x06014FE6 RID: 85990 RVA: 0x005513A6 File Offset: 0x0054F5A6
	public int NodeIndex { get; set; }
}
