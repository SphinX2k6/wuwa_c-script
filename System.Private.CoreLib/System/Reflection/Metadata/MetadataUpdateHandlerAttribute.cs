using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection.Metadata
{
	// Token: 0x02000793 RID: 1939
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class MetadataUpdateHandlerAttribute : Attribute
	{
		// Token: 0x06007B98 RID: 31640 RVA: 0x001234E0 File Offset: 0x001216E0
		public MetadataUpdateHandlerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type handlerType)
		{
			this.HandlerType = handlerType;
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06007B99 RID: 31641 RVA: 0x001234EF File Offset: 0x001216EF
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public Type HandlerType { get; }
	}
}
