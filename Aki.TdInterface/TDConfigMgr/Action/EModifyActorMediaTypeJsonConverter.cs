using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200260F RID: 9743
	public class EModifyActorMediaTypeJsonConverter : JsonConverter<EModifyActorMediaType>
	{
		// Token: 0x0600D29F RID: 53919 RVA: 0x001E9E24 File Offset: 0x001E8024
		public override EModifyActorMediaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EModifyActorMediaType.ChangeMediaPlayDA;
			}
			return EModifyActorMediaTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2A0 RID: 53920 RVA: 0x001E9E48 File Offset: 0x001E8048
		public override void Write(Utf8JsonWriter writer, EModifyActorMediaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
