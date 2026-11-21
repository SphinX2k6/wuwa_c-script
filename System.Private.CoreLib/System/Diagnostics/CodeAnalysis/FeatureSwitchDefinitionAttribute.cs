using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A9 RID: 2217
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Property, Inherited = false)]
	public sealed class FeatureSwitchDefinitionAttribute : Attribute
	{
		// Token: 0x060089ED RID: 35309 RVA: 0x0014E97F File Offset: 0x0014CB7F
		public FeatureSwitchDefinitionAttribute(string switchName)
		{
			this.SwitchName = switchName;
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x060089EE RID: 35310 RVA: 0x0014E98E File Offset: 0x0014CB8E
		public string SwitchName { get; }
	}
}
