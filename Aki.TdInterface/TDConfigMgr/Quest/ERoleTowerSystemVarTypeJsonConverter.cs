using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C5 RID: 5061
	public class ERoleTowerSystemVarTypeJsonConverter : JsonConverter<ERoleTowerSystemVarType>
	{
		// Token: 0x06007152 RID: 29010 RVA: 0x0010E83C File Offset: 0x0010CA3C
		public override ERoleTowerSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleTowerSystemVarType.Batch;
			}
			return ERoleTowerSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x0010E860 File Offset: 0x0010CA60
		public override void Write(Utf8JsonWriter writer, ERoleTowerSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
