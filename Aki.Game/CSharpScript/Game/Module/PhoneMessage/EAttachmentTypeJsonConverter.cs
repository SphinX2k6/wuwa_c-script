using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050F9 RID: 20729
	public class EAttachmentTypeJsonConverter : JsonConverter<EAttachmentType>
	{
		// Token: 0x06034FE4 RID: 217060 RVA: 0x00C8D3E4 File Offset: 0x00C8B5E4
		public override EAttachmentType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachmentType.Image;
			}
			return EAttachmentTypeExtensions.FromString(@string);
		}

		// Token: 0x06034FE5 RID: 217061 RVA: 0x00C8D408 File Offset: 0x00C8B608
		public override void Write(Utf8JsonWriter writer, EAttachmentType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
