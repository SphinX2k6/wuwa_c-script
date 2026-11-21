using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002577 RID: 9591
	public class EDoInteractJsonConverter : JsonConverter<EDoInteract>
	{
		// Token: 0x0600CFF3 RID: 53235 RVA: 0x001E2264 File Offset: 0x001E0464
		public override EDoInteract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDoInteract.Direct;
			}
			return EDoInteractExtensions.FromString(@string);
		}

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x001E2288 File Offset: 0x001E0488
		public override void Write(Utf8JsonWriter writer, EDoInteract value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
