using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
public interface IQueryLocalTextNew : IConfigQuery, IStaticVariableResetter
{
	// Token: 0x06000004 RID: 4
	[NullableContext(2)]
	public abstract static string GetLocalTextNew([Nullable(1)] string id, string culture = null);
}
