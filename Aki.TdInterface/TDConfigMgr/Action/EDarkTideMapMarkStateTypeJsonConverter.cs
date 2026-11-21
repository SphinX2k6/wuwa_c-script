using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002567 RID: 9575
	public class EDarkTideMapMarkStateTypeJsonConverter : JsonConverter<EDarkTideMapMarkStateType>
	{
		// Token: 0x0600CFAB RID: 53163 RVA: 0x001E19A8 File Offset: 0x001DFBA8
		public override EDarkTideMapMarkStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDarkTideMapMarkStateType.Hide;
			}
			return EDarkTideMapMarkStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFAC RID: 53164 RVA: 0x001E19CC File Offset: 0x001DFBCC
		public override void Write(Utf8JsonWriter writer, EDarkTideMapMarkStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
