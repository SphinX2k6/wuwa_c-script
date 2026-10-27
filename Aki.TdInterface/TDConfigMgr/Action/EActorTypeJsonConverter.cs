using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002292 RID: 8850
	public class EActorTypeJsonConverter : JsonConverter<EActorType>
	{
		// Token: 0x0600C211 RID: 49681 RVA: 0x001C5A4C File Offset: 0x001C3C4C
		public override EActorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorType.MeshActor;
			}
			return EActorTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C212 RID: 49682 RVA: 0x001C5A70 File Offset: 0x001C3C70
		public override void Write(Utf8JsonWriter writer, EActorType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
