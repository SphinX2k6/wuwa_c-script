using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B5 RID: 1717
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	public class MetadataUpdateOriginalTypeAttribute : Attribute
	{
		// Token: 0x0600743C RID: 29756 RVA: 0x001151DA File Offset: 0x001133DA
		public MetadataUpdateOriginalTypeAttribute(Type originalType)
		{
			this.OriginalType = originalType;
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x0600743D RID: 29757 RVA: 0x001151E9 File Offset: 0x001133E9
		public Type OriginalType { get; }
	}
}
