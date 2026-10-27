using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F4 RID: 8948
	public class ECustomScreenLoadingJsonConverter : JsonConverter<ECustomScreenLoading>
	{
		// Token: 0x0600C3CA RID: 50122 RVA: 0x001C98AC File Offset: 0x001C7AAC
		public override ECustomScreenLoading Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECustomScreenLoading.Cyberpunk;
			}
			return ECustomScreenLoadingExtensions.FromString(@string);
		}

		// Token: 0x0600C3CB RID: 50123 RVA: 0x001C98D0 File Offset: 0x001C7AD0
		public override void Write(Utf8JsonWriter writer, ECustomScreenLoading value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
