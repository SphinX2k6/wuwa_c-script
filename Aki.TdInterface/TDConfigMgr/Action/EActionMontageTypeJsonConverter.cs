using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F5 RID: 9461
	public class EActionMontageTypeJsonConverter : JsonConverter<EActionMontageType>
	{
		// Token: 0x0600CDAA RID: 52650 RVA: 0x001DCC28 File Offset: 0x001DAE28
		public override EActionMontageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActionMontageType.Normal;
			}
			return EActionMontageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDAB RID: 52651 RVA: 0x001DCC4C File Offset: 0x001DAE4C
		public override void Write(Utf8JsonWriter writer, EActionMontageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
