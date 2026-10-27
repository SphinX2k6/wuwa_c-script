using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122F RID: 4655
	public class ECheckPlayerInputTypeJsonConverter : JsonConverter<ECheckPlayerInputType>
	{
		// Token: 0x0600697C RID: 27004 RVA: 0x000FB720 File Offset: 0x000F9920
		public override ECheckPlayerInputType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECheckPlayerInputType.PressButton;
			}
			return ECheckPlayerInputTypeExtensions.FromString(@string);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x000FB744 File Offset: 0x000F9944
		public override void Write(Utf8JsonWriter writer, ECheckPlayerInputType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
