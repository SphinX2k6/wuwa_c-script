using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002625 RID: 9765
	public class EMoveEventJsonConverter : JsonConverter<EMoveEvent>
	{
		// Token: 0x0600D302 RID: 54018 RVA: 0x001EAB30 File Offset: 0x001E8D30
		public override EMoveEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveEvent.Walk;
			}
			return EMoveEventExtensions.FromString(@string);
		}

		// Token: 0x0600D303 RID: 54019 RVA: 0x001EAB54 File Offset: 0x001E8D54
		public override void Write(Utf8JsonWriter writer, EMoveEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
