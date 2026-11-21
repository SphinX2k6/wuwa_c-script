using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200139B RID: 5019
	public class ENewHandInItemsTypeJsonConverter : JsonConverter<ENewHandInItemsType>
	{
		// Token: 0x06007095 RID: 28821 RVA: 0x0010C800 File Offset: 0x0010AA00
		public override ENewHandInItemsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENewHandInItemsType.ProjectionMachine;
			}
			return ENewHandInItemsTypeExtensions.FromString(@string);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x0010C824 File Offset: 0x0010AA24
		public override void Write(Utf8JsonWriter writer, ENewHandInItemsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
