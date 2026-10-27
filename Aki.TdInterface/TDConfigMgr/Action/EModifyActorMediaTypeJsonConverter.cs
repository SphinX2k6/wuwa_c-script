using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002386 RID: 9094
	public class EModifyActorMediaTypeJsonConverter : JsonConverter<EModifyActorMediaType>
	{
		// Token: 0x0600C65B RID: 50779 RVA: 0x001D0E50 File Offset: 0x001CF050
		public override EModifyActorMediaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EModifyActorMediaType.ChangeMediaPlayDA;
			}
			return EModifyActorMediaTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x001D0E74 File Offset: 0x001CF074
		public override void Write(Utf8JsonWriter writer, EModifyActorMediaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
