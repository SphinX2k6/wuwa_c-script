using System;

namespace System
{
	// Token: 0x0200009C RID: 156
	internal interface ITypeName : IEquatable<ITypeName>
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000879 RID: 2169
		string DisplayName { get; }

		// Token: 0x0600087A RID: 2170
		ITypeName NestedName(ITypeIdentifier innerName);
	}
}
