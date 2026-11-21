using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D8 RID: 2264
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleRoleSkillMaxTipsControllerParam : IPinballBattleRoleSkillMaxTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000CB0 RID: 3248
	// (get) Token: 0x060064FC RID: 25852 RVA: 0x001FB912 File Offset: 0x001F9B12
	// (set) Token: 0x060064FD RID: 25853 RVA: 0x001FB91A File Offset: 0x001F9B1A
	public int RoleId { get; set; }

	// Token: 0x17000CB1 RID: 3249
	// (get) Token: 0x060064FE RID: 25854 RVA: 0x001FB923 File Offset: 0x001F9B23
	// (set) Token: 0x060064FF RID: 25855 RVA: 0x001FB92B File Offset: 0x001F9B2B
	public Action CloseCallback { get; set; }

	// Token: 0x17000CB2 RID: 3250
	// (get) Token: 0x06006500 RID: 25856 RVA: 0x001FB934 File Offset: 0x001F9B34
	// (set) Token: 0x06006501 RID: 25857 RVA: 0x001FB93C File Offset: 0x001F9B3C
	public bool? AddMask { get; set; }

	// Token: 0x17000CB3 RID: 3251
	// (get) Token: 0x06006502 RID: 25858 RVA: 0x001FB945 File Offset: 0x001F9B45
	// (set) Token: 0x06006503 RID: 25859 RVA: 0x001FB94D File Offset: 0x001F9B4D
	public int? CloseTime { get; set; }

	// Token: 0x17000CB4 RID: 3252
	// (get) Token: 0x06006504 RID: 25860 RVA: 0x001FB956 File Offset: 0x001F9B56
	// (set) Token: 0x06006505 RID: 25861 RVA: 0x001FB95E File Offset: 0x001F9B5E
	public bool? MoveToBehind { get; set; }
}
