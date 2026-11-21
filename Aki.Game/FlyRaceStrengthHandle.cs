using System;

// Token: 0x020013EC RID: 5100
public class FlyRaceStrengthHandle : RaceStrengthHandle
{
	// Token: 0x0600C9E1 RID: 51681 RVA: 0x003C06FF File Offset: 0x003BE8FF
	protected override void InitTagAndAttributeId()
	{
		this.FormationAttributeId = EFormationAttributeId.FlameRaceStrength;
		this.VisibleTagId = GameplayTagDefine.EGameplayTagId["关卡.圣火追逐.专用ui"];
		this.SpeedUpTagId = GameplayTagDefine.EGameplayTagId["关卡.圣火追逐.能量不衰减"];
	}
}
