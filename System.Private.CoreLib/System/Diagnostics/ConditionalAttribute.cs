using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x0200087B RID: 2171
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ConditionalAttribute : Attribute
	{
		// Token: 0x060088EE RID: 35054 RVA: 0x0014D588 File Offset: 0x0014B788
		public ConditionalAttribute(string conditionString)
		{
			this.ConditionString = conditionString;
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060088EF RID: 35055 RVA: 0x0014D597 File Offset: 0x0014B797
		public string ConditionString { get; }
	}
}
