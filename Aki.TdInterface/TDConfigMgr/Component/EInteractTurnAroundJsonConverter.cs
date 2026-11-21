using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A30 RID: 2608
	public class EInteractTurnAroundJsonConverter : JsonConverter<EInteractTurnAround>
	{
		// Token: 0x060039EC RID: 14828 RVA: 0x00095C54 File Offset: 0x00093E54
		public override EInteractTurnAround Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractTurnAround.FaceEachOther;
			}
			return EInteractTurnAroundExtensions.FromString(@string);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00095C78 File Offset: 0x00093E78
		public override void Write(Utf8JsonWriter writer, EInteractTurnAround value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
