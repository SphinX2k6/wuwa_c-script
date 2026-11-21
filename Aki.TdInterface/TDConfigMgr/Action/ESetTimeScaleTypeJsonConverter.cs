using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B1 RID: 9905
	public class ESetTimeScaleTypeJsonConverter : JsonConverter<ESetTimeScaleType>
	{
		// Token: 0x0600D578 RID: 54648 RVA: 0x001EFD70 File Offset: 0x001EDF70
		public override ESetTimeScaleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetTimeScaleType.Open;
			}
			return ESetTimeScaleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x001EFD94 File Offset: 0x001EDF94
		public override void Write(Utf8JsonWriter writer, ESetTimeScaleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
