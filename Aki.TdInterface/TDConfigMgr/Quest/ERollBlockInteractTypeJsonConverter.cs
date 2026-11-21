using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C7 RID: 5063
	public class ERollBlockInteractTypeJsonConverter : JsonConverter<ERollBlockInteractType>
	{
		// Token: 0x0600715B RID: 29019 RVA: 0x0010E994 File Offset: 0x0010CB94
		public override ERollBlockInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERollBlockInteractType.Normal;
			}
			return ERollBlockInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x0010E9B8 File Offset: 0x0010CBB8
		public override void Write(Utf8JsonWriter writer, ERollBlockInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
