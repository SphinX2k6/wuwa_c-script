using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BC RID: 8892
	public class EBlackScreenWhiteTextStartAnimNameJsonConverter : JsonConverter<EBlackScreenWhiteTextStartAnimName>
	{
		// Token: 0x0600C2CE RID: 49870 RVA: 0x001C76B0 File Offset: 0x001C58B0
		public override EBlackScreenWhiteTextStartAnimName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlackScreenWhiteTextStartAnimName.Start01;
			}
			return EBlackScreenWhiteTextStartAnimNameExtensions.FromString(@string);
		}

		// Token: 0x0600C2CF RID: 49871 RVA: 0x001C76D4 File Offset: 0x001C58D4
		public override void Write(Utf8JsonWriter writer, EBlackScreenWhiteTextStartAnimName value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
