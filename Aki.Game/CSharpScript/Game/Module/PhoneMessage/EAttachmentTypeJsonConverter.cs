using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040C9 RID: 16585
	public class EAttachmentTypeJsonConverter : JsonConverter<EAttachmentType>
	{
		// Token: 0x06029EDD RID: 171741 RVA: 0x00BDA6C0 File Offset: 0x00BD88C0
		public override EAttachmentType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachmentType.Image;
			}
			return EAttachmentTypeExtensions.FromString(@string);
		}

		// Token: 0x06029EDE RID: 171742 RVA: 0x00BDA6E4 File Offset: 0x00BD88E4
		public override void Write(Utf8JsonWriter writer, EAttachmentType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
