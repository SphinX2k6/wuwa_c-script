using System;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class GeneratePropertyAccessMethodAttribute : Attribute
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0000A9F2 File Offset: 0x00008BF2
		public GeneratePropertyAccessMethodAttribute(bool generateIter = false)
		{
		}
	}
}
