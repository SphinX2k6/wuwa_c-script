using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x02000618 RID: 1560
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	public sealed class CustomMarshallerAttribute : Attribute
	{
		// Token: 0x060071EF RID: 29167 RVA: 0x00111A8F File Offset: 0x0010FC8F
		public CustomMarshallerAttribute(Type managedType, MarshalMode marshalMode, Type marshallerType)
		{
			this.ManagedType = managedType;
			this.MarshalMode = marshalMode;
			this.MarshallerType = marshallerType;
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060071F0 RID: 29168 RVA: 0x00111AAC File Offset: 0x0010FCAC
		public Type ManagedType { get; }

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060071F1 RID: 29169 RVA: 0x00111AB4 File Offset: 0x0010FCB4
		public MarshalMode MarshalMode { get; }

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x060071F2 RID: 29170 RVA: 0x00111ABC File Offset: 0x0010FCBC
		public Type MarshallerType { get; }

		// Token: 0x02000619 RID: 1561
		[NullableContext(0)]
		public struct GenericPlaceholder
		{
		}
	}
}
