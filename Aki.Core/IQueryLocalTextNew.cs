using System;
using System.Runtime.CompilerServices;

// Token: 0x02000043 RID: 67
public interface IQueryLocalTextNew : global::IConfigQuery, IStaticVariableResetter
{
	// Token: 0x060001BC RID: 444
	[NullableContext(2)]
	public abstract static string GetLocalTextNew([Nullable(1)] string id, string culture = null);
}
