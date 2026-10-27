using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002432 RID: 9266
	public class EStopSceneItemMoveTypeJsonConverter : JsonConverter<EStopSceneItemMoveType>
	{
		// Token: 0x0600C961 RID: 51553 RVA: 0x001D7CF0 File Offset: 0x001D5EF0
		public override EStopSceneItemMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStopSceneItemMoveType.StopAtCurrentPos;
			}
			return EStopSceneItemMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x001D7D14 File Offset: 0x001D5F14
		public override void Write(Utf8JsonWriter writer, EStopSceneItemMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
