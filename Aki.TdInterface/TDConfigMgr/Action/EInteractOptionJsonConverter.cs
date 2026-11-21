using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D7 RID: 9687
	public class EInteractOptionJsonConverter : JsonConverter<EInteractOption>
	{
		// Token: 0x0600D1A3 RID: 53667 RVA: 0x001E6C98 File Offset: 0x001E4E98
		public override EInteractOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractOption.Flow;
			}
			return EInteractOptionExtensions.FromString(@string);
		}

		// Token: 0x0600D1A4 RID: 53668 RVA: 0x001E6CBC File Offset: 0x001E4EBC
		public override void Write(Utf8JsonWriter writer, EInteractOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
