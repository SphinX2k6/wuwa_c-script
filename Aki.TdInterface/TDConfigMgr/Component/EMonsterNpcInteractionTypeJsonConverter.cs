using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A56 RID: 2646
	public class EMonsterNpcInteractionTypeJsonConverter : JsonConverter<EMonsterNpcInteractionType>
	{
		// Token: 0x06003A97 RID: 14999 RVA: 0x000972F4 File Offset: 0x000954F4
		public override EMonsterNpcInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterNpcInteractionType.WallRun;
			}
			return EMonsterNpcInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00097318 File Offset: 0x00095518
		public override void Write(Utf8JsonWriter writer, EMonsterNpcInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
