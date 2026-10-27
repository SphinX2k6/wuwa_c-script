using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001285 RID: 4741
	public class ERoleTowerSystemVarTypeJsonConverter : JsonConverter<ERoleTowerSystemVarType>
	{
		// Token: 0x06006AFF RID: 27391 RVA: 0x00100B40 File Offset: 0x000FED40
		public override ERoleTowerSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleTowerSystemVarType.Batch;
			}
			return ERoleTowerSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00100B64 File Offset: 0x000FED64
		public override void Write(Utf8JsonWriter writer, ERoleTowerSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
