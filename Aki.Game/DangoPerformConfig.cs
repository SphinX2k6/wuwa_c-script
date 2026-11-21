using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02000F2C RID: 3884
public class DangoPerformConfig
{
	// Token: 0x04005C94 RID: 23700
	public EDangoActionPerformType ActionType;

	// Token: 0x04005C95 RID: 23701
	public EDangoActionTargetType ActionTargetType;

	// Token: 0x04005C96 RID: 23702
	public EDangoActionPerformType RecursionActionType;

	// Token: 0x04005C97 RID: 23703
	public int Duration;

	// Token: 0x04005C98 RID: 23704
	[Nullable(1)]
	public List<DangoPerformEffectConfig> EffectConfigList = new List<DangoPerformEffectConfig>();
}
