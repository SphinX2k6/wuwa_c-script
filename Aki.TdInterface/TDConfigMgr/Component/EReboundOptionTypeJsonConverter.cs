using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB2 RID: 2738
	public class EReboundOptionTypeJsonConverter : JsonConverter<EReboundOptionType>
	{
		// Token: 0x06003C35 RID: 15413 RVA: 0x0009A894 File Offset: 0x00098A94
		public override EReboundOptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EReboundOptionType.ForwardFront;
			}
			return EReboundOptionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0009A8B8 File Offset: 0x00098AB8
		public override void Write(Utf8JsonWriter writer, EReboundOptionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
