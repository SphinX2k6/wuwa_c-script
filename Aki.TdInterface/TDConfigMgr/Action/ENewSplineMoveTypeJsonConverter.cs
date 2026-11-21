using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002639 RID: 9785
	public class ENewSplineMoveTypeJsonConverter : JsonConverter<ENewSplineMoveType>
	{
		// Token: 0x0600D35C RID: 54108 RVA: 0x001EB6F8 File Offset: 0x001E98F8
		public override ENewSplineMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENewSplineMoveType.FrontAxleTracking;
			}
			return ENewSplineMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x001EB71C File Offset: 0x001E991C
		public override void Write(Utf8JsonWriter writer, ENewSplineMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
