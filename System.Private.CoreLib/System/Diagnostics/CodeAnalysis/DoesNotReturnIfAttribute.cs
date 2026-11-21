using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B2 RID: 2226
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class DoesNotReturnIfAttribute : Attribute
	{
		// Token: 0x060089FA RID: 35322 RVA: 0x0014E9DB File Offset: 0x0014CBDB
		public DoesNotReturnIfAttribute(bool parameterValue)
		{
			this.ParameterValue = parameterValue;
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060089FB RID: 35323 RVA: 0x0014E9EA File Offset: 0x0014CBEA
		public bool ParameterValue { get; }
	}
}
