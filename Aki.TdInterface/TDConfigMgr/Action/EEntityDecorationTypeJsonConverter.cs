using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002595 RID: 9621
	public class EEntityDecorationTypeJsonConverter : JsonConverter<EEntityDecorationType>
	{
		// Token: 0x0600D07A RID: 53370 RVA: 0x001E326C File Offset: 0x001E146C
		public override EEntityDecorationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityDecorationType.Add;
			}
			return EEntityDecorationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D07B RID: 53371 RVA: 0x001E3290 File Offset: 0x001E1490
		public override void Write(Utf8JsonWriter writer, EEntityDecorationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
