using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C2 RID: 2498
	public class EControllerTypeJsonConverter : JsonConverter<EControllerType>
	{
		// Token: 0x060037FD RID: 14333 RVA: 0x0009164C File Offset: 0x0008F84C
		public override EControllerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EControllerType.FreeAngle;
			}
			return EControllerTypeExtensions.FromString(@string);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00091670 File Offset: 0x0008F870
		public override void Write(Utf8JsonWriter writer, EControllerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
