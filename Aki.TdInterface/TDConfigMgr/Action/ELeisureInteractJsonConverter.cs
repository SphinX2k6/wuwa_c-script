using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236E RID: 9070
	public class ELeisureInteractJsonConverter : JsonConverter<ELeisureInteract>
	{
		// Token: 0x0600C5EF RID: 50671 RVA: 0x001CFEBC File Offset: 0x001CE0BC
		public override ELeisureInteract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELeisureInteract.CustomSkill;
			}
			return ELeisureInteractExtensions.FromString(@string);
		}

		// Token: 0x0600C5F0 RID: 50672 RVA: 0x001CFEE0 File Offset: 0x001CE0E0
		public override void Write(Utf8JsonWriter writer, ELeisureInteract value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
