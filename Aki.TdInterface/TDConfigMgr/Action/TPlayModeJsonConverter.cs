using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C2 RID: 9410
	public class TPlayModeJsonConverter : JsonConverter<TPlayMode>
	{
		// Token: 0x0600CBE9 RID: 52201 RVA: 0x001E078C File Offset: 0x001DE98C
		public override TPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TPlayMode.direct;
			}
			return TPlayModeExtensions.FromString(@string);
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x001E07B0 File Offset: 0x001DE9B0
		public override void Write(Utf8JsonWriter writer, TPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
