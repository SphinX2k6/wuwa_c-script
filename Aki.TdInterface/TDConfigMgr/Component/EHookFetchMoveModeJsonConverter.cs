using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000965 RID: 2405
	public class EHookFetchMoveModeJsonConverter : JsonConverter<EHookFetchMoveMode>
	{
		// Token: 0x060035F9 RID: 13817 RVA: 0x0008CA40 File Offset: 0x0008AC40
		public override EHookFetchMoveMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookFetchMoveMode.Uniform;
			}
			return EHookFetchMoveModeExtensions.FromString(@string);
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x0008CA64 File Offset: 0x0008AC64
		public override void Write(Utf8JsonWriter writer, EHookFetchMoveMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
