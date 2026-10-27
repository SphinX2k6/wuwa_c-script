using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200274F RID: 10063
public class ReconnectDefine
{
	// Token: 0x04009B1E RID: 39710
	[StaticVariableRuleIgnore]
	public static readonly FName ReconnectMapName = new FName("/Game/Aki/Map/Launch/Bootstrap");

	// Token: 0x04009B1F RID: 39711
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly IReadOnlyList<string> ellipsis = new <>z__ReadOnlyArray<string>(new string[]
	{
		"",
		".",
		"..",
		"..."
	});
}
