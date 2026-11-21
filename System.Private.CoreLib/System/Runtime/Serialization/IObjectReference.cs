using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x0200051D RID: 1309
	[NullableContext(1)]
	[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public interface IObjectReference
	{
		// Token: 0x0600488D RID: 18573
		object GetRealObject(StreamingContext context);
	}
}
