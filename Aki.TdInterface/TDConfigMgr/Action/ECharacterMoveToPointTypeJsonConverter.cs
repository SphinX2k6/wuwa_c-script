using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002549 RID: 9545
	public class ECharacterMoveToPointTypeJsonConverter : JsonConverter<ECharacterMoveToPointType>
	{
		// Token: 0x0600CF24 RID: 53028 RVA: 0x001E0914 File Offset: 0x001DEB14
		public override ECharacterMoveToPointType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECharacterMoveToPointType.Walk;
			}
			return ECharacterMoveToPointTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x001E0938 File Offset: 0x001DEB38
		public override void Write(Utf8JsonWriter writer, ECharacterMoveToPointType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
