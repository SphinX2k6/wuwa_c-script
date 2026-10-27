using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F0 RID: 9200
	public class EResetPosTypeJsonConverter : JsonConverter<EResetPosType>
	{
		// Token: 0x0600C838 RID: 51256 RVA: 0x001D4F30 File Offset: 0x001D3130
		public override EResetPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetPosType.PosEntity;
			}
			return EResetPosTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C839 RID: 51257 RVA: 0x001D4F54 File Offset: 0x001D3154
		public override void Write(Utf8JsonWriter writer, EResetPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
