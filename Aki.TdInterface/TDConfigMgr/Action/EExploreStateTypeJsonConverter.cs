using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200259F RID: 9631
	public class EExploreStateTypeJsonConverter : JsonConverter<EExploreStateType>
	{
		// Token: 0x0600D0A7 RID: 53415 RVA: 0x001E3C8C File Offset: 0x001E1E8C
		public override EExploreStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExploreStateType.TeleControl;
			}
			return EExploreStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x001E3CB0 File Offset: 0x001E1EB0
		public override void Write(Utf8JsonWriter writer, EExploreStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
