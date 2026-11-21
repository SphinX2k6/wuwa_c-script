using System;

namespace System.Diagnostics.Contracts
{
	// Token: 0x0200089D RID: 2205
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractArgumentValidatorAttribute : Attribute
	{
	}
}
