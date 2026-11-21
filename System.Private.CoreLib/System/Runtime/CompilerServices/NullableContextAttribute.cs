using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B7 RID: 1719
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class NullableContextAttribute : Attribute
	{
		// Token: 0x06007440 RID: 29760 RVA: 0x00115218 File Offset: 0x00113418
		public NullableContextAttribute(byte value)
		{
			this.Flag = value;
		}

		// Token: 0x040014D4 RID: 5332
		public readonly byte Flag;
	}
}
