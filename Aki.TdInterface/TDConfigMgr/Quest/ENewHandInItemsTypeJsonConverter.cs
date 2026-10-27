using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125B RID: 4699
	public class ENewHandInItemsTypeJsonConverter : JsonConverter<ENewHandInItemsType>
	{
		// Token: 0x06006A42 RID: 27202 RVA: 0x000FEBD4 File Offset: 0x000FCDD4
		public override ENewHandInItemsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENewHandInItemsType.ProjectionMachine;
			}
			return ENewHandInItemsTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x000FEBF8 File Offset: 0x000FCDF8
		public override void Write(Utf8JsonWriter writer, ENewHandInItemsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
