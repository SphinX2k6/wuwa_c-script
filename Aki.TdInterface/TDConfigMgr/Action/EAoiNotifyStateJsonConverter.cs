using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200250F RID: 9487
	public class EAoiNotifyStateJsonConverter : JsonConverter<EAoiNotifyState>
	{
		// Token: 0x0600CE1F RID: 52767 RVA: 0x001DE2A4 File Offset: 0x001DC4A4
		public override EAoiNotifyState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAoiNotifyState.Open;
			}
			return EAoiNotifyStateExtensions.FromString(@string);
		}

		// Token: 0x0600CE20 RID: 52768 RVA: 0x001DE2C8 File Offset: 0x001DC4C8
		public override void Write(Utf8JsonWriter writer, EAoiNotifyState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
