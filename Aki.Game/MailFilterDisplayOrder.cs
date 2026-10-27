using System;
using System.Runtime.CompilerServices;

// Token: 0x020021BF RID: 8639
public static class MailFilterDisplayOrder
{
	// Token: 0x04007FBA RID: 32698
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly EMailFilter[] mailFilterDisplayOrder = new EMailFilter[]
	{
		EMailFilter.FilterAll,
		EMailFilter.FilterFavorite,
		EMailFilter.FilterImportant
	};
}
