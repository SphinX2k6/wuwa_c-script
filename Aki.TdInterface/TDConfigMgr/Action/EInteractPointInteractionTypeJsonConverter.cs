using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D9 RID: 9689
	public class EInteractPointInteractionTypeJsonConverter : JsonConverter<EInteractPointInteractionType>
	{
		// Token: 0x0600D1AC RID: 53676 RVA: 0x001E6D74 File Offset: 0x001E4F74
		public override EInteractPointInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractPointInteractionType.Drag;
			}
			return EInteractPointInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D1AD RID: 53677 RVA: 0x001E6D98 File Offset: 0x001E4F98
		public override void Write(Utf8JsonWriter writer, EInteractPointInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
