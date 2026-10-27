using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009ED RID: 2541
	public class EReboundOptionTypeJsonConverter : JsonConverter<EReboundOptionType>
	{
		// Token: 0x0600385D RID: 14429 RVA: 0x00091FD4 File Offset: 0x000901D4
		public override EReboundOptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EReboundOptionType.ForwardFront;
			}
			return EReboundOptionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00091FF8 File Offset: 0x000901F8
		public override void Write(Utf8JsonWriter writer, EReboundOptionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
