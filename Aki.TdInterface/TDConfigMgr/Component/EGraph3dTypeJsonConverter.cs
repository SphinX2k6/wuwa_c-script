using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A08 RID: 2568
	public class EGraph3dTypeJsonConverter : JsonConverter<EGraph3dType>
	{
		// Token: 0x06003938 RID: 14648 RVA: 0x00093EE8 File Offset: 0x000920E8
		public override EGraph3dType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGraph3dType.Normal;
			}
			return EGraph3dTypeExtensions.FromString(@string);
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00093F0C File Offset: 0x0009210C
		public override void Write(Utf8JsonWriter writer, EGraph3dType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
