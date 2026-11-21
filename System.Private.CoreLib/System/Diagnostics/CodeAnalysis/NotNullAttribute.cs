using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008AD RID: 2221
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	public sealed class NotNullAttribute : Attribute
	{
	}
}
