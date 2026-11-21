using System;

// Token: 0x0200210C RID: 8460
public interface ISurvivorsRogueWeaponCard : ISurvivorsRogueCardBase
{
	// Token: 0x17001F63 RID: 8035
	// (get) Token: 0x06014C07 RID: 84999
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F64 RID: 8036
	// (get) Token: 0x06014C08 RID: 85000
	int Id { get; }

	// Token: 0x17001F65 RID: 8037
	// (get) Token: 0x06014C09 RID: 85001
	int? PropertyId { get; }

	// Token: 0x17001F66 RID: 8038
	// (get) Token: 0x06014C0A RID: 85002
	int? LvUpCount { get; }

	// Token: 0x17001F67 RID: 8039
	// (get) Token: 0x06014C0B RID: 85003
	bool? WeaponBondInfo { get; }
}
