using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B94 RID: 11156
[NullableContext(1)]
public interface ISurvivorsRogueCardType
{
	// Token: 0x17001F17 RID: 7959
	// (get) Token: 0x060171E8 RID: 94696
	ISurvivorsRogueItemCard Normal { get; }

	// Token: 0x17001F18 RID: 7960
	// (get) Token: 0x060171E9 RID: 94697
	ISurvivorsRogueWeaponCard Weapon { get; }

	// Token: 0x17001F19 RID: 7961
	// (get) Token: 0x060171EA RID: 94698
	ISurvivorsRogueCharacterCard Character { get; }
}
