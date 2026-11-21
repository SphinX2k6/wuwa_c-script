using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A72 RID: 2674
	public class EPasserbyNpcExitIntervalTypeJsonConverter : JsonConverter<EPasserbyNpcExitIntervalType>
	{
		// Token: 0x06003B15 RID: 15125 RVA: 0x00098894 File Offset: 0x00096A94
		public override EPasserbyNpcExitIntervalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcExitIntervalType.PerNpcRandom;
			}
			return EPasserbyNpcExitIntervalTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x000988B8 File Offset: 0x00096AB8
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcExitIntervalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
