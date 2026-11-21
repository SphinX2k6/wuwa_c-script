using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002511 RID: 9489
	public class EAspectRatioJsonConverter : JsonConverter<EAspectRatio>
	{
		// Token: 0x0600CE28 RID: 52776 RVA: 0x001DE3B8 File Offset: 0x001DC5B8
		public override EAspectRatio Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAspectRatio.Ratio16x9;
			}
			return EAspectRatioExtensions.FromString(@string);
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x001DE3DC File Offset: 0x001DC5DC
		public override void Write(Utf8JsonWriter writer, EAspectRatio value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
