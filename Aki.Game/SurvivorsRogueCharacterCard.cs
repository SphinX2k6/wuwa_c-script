using System;

// Token: 0x0200210B RID: 8459
public class SurvivorsRogueCharacterCard : SurvivorsRogueCardBaseData, ISurvivorsRogueCharacterCard, ISurvivorsRogueCardBase
{
	// Token: 0x06014C02 RID: 84994 RVA: 0x00609695 File Offset: 0x00607895
	public SurvivorsRogueCharacterCard()
	{
		base.Type = ESurvivorsRogueItemType.Character;
	}

	// Token: 0x17001F61 RID: 8033
	// (get) Token: 0x06014C03 RID: 84995 RVA: 0x006096A4 File Offset: 0x006078A4
	// (set) Token: 0x06014C04 RID: 84996 RVA: 0x006096AC File Offset: 0x006078AC
	public int? PropertyId { get; set; }

	// Token: 0x17001F62 RID: 8034
	// (get) Token: 0x06014C05 RID: 84997 RVA: 0x006096B5 File Offset: 0x006078B5
	// (set) Token: 0x06014C06 RID: 84998 RVA: 0x006096BD File Offset: 0x006078BD
	public int? LvUpCount { get; set; }
}
