using System;

// Token: 0x02001D6B RID: 7531
public class SkillSlotExtendData : ISkillSlotExtendData
{
	// Token: 0x17001BF1 RID: 7153
	// (get) Token: 0x060129D7 RID: 76247 RVA: 0x0057C097 File Offset: 0x0057A297
	// (set) Token: 0x060129D8 RID: 76248 RVA: 0x0057C09F File Offset: 0x0057A29F
	public int RoleId { get; set; }

	// Token: 0x17001BF2 RID: 7154
	// (get) Token: 0x060129D9 RID: 76249 RVA: 0x0057C0A8 File Offset: 0x0057A2A8
	// (set) Token: 0x060129DA RID: 76250 RVA: 0x0057C0B0 File Offset: 0x0057A2B0
	public int SkillNodeId { get; set; }

	// Token: 0x17001BF3 RID: 7155
	// (get) Token: 0x060129DB RID: 76251 RVA: 0x0057C0B9 File Offset: 0x0057A2B9
	// (set) Token: 0x060129DC RID: 76252 RVA: 0x0057C0C1 File Offset: 0x0057A2C1
	public int IconId { get; set; }

	// Token: 0x17001BF4 RID: 7156
	// (get) Token: 0x060129DD RID: 76253 RVA: 0x0057C0CA File Offset: 0x0057A2CA
	// (set) Token: 0x060129DE RID: 76254 RVA: 0x0057C0D2 File Offset: 0x0057A2D2
	public int CurrentLevel { get; set; }

	// Token: 0x17001BF5 RID: 7157
	// (get) Token: 0x060129DF RID: 76255 RVA: 0x0057C0DB File Offset: 0x0057A2DB
	// (set) Token: 0x060129E0 RID: 76256 RVA: 0x0057C0E3 File Offset: 0x0057A2E3
	public int NormalTargetLevel { get; set; }

	// Token: 0x17001BF6 RID: 7158
	// (get) Token: 0x060129E1 RID: 76257 RVA: 0x0057C0EC File Offset: 0x0057A2EC
	// (set) Token: 0x060129E2 RID: 76258 RVA: 0x0057C0F4 File Offset: 0x0057A2F4
	public int PerfectTargetLevel { get; set; }

	// Token: 0x17001BF7 RID: 7159
	// (get) Token: 0x060129E3 RID: 76259 RVA: 0x0057C0FD File Offset: 0x0057A2FD
	// (set) Token: 0x060129E4 RID: 76260 RVA: 0x0057C105 File Offset: 0x0057A305
	public ESkillType SkillType { get; set; }

	// Token: 0x17001BF8 RID: 7160
	// (get) Token: 0x060129E5 RID: 76261 RVA: 0x0057C10E File Offset: 0x0057A30E
	// (set) Token: 0x060129E6 RID: 76262 RVA: 0x0057C116 File Offset: 0x0057A316
	public int NodeIndex { get; set; }
}
