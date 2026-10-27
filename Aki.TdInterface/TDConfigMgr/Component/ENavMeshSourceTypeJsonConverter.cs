using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A9 RID: 2473
	public class ENavMeshSourceTypeJsonConverter : JsonConverter<ENavMeshSourceType>
	{
		// Token: 0x0600372B RID: 14123 RVA: 0x0008F610 File Offset: 0x0008D810
		public override ENavMeshSourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENavMeshSourceType.AkiEntitySource;
			}
			return ENavMeshSourceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x0008F634 File Offset: 0x0008D834
		public override void Write(Utf8JsonWriter writer, ENavMeshSourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
