using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D1 RID: 2513
	public class EPickInteractionJsonConverter : JsonConverter<EPickInteraction>
	{
		// Token: 0x060037DF RID: 14303 RVA: 0x0009115C File Offset: 0x0008F35C
		public override EPickInteraction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPickInteraction.ChessmanInteract;
			}
			return EPickInteractionExtensions.FromString(@string);
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x00091180 File Offset: 0x0008F380
		public override void Write(Utf8JsonWriter writer, EPickInteraction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
