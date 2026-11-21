using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002545 RID: 9541
	public class EChangeEntityStateJsonConverter : JsonConverter<EChangeEntityState>
	{
		// Token: 0x0600CF12 RID: 53010 RVA: 0x001E06A8 File Offset: 0x001DE8A8
		public override EChangeEntityState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeEntityState.Directly;
			}
			return EChangeEntityStateExtensions.FromString(@string);
		}

		// Token: 0x0600CF13 RID: 53011 RVA: 0x001E06CC File Offset: 0x001DE8CC
		public override void Write(Utf8JsonWriter writer, EChangeEntityState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
