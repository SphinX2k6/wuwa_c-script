using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200267F RID: 9855
	public class ERegionConfigTypeJsonConverter : JsonConverter<ERegionConfigType>
	{
		// Token: 0x0600D497 RID: 54423 RVA: 0x001EE218 File Offset: 0x001EC418
		public override ERegionConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERegionConfigType.Mpc;
			}
			return ERegionConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x001EE23C File Offset: 0x001EC43C
		public override void Write(Utf8JsonWriter writer, ERegionConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
