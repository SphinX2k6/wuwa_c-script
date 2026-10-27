using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124B RID: 4683
	public class EInformationBoardTypeJsonConverter : JsonConverter<EInformationBoardType>
	{
		// Token: 0x060069FA RID: 27130 RVA: 0x000FDD40 File Offset: 0x000FBF40
		public override EInformationBoardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInformationBoardType.DangoAbyss;
			}
			return EInformationBoardTypeExtensions.FromString(@string);
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x000FDD64 File Offset: 0x000FBF64
		public override void Write(Utf8JsonWriter writer, EInformationBoardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
