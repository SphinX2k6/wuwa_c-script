using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000083 RID: 131
public static class EntityHelperConstants
{
	// Token: 0x040003BC RID: 956
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
