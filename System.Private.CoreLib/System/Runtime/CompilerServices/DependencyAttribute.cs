using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000692 RID: 1682
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class DependencyAttribute : Attribute
	{
		// Token: 0x060073EC RID: 29676 RVA: 0x00114838 File Offset: 0x00112A38
		public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument)
		{
			this.DependentAssembly = dependentAssemblyArgument;
			this.LoadHint = loadHintArgument;
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x060073ED RID: 29677 RVA: 0x0011484E File Offset: 0x00112A4E
		public string DependentAssembly { get; }

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x060073EE RID: 29678 RVA: 0x00114856 File Offset: 0x00112A56
		public LoadHint LoadHint { get; }
	}
}
