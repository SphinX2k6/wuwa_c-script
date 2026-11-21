using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024FF RID: 9471
	public class EActorTypeJsonConverter : JsonConverter<EActorType>
	{
		// Token: 0x0600CDD7 RID: 52695 RVA: 0x001DD740 File Offset: 0x001DB940
		public override EActorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorType.MeshActor;
			}
			return EActorTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDD8 RID: 52696 RVA: 0x001DD764 File Offset: 0x001DB964
		public override void Write(Utf8JsonWriter writer, EActorType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
