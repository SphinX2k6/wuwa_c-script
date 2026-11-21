using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002563 RID: 9571
	public class ECustomScreenLoadingJsonConverter : JsonConverter<ECustomScreenLoading>
	{
		// Token: 0x0600CF99 RID: 53145 RVA: 0x001E16F8 File Offset: 0x001DF8F8
		public override ECustomScreenLoading Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECustomScreenLoading.Cyberpunk;
			}
			return ECustomScreenLoadingExtensions.FromString(@string);
		}

		// Token: 0x0600CF9A RID: 53146 RVA: 0x001E171C File Offset: 0x001DF91C
		public override void Write(Utf8JsonWriter writer, ECustomScreenLoading value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
