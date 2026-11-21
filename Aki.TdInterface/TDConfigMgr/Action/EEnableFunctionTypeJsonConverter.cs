using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200258B RID: 9611
	public class EEnableFunctionTypeJsonConverter : JsonConverter<EEnableFunctionType>
	{
		// Token: 0x0600D04D RID: 53325 RVA: 0x001E2D78 File Offset: 0x001E0F78
		public override EEnableFunctionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableFunctionType.TeleportDungeon;
			}
			return EEnableFunctionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D04E RID: 53326 RVA: 0x001E2D9C File Offset: 0x001E0F9C
		public override void Write(Utf8JsonWriter writer, EEnableFunctionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
