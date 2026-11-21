using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200270B RID: 9995
	public class ETetrisRotationJsonConverter : JsonConverter<ETetrisRotation>
	{
		// Token: 0x0600D70D RID: 55053 RVA: 0x001F6A70 File Offset: 0x001F4C70
		public override ETetrisRotation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisRotation.Origin;
			}
			return ETetrisRotationExtensions.FromString(@string);
		}

		// Token: 0x0600D70E RID: 55054 RVA: 0x001F6A94 File Offset: 0x001F4C94
		public override void Write(Utf8JsonWriter writer, ETetrisRotation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
