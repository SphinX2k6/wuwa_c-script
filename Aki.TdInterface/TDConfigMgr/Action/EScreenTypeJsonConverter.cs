using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200269F RID: 9887
	public class EScreenTypeJsonConverter : JsonConverter<EScreenType>
	{
		// Token: 0x0600D527 RID: 54567 RVA: 0x001EF3DC File Offset: 0x001ED5DC
		public override EScreenType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EScreenType.Main;
			}
			return EScreenTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D528 RID: 54568 RVA: 0x001EF400 File Offset: 0x001ED600
		public override void Write(Utf8JsonWriter writer, EScreenType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
