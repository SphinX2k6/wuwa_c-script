using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FD RID: 2557
	public class ERotationTypeJsonConverter : JsonConverter<ERotationType>
	{
		// Token: 0x060038A5 RID: 14501 RVA: 0x0009298C File Offset: 0x00090B8C
		public override ERotationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERotationType.Relative;
			}
			return ERotationTypeExtensions.FromString(@string);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x000929B0 File Offset: 0x00090BB0
		public override void Write(Utf8JsonWriter writer, ERotationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
