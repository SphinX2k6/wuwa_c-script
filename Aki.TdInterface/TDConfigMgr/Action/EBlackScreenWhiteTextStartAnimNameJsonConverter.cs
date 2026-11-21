using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200252B RID: 9515
	public class EBlackScreenWhiteTextStartAnimNameJsonConverter : JsonConverter<EBlackScreenWhiteTextStartAnimName>
	{
		// Token: 0x0600CE9D RID: 52893 RVA: 0x001DF4B8 File Offset: 0x001DD6B8
		public override EBlackScreenWhiteTextStartAnimName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlackScreenWhiteTextStartAnimName.Start01;
			}
			return EBlackScreenWhiteTextStartAnimNameExtensions.FromString(@string);
		}

		// Token: 0x0600CE9E RID: 52894 RVA: 0x001DF4DC File Offset: 0x001DD6DC
		public override void Write(Utf8JsonWriter writer, EBlackScreenWhiteTextStartAnimName value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
