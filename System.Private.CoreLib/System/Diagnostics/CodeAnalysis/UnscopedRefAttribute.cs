using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B5 RID: 2229
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public sealed class UnscopedRefAttribute : Attribute
	{
	}
}
