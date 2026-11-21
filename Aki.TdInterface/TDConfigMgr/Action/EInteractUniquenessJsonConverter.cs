using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025DB RID: 9691
	public class EInteractUniquenessJsonConverter : JsonConverter<EInteractUniqueness>
	{
		// Token: 0x0600D1B5 RID: 53685 RVA: 0x001E6E50 File Offset: 0x001E5050
		public override EInteractUniqueness Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractUniqueness.Closest;
			}
			return EInteractUniquenessExtensions.FromString(@string);
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x001E6E74 File Offset: 0x001E5074
		public override void Write(Utf8JsonWriter writer, EInteractUniqueness value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
