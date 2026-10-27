using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002308 RID: 8968
	public class EDoInteractJsonConverter : JsonConverter<EDoInteract>
	{
		// Token: 0x0600C424 RID: 50212 RVA: 0x001CA39C File Offset: 0x001C859C
		public override EDoInteract Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDoInteract.Direct;
			}
			return EDoInteractExtensions.FromString(@string);
		}

		// Token: 0x0600C425 RID: 50213 RVA: 0x001CA3C0 File Offset: 0x001C85C0
		public override void Write(Utf8JsonWriter writer, EDoInteract value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
