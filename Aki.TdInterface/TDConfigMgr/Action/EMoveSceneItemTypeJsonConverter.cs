using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A0 RID: 9120
	public class EMoveSceneItemTypeJsonConverter : JsonConverter<EMoveSceneItemType>
	{
		// Token: 0x0600C6D0 RID: 50896 RVA: 0x001D1D40 File Offset: 0x001CFF40
		public override EMoveSceneItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveSceneItemType.MoveToPoint;
			}
			return EMoveSceneItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x001D1D64 File Offset: 0x001CFF64
		public override void Write(Utf8JsonWriter writer, EMoveSceneItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
