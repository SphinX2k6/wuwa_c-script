using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C9 RID: 5065
	public class ERollBlockLaunchMethodJsonConverter : JsonConverter<ERollBlockLaunchMethod>
	{
		// Token: 0x06007164 RID: 29028 RVA: 0x0010EAA8 File Offset: 0x0010CCA8
		public override ERollBlockLaunchMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERollBlockLaunchMethod.Interact;
			}
			return ERollBlockLaunchMethodExtensions.FromString(@string);
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x0010EACC File Offset: 0x0010CCCC
		public override void Write(Utf8JsonWriter writer, ERollBlockLaunchMethod value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
