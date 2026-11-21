using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025AB RID: 9643
	public class EFadeInScreenShowTypeJsonConverter : JsonConverter<EFadeInScreenShowType>
	{
		// Token: 0x0600D0DD RID: 53469 RVA: 0x001E4384 File Offset: 0x001E2584
		public override EFadeInScreenShowType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeInScreenShowType.White;
			}
			return EFadeInScreenShowTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x001E43A8 File Offset: 0x001E25A8
		public override void Write(Utf8JsonWriter writer, EFadeInScreenShowType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
