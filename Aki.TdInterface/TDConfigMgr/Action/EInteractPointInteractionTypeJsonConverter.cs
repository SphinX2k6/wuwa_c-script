using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002364 RID: 9060
	public class EInteractPointInteractionTypeJsonConverter : JsonConverter<EInteractPointInteractionType>
	{
		// Token: 0x0600C5C2 RID: 50626 RVA: 0x001CEA94 File Offset: 0x001CCC94
		public override EInteractPointInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractPointInteractionType.Drag;
			}
			return EInteractPointInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x001CEAB8 File Offset: 0x001CCCB8
		public override void Write(Utf8JsonWriter writer, EInteractPointInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
