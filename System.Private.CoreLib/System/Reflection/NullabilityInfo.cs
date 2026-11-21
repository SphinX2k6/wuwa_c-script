using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000763 RID: 1891
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class NullabilityInfo
	{
		// Token: 0x060079A6 RID: 31142 RVA: 0x00120604 File Offset: 0x0011E804
		internal NullabilityInfo(Type type, NullabilityState readState, NullabilityState writeState, NullabilityInfo elementType, NullabilityInfo[] typeArguments)
		{
			this.Type = type;
			this.ReadState = readState;
			this.WriteState = writeState;
			this.ElementType = elementType;
			this.GenericTypeArguments = typeArguments;
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x060079A7 RID: 31143 RVA: 0x00120631 File Offset: 0x0011E831
		public Type Type { get; }

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x00120639 File Offset: 0x0011E839
		// (set) Token: 0x060079A9 RID: 31145 RVA: 0x00120641 File Offset: 0x0011E841
		public NullabilityState ReadState { get; internal set; }

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x0012064A File Offset: 0x0011E84A
		// (set) Token: 0x060079AB RID: 31147 RVA: 0x00120652 File Offset: 0x0011E852
		public NullabilityState WriteState { get; internal set; }

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x0012065B File Offset: 0x0011E85B
		[Nullable(2)]
		public NullabilityInfo ElementType { [NullableContext(2)] get; }

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x060079AD RID: 31149 RVA: 0x00120663 File Offset: 0x0011E863
		public NullabilityInfo[] GenericTypeArguments { get; }
	}
}
