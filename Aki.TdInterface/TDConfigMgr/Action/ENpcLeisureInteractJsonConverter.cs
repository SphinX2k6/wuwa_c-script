using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B2 RID: 9138
	public class ENpcLeisureInteractJsonConverter : JsonConverter<ENpcLeisureInteract>
	{
		// Token: 0x0600C721 RID: 50977 RVA: 0x001D2838 File Offset: 0x001D0A38
		public override ENpcLeisureInteract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcLeisureInteract.SitDown;
			}
			return ENpcLeisureInteractExtensions.FromString(@string);
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x001D285C File Offset: 0x001D0A5C
		public override void Write(Utf8JsonWriter writer, ENpcLeisureInteract value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
