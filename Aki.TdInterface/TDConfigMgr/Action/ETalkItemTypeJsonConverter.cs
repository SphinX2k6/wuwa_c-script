using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F9 RID: 9977
	public class ETalkItemTypeJsonConverter : JsonConverter<ETalkItemType>
	{
		// Token: 0x0600D6BC RID: 54972 RVA: 0x001F5A18 File Offset: 0x001F3C18
		public override ETalkItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkItemType.Talk;
			}
			return ETalkItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6BD RID: 54973 RVA: 0x001F5A3C File Offset: 0x001F3C3C
		public override void Write(Utf8JsonWriter writer, ETalkItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
