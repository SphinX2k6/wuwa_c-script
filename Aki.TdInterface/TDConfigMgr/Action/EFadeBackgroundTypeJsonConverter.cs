using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002336 RID: 9014
	public class EFadeBackgroundTypeJsonConverter : JsonConverter<EFadeBackgroundType>
	{
		// Token: 0x0600C4F3 RID: 50419 RVA: 0x001CC0DC File Offset: 0x001CA2DC
		public override EFadeBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundType.Spine;
			}
			return EFadeBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4F4 RID: 50420 RVA: 0x001CC100 File Offset: 0x001CA300
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
