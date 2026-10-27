using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247A RID: 9338
	public class EToggleDragActorPlayTypeJsonConverter : JsonConverter<EToggleDragActorPlayType>
	{
		// Token: 0x0600CAA5 RID: 51877 RVA: 0x001DD45C File Offset: 0x001DB65C
		public override EToggleDragActorPlayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EToggleDragActorPlayType.Enable;
			}
			return EToggleDragActorPlayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAA6 RID: 51878 RVA: 0x001DD480 File Offset: 0x001DB680
		public override void Write(Utf8JsonWriter writer, EToggleDragActorPlayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
