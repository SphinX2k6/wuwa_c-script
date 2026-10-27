using System;
using System.Runtime.CompilerServices;

// Token: 0x02000042 RID: 66
public interface IQueryLocalText : global::IConfigQuery, IStaticVariableResetter
{
	// Token: 0x060001BA RID: 442
	[NullableContext(2)]
	public abstract static string GetLocalText(int id, string culture = null);
}
