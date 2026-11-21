using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000085 RID: 133
public static class EntityHelperConstants
{
	// Token: 0x040003CA RID: 970
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly FName[] GlobalEntityTypeQueryName = new FName[]
	{
		"NormalEntity",
		"NormalEntityAlwaysTickGroup",
		"NormalEntityAlwaysTickWhitoutNotRenderedGroup",
		"MoveSceneItemEntity",
		"SimpleNpcEntity",
		"NormalNpcEntity",
		"CharacterEntity",
		"BossEntity",
		"PlayerAlwaysTickGroup"
	};
}
