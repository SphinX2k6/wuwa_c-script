using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D6 RID: 8918
	public class EChangeEntityStateJsonConverter : JsonConverter<EChangeEntityState>
	{
		// Token: 0x0600C343 RID: 49987 RVA: 0x001C88A0 File Offset: 0x001C6AA0
		public override EChangeEntityState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeEntityState.Directly;
			}
			return EChangeEntityStateExtensions.FromString(@string);
		}

		// Token: 0x0600C344 RID: 49988 RVA: 0x001C88C4 File Offset: 0x001C6AC4
		public override void Write(Utf8JsonWriter writer, EChangeEntityState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
