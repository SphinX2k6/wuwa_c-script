using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D6 RID: 2262
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleRoleSkillReleaseTipsControllerParam : IPinballBattleRoleSkillReleaseTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000CA6 RID: 3238
	// (get) Token: 0x060064E6 RID: 25830 RVA: 0x001FB84D File Offset: 0x001F9A4D
	// (set) Token: 0x060064E7 RID: 25831 RVA: 0x001FB855 File Offset: 0x001F9A55
	public int RoleId { get; set; }

	// Token: 0x17000CA7 RID: 3239
	// (get) Token: 0x060064E8 RID: 25832 RVA: 0x001FB85E File Offset: 0x001F9A5E
	// (set) Token: 0x060064E9 RID: 25833 RVA: 0x001FB866 File Offset: 0x001F9A66
	public Action CloseCallback { get; set; }

	// Token: 0x17000CA8 RID: 3240
	// (get) Token: 0x060064EA RID: 25834 RVA: 0x001FB86F File Offset: 0x001F9A6F
	// (set) Token: 0x060064EB RID: 25835 RVA: 0x001FB877 File Offset: 0x001F9A77
	public bool? AddMask { get; set; }

	// Token: 0x17000CA9 RID: 3241
	// (get) Token: 0x060064EC RID: 25836 RVA: 0x001FB880 File Offset: 0x001F9A80
	// (set) Token: 0x060064ED RID: 25837 RVA: 0x001FB888 File Offset: 0x001F9A88
	public int? CloseTime { get; set; }

	// Token: 0x17000CAA RID: 3242
	// (get) Token: 0x060064EE RID: 25838 RVA: 0x001FB891 File Offset: 0x001F9A91
	// (set) Token: 0x060064EF RID: 25839 RVA: 0x001FB899 File Offset: 0x001F9A99
	public bool? MoveToBehind { get; set; }
}
