using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A2 RID: 8866
	public class EAoiNotifyStateJsonConverter : JsonConverter<EAoiNotifyState>
	{
		// Token: 0x0600C259 RID: 49753 RVA: 0x001C65B0 File Offset: 0x001C47B0
		public override EAoiNotifyState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAoiNotifyState.Open;
			}
			return EAoiNotifyStateExtensions.FromString(@string);
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x001C65D4 File Offset: 0x001C47D4
		public override void Write(Utf8JsonWriter writer, EAoiNotifyState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
