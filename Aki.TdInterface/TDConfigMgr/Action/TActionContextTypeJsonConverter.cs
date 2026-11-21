using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002765 RID: 10085
	public class TActionContextTypeJsonConverter : JsonConverter<TActionContextType>
	{
		// Token: 0x0600D8A2 RID: 55458 RVA: 0x001FA898 File Offset: 0x001F8A98
		public override TActionContextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TActionContextType.commonBt;
			}
			return TActionContextTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D8A3 RID: 55459 RVA: 0x001FA8BC File Offset: 0x001F8ABC
		public override void Write(Utf8JsonWriter writer, TActionContextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
