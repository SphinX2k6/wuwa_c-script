using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.SymbolStore
{
	// Token: 0x02000892 RID: 2194
	[NullableContext(1)]
	public interface ISymbolDocumentWriter
	{
		// Token: 0x06008991 RID: 35217
		void SetCheckSum(Guid algorithmId, byte[] checkSum);

		// Token: 0x06008992 RID: 35218
		void SetSource(byte[] source);
	}
}
