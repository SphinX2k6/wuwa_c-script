using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EA RID: 9194
	public class ERemovePreloadResourceObjectTypeJsonConverter : JsonConverter<ERemovePreloadResourceObjectType>
	{
		// Token: 0x0600C81D RID: 51229 RVA: 0x001D4BF4 File Offset: 0x001D2DF4
		public override ERemovePreloadResourceObjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			}
			return ERemovePreloadResourceObjectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x001D4C18 File Offset: 0x001D2E18
		public override void Write(Utf8JsonWriter writer, ERemovePreloadResourceObjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
