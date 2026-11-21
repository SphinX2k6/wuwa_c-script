using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000042 RID: 66
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumStringMemberAttribute : Attribute
	{
		// Token: 0x06000246 RID: 582 RVA: 0x0000B610 File Offset: 0x00009810
		[NullableContext(1)]
		public EnumStringMemberAttribute(string Value)
		{
		}
	}
}
