using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2A RID: 2602
	public class EInteractPlayerDiractionTypeJsonConverter : JsonConverter<EInteractPlayerDiractionType>
	{
		// Token: 0x060039D1 RID: 14801 RVA: 0x0009590C File Offset: 0x00093B0C
		public override EInteractPlayerDiractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractPlayerDiractionType.Npc;
			}
			return EInteractPlayerDiractionTypeExtensions.FromString(@string);
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x00095930 File Offset: 0x00093B30
		public override void Write(Utf8JsonWriter writer, EInteractPlayerDiractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
