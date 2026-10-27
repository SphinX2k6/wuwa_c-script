using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002406 RID: 9222
	public class ESetEntityTagTypeJsonConverter : JsonConverter<ESetEntityTagType>
	{
		// Token: 0x0600C89B RID: 51355 RVA: 0x001D5BA4 File Offset: 0x001D3DA4
		public override ESetEntityTagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetEntityTagType.Add;
			}
			return ESetEntityTagTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x001D5BC8 File Offset: 0x001D3DC8
		public override void Write(Utf8JsonWriter writer, ESetEntityTagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
