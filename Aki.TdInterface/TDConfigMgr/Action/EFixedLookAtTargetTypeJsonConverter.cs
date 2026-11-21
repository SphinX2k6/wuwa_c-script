using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025AF RID: 9647
	public class EFixedLookAtTargetTypeJsonConverter : JsonConverter<EFixedLookAtTargetType>
	{
		// Token: 0x0600D0EF RID: 53487 RVA: 0x001E45B8 File Offset: 0x001E27B8
		public override EFixedLookAtTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFixedLookAtTargetType.RangeEntity;
			}
			return EFixedLookAtTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x001E45DC File Offset: 0x001E27DC
		public override void Write(Utf8JsonWriter writer, EFixedLookAtTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
