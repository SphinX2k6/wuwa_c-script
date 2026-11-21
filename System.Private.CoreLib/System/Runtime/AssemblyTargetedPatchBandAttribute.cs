using System;
using System.Runtime.CompilerServices;

namespace System.Runtime
{
	// Token: 0x02000504 RID: 1284
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTargetedPatchBandAttribute : Attribute
	{
		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x000F0AA0 File Offset: 0x000EECA0
		public string TargetedPatchBand { get; }

		// Token: 0x06004841 RID: 18497 RVA: 0x000F0AA8 File Offset: 0x000EECA8
		public AssemblyTargetedPatchBandAttribute(string targetedPatchBand)
		{
			this.TargetedPatchBand = targetedPatchBand;
		}
	}
}
