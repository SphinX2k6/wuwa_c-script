using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E6 RID: 9190
	public class ERandomPrefabTypeJsonConverter : JsonConverter<ERandomPrefabType>
	{
		// Token: 0x0600C80B RID: 51211 RVA: 0x001D4990 File Offset: 0x001D2B90
		public override ERandomPrefabType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERandomPrefabType.Rogue;
			}
			return ERandomPrefabTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x001D49B4 File Offset: 0x001D2BB4
		public override void Write(Utf8JsonWriter writer, ERandomPrefabType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
