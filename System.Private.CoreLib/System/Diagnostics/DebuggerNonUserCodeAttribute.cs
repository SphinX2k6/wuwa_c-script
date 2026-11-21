using System;

namespace System.Diagnostics
{
	// Token: 0x02000886 RID: 2182
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	public sealed class DebuggerNonUserCodeAttribute : Attribute
	{
	}
}
