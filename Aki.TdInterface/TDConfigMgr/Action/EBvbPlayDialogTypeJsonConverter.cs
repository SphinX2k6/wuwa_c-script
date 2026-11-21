using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002535 RID: 9525
	public class EBvbPlayDialogTypeJsonConverter : JsonConverter<EBvbPlayDialogType>
	{
		// Token: 0x0600CECA RID: 52938 RVA: 0x001DFB2C File Offset: 0x001DDD2C
		public override EBvbPlayDialogType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBvbPlayDialogType.DungeonBegin;
			}
			return EBvbPlayDialogTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x001DFB50 File Offset: 0x001DDD50
		public override void Write(Utf8JsonWriter writer, EBvbPlayDialogType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
