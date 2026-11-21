using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B0 RID: 2224
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
	public sealed class NotNullIfNotNullAttribute : Attribute
	{
		// Token: 0x060089F7 RID: 35319 RVA: 0x0014E9C4 File Offset: 0x0014CBC4
		public NotNullIfNotNullAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x060089F8 RID: 35320 RVA: 0x0014E9D3 File Offset: 0x0014CBD3
		public string ParameterName { get; }
	}
}
