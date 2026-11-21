using System;

namespace System.Diagnostics.Contracts
{
	// Token: 0x0200089E RID: 2206
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractAbbreviatorAttribute : Attribute
	{
	}
}
