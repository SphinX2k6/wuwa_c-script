using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x02000525 RID: 1317
	[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06004897 RID: 18583 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(1)]
		public void AddSerializedState(ISafeSerializationData serializedState)
		{
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x000F136C File Offset: 0x000EF56C
		public StreamingContext StreamingContext { get; }
	}
}
