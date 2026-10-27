using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001289 RID: 4745
	public class ERollBlockLaunchMethodJsonConverter : JsonConverter<ERollBlockLaunchMethod>
	{
		// Token: 0x06006B11 RID: 27409 RVA: 0x00100DAC File Offset: 0x000FEFAC
		public override ERollBlockLaunchMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERollBlockLaunchMethod.Interact;
			}
			return ERollBlockLaunchMethodExtensions.FromString(@string);
		}

		// Token: 0x06006B12 RID: 27410 RVA: 0x00100DD0 File Offset: 0x000FEFD0
		public override void Write(Utf8JsonWriter writer, ERollBlockLaunchMethod value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
