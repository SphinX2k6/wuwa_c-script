using System;
using System.Runtime.CompilerServices;

// Token: 0x02001422 RID: 5154
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleRoleSkillReleaseTipsControllerParam : IPinballBattleRoleSkillReleaseTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000C86 RID: 3206
	// (get) Token: 0x06009151 RID: 37201 RVA: 0x001F2D11 File Offset: 0x001F0F11
	// (set) Token: 0x06009152 RID: 37202 RVA: 0x001F2D19 File Offset: 0x001F0F19
	public int RoleId { get; set; }

	// Token: 0x17000C87 RID: 3207
	// (get) Token: 0x06009153 RID: 37203 RVA: 0x001F2D22 File Offset: 0x001F0F22
	// (set) Token: 0x06009154 RID: 37204 RVA: 0x001F2D2A File Offset: 0x001F0F2A
	public Action CloseCallback { get; set; }

	// Token: 0x17000C88 RID: 3208
	// (get) Token: 0x06009155 RID: 37205 RVA: 0x001F2D33 File Offset: 0x001F0F33
	// (set) Token: 0x06009156 RID: 37206 RVA: 0x001F2D3B File Offset: 0x001F0F3B
	public bool? AddMask { get; set; }

	// Token: 0x17000C89 RID: 3209
	// (get) Token: 0x06009157 RID: 37207 RVA: 0x001F2D44 File Offset: 0x001F0F44
	// (set) Token: 0x06009158 RID: 37208 RVA: 0x001F2D4C File Offset: 0x001F0F4C
	public int? CloseTime { get; set; }

	// Token: 0x17000C8A RID: 3210
	// (get) Token: 0x06009159 RID: 37209 RVA: 0x001F2D55 File Offset: 0x001F0F55
	// (set) Token: 0x0600915A RID: 37210 RVA: 0x001F2D5D File Offset: 0x001F0F5D
	public bool? MoveToBehind { get; set; }
}
