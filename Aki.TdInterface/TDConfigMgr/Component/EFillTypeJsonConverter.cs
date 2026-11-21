using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FA RID: 2554
	public class EFillTypeJsonConverter : JsonConverter<EFillType>
	{
		// Token: 0x060038F9 RID: 14585 RVA: 0x000937C8 File Offset: 0x000919C8
		public override EFillType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFillType.Fixed;
			}
			return EFillTypeExtensions.FromString(@string);
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x000937EC File Offset: 0x000919EC
		public override void Write(Utf8JsonWriter writer, EFillType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
