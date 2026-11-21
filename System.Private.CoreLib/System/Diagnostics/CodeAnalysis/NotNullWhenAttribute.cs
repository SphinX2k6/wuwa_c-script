using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008AF RID: 2223
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x060089F5 RID: 35317 RVA: 0x0014E9AD File Offset: 0x0014CBAD
		public NotNullWhenAttribute(bool returnValue)
		{
			this.ReturnValue = returnValue;
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060089F6 RID: 35318 RVA: 0x0014E9BC File Offset: 0x0014CBBC
		public bool ReturnValue { get; }
	}
}
