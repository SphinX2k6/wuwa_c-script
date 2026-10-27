using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02002EB2 RID: 11954
[NullableContext(1)]
[Nullable(0)]
public static class SpecialIgnoreBullet
{
	// Token: 0x06019870 RID: 104560 RVA: 0x006996EB File Offset: 0x006978EB
	public static bool CheckBulletInSpecialList(string checkBulletId)
	{
		return SpecialIgnoreBullet.Values.Contains(checkBulletId);
	}

	// Token: 0x0400BEA0 RID: 48800
	[StaticVariableRuleIgnore]
	public static readonly string[] Values = new string[]
	{
		"4000000003",
		"210000004",
		"80004012001",
		"80012901001",
		"80012901003",
		"80012901004",
		"80012901005",
		"80012901006",
		"80012901008",
		"80012901009",
		"200300046",
		"200100013"
	};
}
