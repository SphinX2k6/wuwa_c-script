using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001269 RID: 4713
	public class EPlayerMovementModeJsonConverter : JsonConverter<EPlayerMovementMode>
	{
		// Token: 0x06006A81 RID: 27265 RVA: 0x000FF36C File Offset: 0x000FD56C
		public override EPlayerMovementMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerMovementMode.Ski;
			}
			return EPlayerMovementModeExtensions.FromString(@string);
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x000FF390 File Offset: 0x000FD590
		public override void Write(Utf8JsonWriter writer, EPlayerMovementMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
