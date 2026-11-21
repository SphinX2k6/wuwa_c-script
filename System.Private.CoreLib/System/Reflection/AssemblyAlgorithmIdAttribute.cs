using System;
using System.Configuration.Assemblies;

namespace System.Reflection
{
	// Token: 0x0200071D RID: 1821
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyAlgorithmIdAttribute : Attribute
	{
		// Token: 0x06007859 RID: 30809 RVA: 0x0011E67B File Offset: 0x0011C87B
		public AssemblyAlgorithmIdAttribute(AssemblyHashAlgorithm algorithmId)
		{
			this.AlgorithmId = algorithmId;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x0011E67B File Offset: 0x0011C87B
		[CLSCompliant(false)]
		public AssemblyAlgorithmIdAttribute(uint algorithmId)
		{
			this.AlgorithmId = algorithmId;
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x0600785B RID: 30811 RVA: 0x0011E68A File Offset: 0x0011C88A
		[CLSCompliant(false)]
		public uint AlgorithmId { get; }
	}
}
