using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A44 RID: 2628
	public class ELockTypeJsonConverter : JsonConverter<ELockType>
	{
		// Token: 0x06003A46 RID: 14918 RVA: 0x0009684C File Offset: 0x00094A4C
		public override ELockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELockType.Default;
			}
			return ELockTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00096870 File Offset: 0x00094A70
		public override void Write(Utf8JsonWriter writer, ELockType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
