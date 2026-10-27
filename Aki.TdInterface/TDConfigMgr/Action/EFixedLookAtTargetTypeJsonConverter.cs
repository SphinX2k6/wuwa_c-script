using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233E RID: 9022
	public class EFixedLookAtTargetTypeJsonConverter : JsonConverter<EFixedLookAtTargetType>
	{
		// Token: 0x0600C517 RID: 50455 RVA: 0x001CC500 File Offset: 0x001CA700
		public override EFixedLookAtTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFixedLookAtTargetType.RangeEntity;
			}
			return EFixedLookAtTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C518 RID: 50456 RVA: 0x001CC524 File Offset: 0x001CA724
		public override void Write(Utf8JsonWriter writer, EFixedLookAtTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
