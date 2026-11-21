using System;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json
{
	// Token: 0x02000039 RID: 57
	internal sealed class ArgumentState
	{
		// Token: 0x040000C3 RID: 195
		public object Arguments;

		// Token: 0x040000C4 RID: 196
		public ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] FoundProperties;

		// Token: 0x040000C5 RID: 197
		public ValueTuple<JsonPropertyInfo, object, string>[] FoundPropertiesAsync;

		// Token: 0x040000C6 RID: 198
		public int FoundPropertyCount;

		// Token: 0x040000C7 RID: 199
		public JsonParameterInfo JsonParameterInfo;
	}
}
