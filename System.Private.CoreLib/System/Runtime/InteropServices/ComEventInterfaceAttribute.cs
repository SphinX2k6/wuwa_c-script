using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005B5 RID: 1461
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class ComEventInterfaceAttribute : Attribute
	{
		// Token: 0x06006FD9 RID: 28633 RVA: 0x0010D5A9 File Offset: 0x0010B7A9
		public ComEventInterfaceAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] Type SourceInterface, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2607)] Type EventProvider)
		{
			this.SourceInterface = SourceInterface;
			this.EventProvider = EventProvider;
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06006FDA RID: 28634 RVA: 0x0010D5BF File Offset: 0x0010B7BF
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
		public Type SourceInterface { get; }

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06006FDB RID: 28635 RVA: 0x0010D5C7 File Offset: 0x0010B7C7
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)2607)]
		public Type EventProvider { get; }
	}
}
