using System;
using System.Runtime.CompilerServices;

// Token: 0x02002110 RID: 8464
[NullableContext(1)]
public interface ISurvivorsRogueCardType
{
	// Token: 0x17001F6F RID: 8047
	// (get) Token: 0x06014C19 RID: 85017
	ISurvivorsRogueItemCard Normal { get; }

	// Token: 0x17001F70 RID: 8048
	// (get) Token: 0x06014C1A RID: 85018
	ISurvivorsRogueWeaponCard Weapon { get; }

	// Token: 0x17001F71 RID: 8049
	// (get) Token: 0x06014C1B RID: 85019
	ISurvivorsRogueCharacterCard Character { get; }
}
