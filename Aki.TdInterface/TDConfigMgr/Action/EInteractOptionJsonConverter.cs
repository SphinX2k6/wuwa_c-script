using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002362 RID: 9058
	public class EInteractOptionJsonConverter : JsonConverter<EInteractOption>
	{
		// Token: 0x0600C5B9 RID: 50617 RVA: 0x001CE9B8 File Offset: 0x001CCBB8
		public override EInteractOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractOption.Flow;
			}
			return EInteractOptionExtensions.FromString(@string);
		}

		// Token: 0x0600C5BA RID: 50618 RVA: 0x001CE9DC File Offset: 0x001CCBDC
		public override void Write(Utf8JsonWriter writer, EInteractOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
