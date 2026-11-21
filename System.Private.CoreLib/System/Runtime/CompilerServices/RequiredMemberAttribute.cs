using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006C3 RID: 1731
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class RequiredMemberAttribute : Attribute
	{
	}
}
