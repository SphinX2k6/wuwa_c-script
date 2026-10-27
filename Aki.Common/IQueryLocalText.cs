using System;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
public interface IQueryLocalText : IConfigQuery, IStaticVariableResetter
{
	// Token: 0x06000003 RID: 3
	[NullableContext(2)]
	public abstract static string GetLocalText(int id, string culture = null);
}
