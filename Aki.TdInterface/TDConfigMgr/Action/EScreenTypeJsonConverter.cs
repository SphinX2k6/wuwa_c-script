using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002400 RID: 9216
	public class EScreenTypeJsonConverter : JsonConverter<EScreenType>
	{
		// Token: 0x0600C880 RID: 51328 RVA: 0x001D57E0 File Offset: 0x001D39E0
		public override EScreenType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EScreenType.Main;
			}
			return EScreenTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x001D5804 File Offset: 0x001D3A04
		public override void Write(Utf8JsonWriter writer, EScreenType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
