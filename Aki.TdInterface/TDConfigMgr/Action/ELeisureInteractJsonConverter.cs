using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E3 RID: 9699
	public class ELeisureInteractJsonConverter : JsonConverter<ELeisureInteract>
	{
		// Token: 0x0600D1D9 RID: 53721 RVA: 0x001E819C File Offset: 0x001E639C
		public override ELeisureInteract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELeisureInteract.CustomSkill;
			}
			return ELeisureInteractExtensions.FromString(@string);
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x001E81C0 File Offset: 0x001E63C0
		public override void Write(Utf8JsonWriter writer, ELeisureInteract value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
