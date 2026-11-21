using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002681 RID: 9857
	public class ERemovePreloadResourceObjectTypeJsonConverter : JsonConverter<ERemovePreloadResourceObjectType>
	{
		// Token: 0x0600D4A0 RID: 54432 RVA: 0x001EE3A0 File Offset: 0x001EC5A0
		public override ERemovePreloadResourceObjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			}
			return ERemovePreloadResourceObjectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x001EE3C4 File Offset: 0x001EC5C4
		public override void Write(Utf8JsonWriter writer, ERemovePreloadResourceObjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
