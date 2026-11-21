using System;

namespace System
{
	// Token: 0x0200009D RID: 157
	internal interface ITypeIdentifier : ITypeName, IEquatable<ITypeName>
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600087B RID: 2171
		string InternalName { get; }
	}
}
