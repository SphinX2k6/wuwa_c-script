using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x0200051F RID: 1311
	[NullableContext(1)]
	public interface ISerializable
	{
		// Token: 0x0600488F RID: 18575
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}
