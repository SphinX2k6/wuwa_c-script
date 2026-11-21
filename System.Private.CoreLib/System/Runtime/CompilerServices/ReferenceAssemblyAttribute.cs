using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B9 RID: 1721
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class ReferenceAssemblyAttribute : Attribute
	{
		// Token: 0x06007442 RID: 29762 RVA: 0x00022817 File Offset: 0x00020A17
		public ReferenceAssemblyAttribute()
		{
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x00115236 File Offset: 0x00113436
		public ReferenceAssemblyAttribute(string description)
		{
			this.Description = description;
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06007444 RID: 29764 RVA: 0x00115245 File Offset: 0x00113445
		public string Description { get; }
	}
}
