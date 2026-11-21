using System;
using System.ComponentModel;

namespace System
{
	// Token: 0x02000173 RID: 371
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class NonSerializedAttribute : Attribute
	{
	}
}
