using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228C RID: 8844
	public class EActorFaceExpressionTypeJsonConverter : JsonConverter<EActorFaceExpressionType>
	{
		// Token: 0x0600C1F6 RID: 49654 RVA: 0x001C5200 File Offset: 0x001C3400
		public override EActorFaceExpressionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorFaceExpressionType.Play;
			}
			return EActorFaceExpressionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x001C5224 File Offset: 0x001C3424
		public override void Write(Utf8JsonWriter writer, EActorFaceExpressionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
