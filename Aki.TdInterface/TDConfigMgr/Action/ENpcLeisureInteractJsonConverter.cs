using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002643 RID: 9795
	public class ENpcLeisureInteractJsonConverter : JsonConverter<ENpcLeisureInteract>
	{
		// Token: 0x0600D389 RID: 54153 RVA: 0x001EBC6C File Offset: 0x001E9E6C
		public override ENpcLeisureInteract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcLeisureInteract.SitDown;
			}
			return ENpcLeisureInteractExtensions.FromString(@string);
		}

		// Token: 0x0600D38A RID: 54154 RVA: 0x001EBC90 File Offset: 0x001E9E90
		public override void Write(Utf8JsonWriter writer, ENpcLeisureInteract value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
