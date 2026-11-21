using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AEE RID: 2798
	public class ESyncDataSystemTypeJsonConverter : JsonConverter<ESyncDataSystemType>
	{
		// Token: 0x06003D43 RID: 15683 RVA: 0x0009CDE0 File Offset: 0x0009AFE0
		public override ESyncDataSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESyncDataSystemType.MotorRacing;
			}
			return ESyncDataSystemTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x0009CE04 File Offset: 0x0009B004
		public override void Write(Utf8JsonWriter writer, ESyncDataSystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
