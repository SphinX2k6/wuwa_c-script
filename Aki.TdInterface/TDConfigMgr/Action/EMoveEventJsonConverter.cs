using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239A RID: 9114
	public class EMoveEventJsonConverter : JsonConverter<EMoveEvent>
	{
		// Token: 0x0600C6B5 RID: 50869 RVA: 0x001D1990 File Offset: 0x001CFB90
		public override EMoveEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveEvent.Walk;
			}
			return EMoveEventExtensions.FromString(@string);
		}

		// Token: 0x0600C6B6 RID: 50870 RVA: 0x001D19B4 File Offset: 0x001CFBB4
		public override void Write(Utf8JsonWriter writer, EMoveEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
