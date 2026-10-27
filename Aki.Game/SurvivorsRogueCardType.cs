using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B95 RID: 11157
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCardType : ISurvivorsRogueCardType
{
	// Token: 0x17001F1A RID: 7962
	// (get) Token: 0x060171EB RID: 94699 RVA: 0x005DCB48 File Offset: 0x005DAD48
	// (set) Token: 0x060171EC RID: 94700 RVA: 0x005DCB50 File Offset: 0x005DAD50
	public ISurvivorsRogueItemCard Normal { get; set; }

	// Token: 0x17001F1B RID: 7963
	// (get) Token: 0x060171ED RID: 94701 RVA: 0x005DCB59 File Offset: 0x005DAD59
	// (set) Token: 0x060171EE RID: 94702 RVA: 0x005DCB61 File Offset: 0x005DAD61
	public ISurvivorsRogueWeaponCard Weapon { get; set; }

	// Token: 0x17001F1C RID: 7964
	// (get) Token: 0x060171EF RID: 94703 RVA: 0x005DCB6A File Offset: 0x005DAD6A
	// (set) Token: 0x060171F0 RID: 94704 RVA: 0x005DCB72 File Offset: 0x005DAD72
	public ISurvivorsRogueCharacterCard Character { get; set; }
}
