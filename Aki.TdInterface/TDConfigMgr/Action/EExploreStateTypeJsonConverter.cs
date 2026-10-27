using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232E RID: 9006
	public class EExploreStateTypeJsonConverter : JsonConverter<EExploreStateType>
	{
		// Token: 0x0600C4CF RID: 50383 RVA: 0x001CBBD4 File Offset: 0x001C9DD4
		public override EExploreStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExploreStateType.TeleControl;
			}
			return EExploreStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x001CBBF8 File Offset: 0x001C9DF8
		public override void Write(Utf8JsonWriter writer, EExploreStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
