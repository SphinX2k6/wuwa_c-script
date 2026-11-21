using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002539 RID: 9529
	public class ECameraLockTargetTypeJsonConverter : JsonConverter<ECameraLockTargetType>
	{
		// Token: 0x0600CEDC RID: 52956 RVA: 0x001DFF64 File Offset: 0x001DE164
		public override ECameraLockTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECameraLockTargetType.TargetPosition;
			}
			return ECameraLockTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CEDD RID: 52957 RVA: 0x001DFF88 File Offset: 0x001DE188
		public override void Write(Utf8JsonWriter writer, ECameraLockTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
