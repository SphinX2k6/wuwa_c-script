using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001287 RID: 4743
	public class ERollBlockInteractTypeJsonConverter : JsonConverter<ERollBlockInteractType>
	{
		// Token: 0x06006B08 RID: 27400 RVA: 0x00100C98 File Offset: 0x000FEE98
		public override ERollBlockInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERollBlockInteractType.Normal;
			}
			return ERollBlockInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00100CBC File Offset: 0x000FEEBC
		public override void Write(Utf8JsonWriter writer, ERollBlockInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
