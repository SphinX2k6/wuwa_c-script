using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D0 RID: 9168
	public class EPlayerMoveTagJsonConverter : JsonConverter<EPlayerMoveTag>
	{
		// Token: 0x0600C7A8 RID: 51112 RVA: 0x001D3AA0 File Offset: 0x001D1CA0
		public override EPlayerMoveTag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerMoveTag.VehicleMotorHighSpeed;
			}
			return EPlayerMoveTagExtensions.FromString(@string);
		}

		// Token: 0x0600C7A9 RID: 51113 RVA: 0x001D3AC4 File Offset: 0x001D1CC4
		public override void Write(Utf8JsonWriter writer, EPlayerMoveTag value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
