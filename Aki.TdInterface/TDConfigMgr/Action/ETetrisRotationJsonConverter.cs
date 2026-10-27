using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246A RID: 9322
	public class ETetrisRotationJsonConverter : JsonConverter<ETetrisRotation>
	{
		// Token: 0x0600CA5D RID: 51805 RVA: 0x001DC9BC File Offset: 0x001DABBC
		public override ETetrisRotation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisRotation.Origin;
			}
			return ETetrisRotationExtensions.FromString(@string);
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x001DC9E0 File Offset: 0x001DABE0
		public override void Write(Utf8JsonWriter writer, ETetrisRotation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
