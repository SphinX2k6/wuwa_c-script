using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008AB RID: 2219
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	public sealed class DisallowNullAttribute : Attribute
	{
	}
}
