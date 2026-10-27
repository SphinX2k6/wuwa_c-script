using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002388 RID: 9096
	public class EMonsterNpcInteractTypeJsonConverter : JsonConverter<EMonsterNpcInteractType>
	{
		// Token: 0x0600C664 RID: 50788 RVA: 0x001D0F2C File Offset: 0x001CF12C
		public override EMonsterNpcInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterNpcInteractType.TriggerHook;
			}
			return EMonsterNpcInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C665 RID: 50789 RVA: 0x001D0F50 File Offset: 0x001CF150
		public override void Write(Utf8JsonWriter writer, EMonsterNpcInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
