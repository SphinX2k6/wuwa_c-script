using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02000137 RID: 311
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OverrideFunctionAttribute : Attribute
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x000358CD File Offset: 0x00033ACD
		public OverrideFunctionAttribute()
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000358D5 File Offset: 0x00033AD5
		[NullableContext(1)]
		public OverrideFunctionAttribute(string propertyName)
		{
		}
	}
}
