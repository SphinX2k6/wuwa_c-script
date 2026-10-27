using System;
using System.Runtime.CompilerServices;

// Token: 0x02001424 RID: 5156
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleRoleSkillMaxTipsControllerParam : IPinballBattleRoleSkillMaxTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000C90 RID: 3216
	// (get) Token: 0x06009167 RID: 37223 RVA: 0x001F2DD6 File Offset: 0x001F0FD6
	// (set) Token: 0x06009168 RID: 37224 RVA: 0x001F2DDE File Offset: 0x001F0FDE
	public int RoleId { get; set; }

	// Token: 0x17000C91 RID: 3217
	// (get) Token: 0x06009169 RID: 37225 RVA: 0x001F2DE7 File Offset: 0x001F0FE7
	// (set) Token: 0x0600916A RID: 37226 RVA: 0x001F2DEF File Offset: 0x001F0FEF
	public Action CloseCallback { get; set; }

	// Token: 0x17000C92 RID: 3218
	// (get) Token: 0x0600916B RID: 37227 RVA: 0x001F2DF8 File Offset: 0x001F0FF8
	// (set) Token: 0x0600916C RID: 37228 RVA: 0x001F2E00 File Offset: 0x001F1000
	public bool? AddMask { get; set; }

	// Token: 0x17000C93 RID: 3219
	// (get) Token: 0x0600916D RID: 37229 RVA: 0x001F2E09 File Offset: 0x001F1009
	// (set) Token: 0x0600916E RID: 37230 RVA: 0x001F2E11 File Offset: 0x001F1011
	public int? CloseTime { get; set; }

	// Token: 0x17000C94 RID: 3220
	// (get) Token: 0x0600916F RID: 37231 RVA: 0x001F2E1A File Offset: 0x001F101A
	// (set) Token: 0x06009170 RID: 37232 RVA: 0x001F2E22 File Offset: 0x001F1022
	public bool? MoveToBehind { get; set; }
}
