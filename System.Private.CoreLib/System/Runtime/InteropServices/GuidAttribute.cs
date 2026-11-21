using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D1 RID: 1489
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class GuidAttribute : Attribute
	{
		// Token: 0x06007027 RID: 28711 RVA: 0x0010DBC3 File Offset: 0x0010BDC3
		public GuidAttribute(string guid)
		{
			this.Value = guid;
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06007028 RID: 28712 RVA: 0x0010DBD2 File Offset: 0x0010BDD2
		public string Value { get; }
	}
}
