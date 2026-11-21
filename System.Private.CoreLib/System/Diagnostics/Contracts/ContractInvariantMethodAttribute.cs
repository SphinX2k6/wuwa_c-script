using System;

namespace System.Diagnostics.Contracts
{
	// Token: 0x02000898 RID: 2200
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class ContractInvariantMethodAttribute : Attribute
	{
	}
}
