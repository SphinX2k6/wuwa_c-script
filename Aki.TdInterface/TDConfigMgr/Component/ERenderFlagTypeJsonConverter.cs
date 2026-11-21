using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB8 RID: 2744
	public class ERenderFlagTypeJsonConverter : JsonConverter<ERenderFlagType>
	{
		// Token: 0x06003C50 RID: 15440 RVA: 0x0009ACE4 File Offset: 0x00098EE4
		public override ERenderFlagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERenderFlagType.Fog;
			}
			return ERenderFlagTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x0009AD08 File Offset: 0x00098F08
		public override void Write(Utf8JsonWriter writer, ERenderFlagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
