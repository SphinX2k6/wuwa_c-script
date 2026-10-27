using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122D RID: 4653
	public class EBudgetCameraTypeJsonConverter : JsonConverter<EBudgetCameraType>
	{
		// Token: 0x06006973 RID: 26995 RVA: 0x000FB644 File Offset: 0x000F9844
		public override EBudgetCameraType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBudgetCameraType.Role;
			}
			return EBudgetCameraTypeExtensions.FromString(@string);
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x000FB668 File Offset: 0x000F9868
		public override void Write(Utf8JsonWriter writer, EBudgetCameraType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
