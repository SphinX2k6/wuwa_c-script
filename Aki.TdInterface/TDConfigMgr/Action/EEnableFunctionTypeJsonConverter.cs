using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231C RID: 8988
	public class EEnableFunctionTypeJsonConverter : JsonConverter<EEnableFunctionType>
	{
		// Token: 0x0600C47E RID: 50302 RVA: 0x001CAEB0 File Offset: 0x001C90B0
		public override EEnableFunctionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableFunctionType.TeleportDungeon;
			}
			return EEnableFunctionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x001CAED4 File Offset: 0x001C90D4
		public override void Write(Utf8JsonWriter writer, EEnableFunctionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
