using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D3 RID: 9939
	public class EStopSceneItemMoveTypeJsonConverter : JsonConverter<EStopSceneItemMoveType>
	{
		// Token: 0x0600D611 RID: 54801 RVA: 0x001F1BB8 File Offset: 0x001EFDB8
		public override EStopSceneItemMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStopSceneItemMoveType.StopAtCurrentPos;
			}
			return EStopSceneItemMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x001F1BDC File Offset: 0x001EFDDC
		public override void Write(Utf8JsonWriter writer, EStopSceneItemMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
