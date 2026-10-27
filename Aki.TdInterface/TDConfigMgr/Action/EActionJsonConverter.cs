using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002286 RID: 8838
	public class EActionJsonConverter : JsonConverter<EAction>
	{
		// Token: 0x0600C1DB RID: 49627 RVA: 0x001C4E20 File Offset: 0x001C3020
		public override EAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAction.Undefined;
			}
			return EActionExtensions.FromString(@string);
		}

		// Token: 0x0600C1DC RID: 49628 RVA: 0x001C4E44 File Offset: 0x001C3044
		public override void Write(Utf8JsonWriter writer, EAction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
