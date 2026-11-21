using System;
using System.Runtime.CompilerServices;

// Token: 0x02002405 RID: 9221
[NullableContext(1)]
[Nullable(0)]
public static class SpecialIgnoreBullet
{
	// Token: 0x06017156 RID: 94550 RVA: 0x006BF9A3 File Offset: 0x006BDBA3
	public static bool CheckBulletInSpecialList(string checkBulletId)
	{
		return Array.IndexOf<string>(SpecialIgnoreBullet.Values, checkBulletId) >= 0;
	}

	// Token: 0x0400C23B RID: 49723
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
