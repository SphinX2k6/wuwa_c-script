using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243A RID: 9274
	public class ESubScreenPushDirectionJsonConverter : JsonConverter<ESubScreenPushDirection>
	{
		// Token: 0x0600C985 RID: 51589 RVA: 0x001D81F8 File Offset: 0x001D63F8
		public override ESubScreenPushDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenPushDirection.Left;
			}
			return ESubScreenPushDirectionExtensions.FromString(@string);
		}

		// Token: 0x0600C986 RID: 51590 RVA: 0x001D821C File Offset: 0x001D641C
		public override void Write(Utf8JsonWriter writer, ESubScreenPushDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
