using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AC RID: 9132
	public class ENewSplineMoveTargetTypeJsonConverter : JsonConverter<ENewSplineMoveTargetType>
	{
		// Token: 0x0600C706 RID: 50950 RVA: 0x001D247C File Offset: 0x001D067C
		public override ENewSplineMoveTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENewSplineMoveTargetType.Player;
			}
			return ENewSplineMoveTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x001D24A0 File Offset: 0x001D06A0
		public override void Write(Utf8JsonWriter writer, ENewSplineMoveTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
