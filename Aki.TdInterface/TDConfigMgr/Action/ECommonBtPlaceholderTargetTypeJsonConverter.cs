using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200255B RID: 9563
	public class ECommonBtPlaceholderTargetTypeJsonConverter : JsonConverter<ECommonBtPlaceholderTargetType>
	{
		// Token: 0x0600CF75 RID: 53109 RVA: 0x001E129C File Offset: 0x001DF49C
		public override ECommonBtPlaceholderTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECommonBtPlaceholderTargetType.Action;
			}
			return ECommonBtPlaceholderTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF76 RID: 53110 RVA: 0x001E12C0 File Offset: 0x001DF4C0
		public override void Write(Utf8JsonWriter writer, ECommonBtPlaceholderTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
