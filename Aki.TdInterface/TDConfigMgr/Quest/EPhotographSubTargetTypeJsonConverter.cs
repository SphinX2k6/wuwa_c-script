using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A1 RID: 5025
	public class EPhotographSubTargetTypeJsonConverter : JsonConverter<EPhotographSubTargetType>
	{
		// Token: 0x060070B0 RID: 28848 RVA: 0x0010CB04 File Offset: 0x0010AD04
		public override EPhotographSubTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhotographSubTargetType.SpecificRole;
			}
			return EPhotographSubTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x0010CB28 File Offset: 0x0010AD28
		public override void Write(Utf8JsonWriter writer, EPhotographSubTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
