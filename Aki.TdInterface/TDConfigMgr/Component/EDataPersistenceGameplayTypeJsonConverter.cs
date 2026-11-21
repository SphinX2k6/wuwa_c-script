using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CC RID: 2508
	public class EDataPersistenceGameplayTypeJsonConverter : JsonConverter<EDataPersistenceGameplayType>
	{
		// Token: 0x0600382A RID: 14378 RVA: 0x00091AD0 File Offset: 0x0008FCD0
		public override EDataPersistenceGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDataPersistenceGameplayType.TetrisBoardGame;
			}
			return EDataPersistenceGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00091AF4 File Offset: 0x0008FCF4
		public override void Write(Utf8JsonWriter writer, EDataPersistenceGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
