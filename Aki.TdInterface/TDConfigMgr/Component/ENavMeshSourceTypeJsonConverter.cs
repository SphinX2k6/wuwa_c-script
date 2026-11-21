using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A5E RID: 2654
	public class ENavMeshSourceTypeJsonConverter : JsonConverter<ENavMeshSourceType>
	{
		// Token: 0x06003ABB RID: 15035 RVA: 0x000976D4 File Offset: 0x000958D4
		public override ENavMeshSourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENavMeshSourceType.AkiEntitySource;
			}
			return ENavMeshSourceTypeExtensions.FromString(@string);
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000976F8 File Offset: 0x000958F8
		public override void Write(Utf8JsonWriter writer, ENavMeshSourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
