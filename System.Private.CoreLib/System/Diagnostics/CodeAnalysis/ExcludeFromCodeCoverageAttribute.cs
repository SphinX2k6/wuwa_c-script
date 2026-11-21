using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A6 RID: 2214
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
	public sealed class ExcludeFromCodeCoverageAttribute : Attribute
	{
		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x0014E92F File Offset: 0x0014CB2F
		// (set) Token: 0x060089E6 RID: 35302 RVA: 0x0014E937 File Offset: 0x0014CB37
		public string Justification { get; set; }
	}
}
