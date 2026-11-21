using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x0200051E RID: 1310
	[NullableContext(1)]
	[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public interface ISafeSerializationData
	{
		// Token: 0x0600488E RID: 18574
		void CompleteDeserialization(object deserialized);
	}
}
