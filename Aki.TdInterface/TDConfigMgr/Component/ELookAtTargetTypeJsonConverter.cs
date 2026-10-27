using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000997 RID: 2455
	public class ELookAtTargetTypeJsonConverter : JsonConverter<ELookAtTargetType>
	{
		// Token: 0x060036DA RID: 14042 RVA: 0x0008EC1C File Offset: 0x0008CE1C
		public override ELookAtTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELookAtTargetType.Entity;
			}
			return ELookAtTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0008EC40 File Offset: 0x0008CE40
		public override void Write(Utf8JsonWriter writer, ELookAtTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
