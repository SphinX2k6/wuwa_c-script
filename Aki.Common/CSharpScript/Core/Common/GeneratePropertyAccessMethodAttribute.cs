using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class GeneratePropertyAccessMethodAttribute : Attribute
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000E19A File Offset: 0x0000C39A
		[NullableContext(2)]
		public GeneratePropertyAccessMethodAttribute(bool generateIter = false, bool generateSet = true, string uniformType = null)
		{
		}
	}
}
