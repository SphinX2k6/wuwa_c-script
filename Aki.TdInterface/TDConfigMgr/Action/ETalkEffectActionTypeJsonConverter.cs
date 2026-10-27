using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002452 RID: 9298
	public class ETalkEffectActionTypeJsonConverter : JsonConverter<ETalkEffectActionType>
	{
		// Token: 0x0600C9F1 RID: 51697 RVA: 0x001DB1BC File Offset: 0x001D93BC
		public override ETalkEffectActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkEffectActionType.Play;
			}
			return ETalkEffectActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9F2 RID: 51698 RVA: 0x001DB1E0 File Offset: 0x001D93E0
		public override void Write(Utf8JsonWriter writer, ETalkEffectActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
