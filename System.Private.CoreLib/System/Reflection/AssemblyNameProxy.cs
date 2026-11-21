using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200072E RID: 1838
	public class AssemblyNameProxy : MarshalByRefObject
	{
		// Token: 0x0600787F RID: 30847 RVA: 0x0011E926 File Offset: 0x0011CB26
		[NullableContext(1)]
		public AssemblyName GetAssemblyName(string assemblyFile)
		{
			return AssemblyName.GetAssemblyName(assemblyFile);
		}
	}
}
