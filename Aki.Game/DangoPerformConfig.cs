using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02001A6D RID: 6765
public class DangoPerformConfig
{
	// Token: 0x04005BC5 RID: 23493
	public EDangoActionPerformType ActionType;

	// Token: 0x04005BC6 RID: 23494
	public EDangoActionTargetType ActionTargetType;

	// Token: 0x04005BC7 RID: 23495
	public EDangoActionPerformType RecursionActionType;

	// Token: 0x04005BC8 RID: 23496
	public int Duration;

	// Token: 0x04005BC9 RID: 23497
	[Nullable(1)]
	public List<DangoPerformEffectConfig> EffectConfigList = new List<DangoPerformEffectConfig>();
}
