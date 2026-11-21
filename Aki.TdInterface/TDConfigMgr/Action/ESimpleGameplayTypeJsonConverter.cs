using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B7 RID: 9911
	public class ESimpleGameplayTypeJsonConverter : JsonConverter<ESimpleGameplayType>
	{
		// Token: 0x0600D593 RID: 54675 RVA: 0x001F0A58 File Offset: 0x001EEC58
		public override ESimpleGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESimpleGameplayType.Cipher;
			}
			return ESimpleGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D594 RID: 54676 RVA: 0x001F0A7C File Offset: 0x001EEC7C
		public override void Write(Utf8JsonWriter writer, ESimpleGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
