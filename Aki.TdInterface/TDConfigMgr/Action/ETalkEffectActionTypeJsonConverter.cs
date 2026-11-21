using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F3 RID: 9971
	public class ETalkEffectActionTypeJsonConverter : JsonConverter<ETalkEffectActionType>
	{
		// Token: 0x0600D6A1 RID: 54945 RVA: 0x001F522C File Offset: 0x001F342C
		public override ETalkEffectActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkEffectActionType.Play;
			}
			return ETalkEffectActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x001F5250 File Offset: 0x001F3450
		public override void Write(Utf8JsonWriter writer, ETalkEffectActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
