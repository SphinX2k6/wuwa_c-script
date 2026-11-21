using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008AE RID: 2222
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class MaybeNullWhenAttribute : Attribute
	{
		// Token: 0x060089F3 RID: 35315 RVA: 0x0014E996 File Offset: 0x0014CB96
		public MaybeNullWhenAttribute(bool returnValue)
		{
			this.ReturnValue = returnValue;
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060089F4 RID: 35316 RVA: 0x0014E9A5 File Offset: 0x0014CBA5
		public bool ReturnValue { get; }
	}
}
