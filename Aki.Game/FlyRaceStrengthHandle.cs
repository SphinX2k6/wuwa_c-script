using System;

// Token: 0x02001F2A RID: 7978
public class FlyRaceStrengthHandle : RaceStrengthHandle
{
	// Token: 0x0600F5C2 RID: 62914 RVA: 0x003B4C13 File Offset: 0x003B2E13
	protected override void InitTagAndAttributeId()
	{
		this.FormationAttributeId = EFormationAttributeId.FlameRaceStrength;
		this.VisibleTagId = GameplayTagDefine.EGameplayTagId["关卡.圣火追逐.专用ui"];
		this.SpeedUpTagId = GameplayTagDefine.EGameplayTagId["关卡.圣火追逐.能量不衰减"];
	}
}
