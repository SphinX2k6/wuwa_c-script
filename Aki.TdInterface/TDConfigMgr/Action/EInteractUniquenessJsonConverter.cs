using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002366 RID: 9062
	public class EInteractUniquenessJsonConverter : JsonConverter<EInteractUniqueness>
	{
		// Token: 0x0600C5CB RID: 50635 RVA: 0x001CEB70 File Offset: 0x001CCD70
		public override EInteractUniqueness Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractUniqueness.Closest;
			}
			return EInteractUniquenessExtensions.FromString(@string);
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x001CEB94 File Offset: 0x001CCD94
		public override void Write(Utf8JsonWriter writer, EInteractUniqueness value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
