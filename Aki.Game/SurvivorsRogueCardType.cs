using System;
using System.Runtime.CompilerServices;

// Token: 0x02002111 RID: 8465
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCardType : ISurvivorsRogueCardType
{
	// Token: 0x17001F72 RID: 8050
	// (get) Token: 0x06014C1C RID: 85020 RVA: 0x00609728 File Offset: 0x00607928
	// (set) Token: 0x06014C1D RID: 85021 RVA: 0x00609730 File Offset: 0x00607930
	public ISurvivorsRogueItemCard Normal { get; set; }

	// Token: 0x17001F73 RID: 8051
	// (get) Token: 0x06014C1E RID: 85022 RVA: 0x00609739 File Offset: 0x00607939
	// (set) Token: 0x06014C1F RID: 85023 RVA: 0x00609741 File Offset: 0x00607941
	public ISurvivorsRogueWeaponCard Weapon { get; set; }

	// Token: 0x17001F74 RID: 8052
	// (get) Token: 0x06014C20 RID: 85024 RVA: 0x0060974A File Offset: 0x0060794A
	// (set) Token: 0x06014C21 RID: 85025 RVA: 0x00609752 File Offset: 0x00607952
	public ISurvivorsRogueCharacterCard Character { get; set; }
}
