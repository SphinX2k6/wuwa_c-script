using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091F RID: 2335
	public class EDataPersistenceGameplayTypeJsonConverter : JsonConverter<EDataPersistenceGameplayType>
	{
		// Token: 0x060034BE RID: 13502 RVA: 0x00089F50 File Offset: 0x00088150
		public override EDataPersistenceGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDataPersistenceGameplayType.TetrisBoardGame;
			}
			return EDataPersistenceGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00089F74 File Offset: 0x00088174
		public override void Write(Utf8JsonWriter writer, EDataPersistenceGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
