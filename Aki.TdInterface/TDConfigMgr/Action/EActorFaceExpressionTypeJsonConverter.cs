using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F9 RID: 9465
	public class EActorFaceExpressionTypeJsonConverter : JsonConverter<EActorFaceExpressionType>
	{
		// Token: 0x0600CDBC RID: 52668 RVA: 0x001DCEF4 File Offset: 0x001DB0F4
		public override EActorFaceExpressionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorFaceExpressionType.Play;
			}
			return EActorFaceExpressionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDBD RID: 52669 RVA: 0x001DCF18 File Offset: 0x001DB118
		public override void Write(Utf8JsonWriter writer, EActorFaceExpressionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
