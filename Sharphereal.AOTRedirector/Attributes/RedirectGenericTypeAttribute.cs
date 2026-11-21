using System;
using System.Runtime.CompilerServices;

namespace Sharphereal.AOTRedirector.Attributes
{
	// Token: 0x0200000E RID: 14
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class)]
	public class RedirectGenericTypeAttribute : Attribute
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000028A1 File Offset: 0x00000AA1
		public RedirectGenericTypeAttribute(Type sourceGenericDefinitionType)
		{
		}

		// Token: 0x0400001B RID: 27
		public Type sourceGenericDefinitionType = sourceGenericDefinitionType;
	}
}
