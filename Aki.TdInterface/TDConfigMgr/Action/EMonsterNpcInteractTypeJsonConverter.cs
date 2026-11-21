using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002611 RID: 9745
	public class EMonsterNpcInteractTypeJsonConverter : JsonConverter<EMonsterNpcInteractType>
	{
		// Token: 0x0600D2A8 RID: 53928 RVA: 0x001E9F00 File Offset: 0x001E8100
		public override EMonsterNpcInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterNpcInteractType.TriggerHook;
			}
			return EMonsterNpcInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2A9 RID: 53929 RVA: 0x001E9F24 File Offset: 0x001E8124
		public override void Write(Utf8JsonWriter writer, EMonsterNpcInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
