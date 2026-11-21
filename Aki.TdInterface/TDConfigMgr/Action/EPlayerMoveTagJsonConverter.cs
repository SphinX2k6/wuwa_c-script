using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002667 RID: 9831
	public class EPlayerMoveTagJsonConverter : JsonConverter<EPlayerMoveTag>
	{
		// Token: 0x0600D42B RID: 54315 RVA: 0x001ED24C File Offset: 0x001EB44C
		public override EPlayerMoveTag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerMoveTag.VehicleMotorHighSpeed;
			}
			return EPlayerMoveTagExtensions.FromString(@string);
		}

		// Token: 0x0600D42C RID: 54316 RVA: 0x001ED270 File Offset: 0x001EB470
		public override void Write(Utf8JsonWriter writer, EPlayerMoveTag value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
