using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A26 RID: 2598
	public class EInteractDefaultIconJsonConverter : JsonConverter<EInteractDefaultIcon>
	{
		// Token: 0x060039BF RID: 14783 RVA: 0x000956E4 File Offset: 0x000938E4
		public override EInteractDefaultIcon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractDefaultIcon.Collect;
			}
			return EInteractDefaultIconExtensions.FromString(@string);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00095708 File Offset: 0x00093908
		public override void Write(Utf8JsonWriter writer, EInteractDefaultIcon value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
