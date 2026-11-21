using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E8 RID: 2536
	public class EEntityMatchTypeJsonConverter : JsonConverter<EEntityMatchType>
	{
		// Token: 0x060038A8 RID: 14504 RVA: 0x00092AEC File Offset: 0x00090CEC
		public override EEntityMatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityMatchType.Player;
			}
			return EEntityMatchTypeExtensions.FromString(@string);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00092B10 File Offset: 0x00090D10
		public override void Write(Utf8JsonWriter writer, EEntityMatchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
