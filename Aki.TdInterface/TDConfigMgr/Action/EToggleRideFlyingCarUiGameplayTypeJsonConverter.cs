using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200271D RID: 10013
	public class EToggleRideFlyingCarUiGameplayTypeJsonConverter : JsonConverter<EToggleRideFlyingCarUiGameplayType>
	{
		// Token: 0x0600D75E RID: 55134 RVA: 0x001F7624 File Offset: 0x001F5824
		public override EToggleRideFlyingCarUiGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EToggleRideFlyingCarUiGameplayType.Enable;
			}
			return EToggleRideFlyingCarUiGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D75F RID: 55135 RVA: 0x001F7648 File Offset: 0x001F5848
		public override void Write(Utf8JsonWriter writer, EToggleRideFlyingCarUiGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
