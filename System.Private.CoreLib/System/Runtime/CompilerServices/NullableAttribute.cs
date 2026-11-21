using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B6 RID: 1718
	[NullableContext(1)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
	public sealed class NullableAttribute : Attribute
	{
		// Token: 0x0600743E RID: 29758 RVA: 0x001151F1 File Offset: 0x001133F1
		public NullableAttribute(byte value)
		{
			this.NullableFlags = new byte[]
			{
				value
			};
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00115209 File Offset: 0x00113409
		public NullableAttribute(byte[] value)
		{
			this.NullableFlags = value;
		}

		// Token: 0x040014D3 RID: 5331
		public readonly byte[] NullableFlags;
	}
}
