using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A1 RID: 2465
	public class EMonsterNpcInteractionTypeJsonConverter : JsonConverter<EMonsterNpcInteractionType>
	{
		// Token: 0x06003707 RID: 14087 RVA: 0x0008F230 File Offset: 0x0008D430
		public override EMonsterNpcInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterNpcInteractionType.WallRun;
			}
			return EMonsterNpcInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x0008F254 File Offset: 0x0008D454
		public override void Write(Utf8JsonWriter writer, EMonsterNpcInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
