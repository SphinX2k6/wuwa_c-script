using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200271B RID: 10011
	public class EToggleDragActorPlayTypeJsonConverter : JsonConverter<EToggleDragActorPlayType>
	{
		// Token: 0x0600D755 RID: 55125 RVA: 0x001F7510 File Offset: 0x001F5710
		public override EToggleDragActorPlayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EToggleDragActorPlayType.Enable;
			}
			return EToggleDragActorPlayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x001F7534 File Offset: 0x001F5734
		public override void Write(Utf8JsonWriter writer, EToggleDragActorPlayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
