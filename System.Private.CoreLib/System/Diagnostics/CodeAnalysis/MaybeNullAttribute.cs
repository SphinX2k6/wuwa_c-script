using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008AC RID: 2220
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	public sealed class MaybeNullAttribute : Attribute
	{
	}
}
