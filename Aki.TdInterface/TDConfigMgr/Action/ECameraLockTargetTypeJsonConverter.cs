using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CA RID: 8906
	public class ECameraLockTargetTypeJsonConverter : JsonConverter<ECameraLockTargetType>
	{
		// Token: 0x0600C30D RID: 49933 RVA: 0x001C815C File Offset: 0x001C635C
		public override ECameraLockTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECameraLockTargetType.TargetPosition;
			}
			return ECameraLockTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x001C8180 File Offset: 0x001C6380
		public override void Write(Utf8JsonWriter writer, ECameraLockTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
