using System;
using System.Runtime.CompilerServices;

// Token: 0x020016A3 RID: 5795
public static class MailFilterDisplayOrder
{
	// Token: 0x04008101 RID: 33025
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly EMailFilter[] mailFilterDisplayOrder = new EMailFilter[]
	{
		EMailFilter.FilterAll,
		EMailFilter.FilterFavorite,
		EMailFilter.FilterImportant
	};
}
