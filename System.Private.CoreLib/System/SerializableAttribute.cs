using System;
using System.ComponentModel;

namespace System
{
	// Token: 0x020001A2 RID: 418
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class SerializableAttribute : Attribute
	{
	}
}
