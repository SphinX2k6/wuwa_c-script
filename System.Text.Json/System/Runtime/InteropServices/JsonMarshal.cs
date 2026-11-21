using System;
using System.Text.Json;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000005 RID: 5
	public static class JsonMarshal
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00002C20 File Offset: 0x00000E20
		public static ReadOnlySpan<byte> GetRawUtf8Value(JsonElement element)
		{
			return element.GetRawValue().Span;
		}
	}
}
