using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001365 RID: 4965
	public class EBindingProgressTypeJsonConverter : JsonConverter<EBindingProgressType>
	{
		// Token: 0x06006FA2 RID: 28578 RVA: 0x001089DC File Offset: 0x00106BDC
		public override EBindingProgressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBindingProgressType.PlayerHavingItemCount;
			}
			return EBindingProgressTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x00108A00 File Offset: 0x00106C00
		public override void Write(Utf8JsonWriter writer, EBindingProgressType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
