using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A9 RID: 5033
	public class EPlayerMovementModeJsonConverter : JsonConverter<EPlayerMovementMode>
	{
		// Token: 0x060070D4 RID: 28884 RVA: 0x0010CF98 File Offset: 0x0010B198
		public override EPlayerMovementMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerMovementMode.Ski;
			}
			return EPlayerMovementModeExtensions.FromString(@string);
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x0010CFBC File Offset: 0x0010B1BC
		public override void Write(Utf8JsonWriter writer, EPlayerMovementMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
