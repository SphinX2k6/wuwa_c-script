using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097D RID: 2429
	public class EInteractTurnAroundJsonConverter : JsonConverter<EInteractTurnAround>
	{
		// Token: 0x06003665 RID: 13925 RVA: 0x0008DCE8 File Offset: 0x0008BEE8
		public override EInteractTurnAround Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractTurnAround.FaceEachOther;
			}
			return EInteractTurnAroundExtensions.FromString(@string);
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0008DD0C File Offset: 0x0008BF0C
		public override void Write(Utf8JsonWriter writer, EInteractTurnAround value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
